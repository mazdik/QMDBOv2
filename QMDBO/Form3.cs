﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.IO;

namespace QMDBO
{
    public partial class Form3 : Form
    {
        DatabaseContext _context;
        MDIParent1 frm;
        public Form3()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            frm = this.MdiParent as MDIParent1;

            _context = new DatabaseContext();

            // Call the Load method to get the data for the given DbSet  
            // from the database.  
            // The data is materialized as entities. The entities are managed by  
            // the DbContext instance.  
            _context.Categories.Load();

            // Bind the categoryBindingSource.DataSource to  
            // all the Unchanged, Modified and Added Category objects that  
            // are currently tracked by the DbContext. 
            // Note that we need to call ToBindingList() on the  
            // ObservableCollection<TEntity> returned by 
            // the DbSet.Local property to get the BindingList<T> 
            // in order to facilitate two-way binding in WinForms. 
            this.categoryBindingSource.DataSource =
                _context.Categories.Local.ToBindingList();
        } 

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            // Currently, the Entity Framework doesn’t mark the entities  
            // that are removed from a navigation property (in our example the Products) 
            // as deleted in the context.  
            // The following code uses LINQ to Objects against the Local collection  
            // to find all products and marks any that do not have 
            // a Category reference as deleted.  
            // The ToList call is required because otherwise  
            // the collection will be modified  
            // by the Remove call while it is being enumerated.  
            // In most other situations you can do LINQ to Objects directly  
            // against the Local property without using ToList first. 
            foreach (var product in _context.Links.Local.ToList())
            {
                if (product.Category == null)
                {
                    _context.Links.Remove(product);
                }
            }

            // Save the changes to the database. 
            this._context.SaveChanges();

            // Refresh the controls to show the values          
            // that were generated by the database. 
            this.categoryDataGridView.Refresh();
            this.linksDataGridView.Refresh(); 
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
            if (frm != null)
            {
                frm.toolStripStatusLabel.Text = "";
            }
        }

        private void importToolStripButton1_Click(object sender, EventArgs e)
        {
            int counter = 0;

            if (categoryDataGridView.SelectedCells[0].Value == null)
            {
                MessageBox.Show("Выберите категорию");
            }
            else
            {
                int row_index = categoryDataGridView.SelectedCells[0].RowIndex;
                if (categoryDataGridView.Rows[row_index].Cells[1].Value == null)
                {
                    MessageBox.Show("Выберите категорию");
                }
                else {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    openFileDialog.Filter = "CSV-файлы (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        string FileName = openFileDialog.FileName;
                        string cell_value = categoryDataGridView.Rows[row_index].Cells[0].Value.ToString();
                        int cell_value_int = Convert.ToInt32(cell_value);
                        foreach (var line in File.ReadAllLines(FileName))
                        {
                            var columns = line.Split(';');
                            var link = new Link
                            {
                                CategoryId = cell_value_int,
                                Name = columns[1],
                                Host = columns[2],
                                Port = columns[3],
                                Servicename = columns[4],
                                User = columns[5],
                                Pass = columns[6]
                            };
                            _context.Links.Add(link);
                            _context.SaveChanges();

                            if (frm != null)
                            {
                                counter++;
                                frm.toolStripStatusLabel.Text = "Импортировано: " + counter.ToString();
                            }
                        }
                    }
                }
            }
        }

        private void exportToolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "CSV-файлы (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                ClassHelper.writeCSV(linksDataGridView, FileName);
            }
        }

    }
}

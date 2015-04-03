﻿namespace QMDBO
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inDataGridView = new System.Windows.Forms.DataGridView();
            this.InParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.InValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outDataGridView = new System.Windows.Forms.DataGridView();
            this.OutParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OutSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linksDataGridView = new System.Windows.Forms.DataGridView();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStartAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnServicename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLinkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 0;
            // 
            // inDataGridView
            // 
            this.inDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InParam,
            this.InType,
            this.InValue});
            this.inDataGridView.Location = new System.Drawing.Point(12, 50);
            this.inDataGridView.Name = "inDataGridView";
            this.inDataGridView.Size = new System.Drawing.Size(343, 120);
            this.inDataGridView.TabIndex = 1;
            // 
            // InParam
            // 
            this.InParam.HeaderText = "In";
            this.InParam.Name = "InParam";
            // 
            // InType
            // 
            this.InType.HeaderText = "Type";
            this.InType.Name = "InType";
            this.InType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // InValue
            // 
            this.InValue.HeaderText = "Value";
            this.InValue.Name = "InValue";
            // 
            // outDataGridView
            // 
            this.outDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutParam,
            this.OutType,
            this.OutSize});
            this.outDataGridView.Location = new System.Drawing.Point(12, 191);
            this.outDataGridView.Name = "outDataGridView";
            this.outDataGridView.Size = new System.Drawing.Size(343, 120);
            this.outDataGridView.TabIndex = 2;
            // 
            // OutParam
            // 
            this.OutParam.HeaderText = "Out";
            this.OutParam.Name = "OutParam";
            // 
            // OutType
            // 
            this.OutType.HeaderText = "Type";
            this.OutType.Name = "OutType";
            this.OutType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OutType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OutSize
            // 
            this.OutSize.HeaderText = "Size";
            this.OutSize.Name = "OutSize";
            // 
            // linksDataGridView
            // 
            this.linksDataGridView.AllowUserToAddRows = false;
            this.linksDataGridView.AllowUserToDeleteRows = false;
            this.linksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSelect,
            this.ColumnName,
            this.ColumnHost,
            this.ColumnPort,
            this.ColumnServicename,
            this.ColumnUser,
            this.ColumnPass,
            this.ColumnLinkId});
            this.linksDataGridView.Location = new System.Drawing.Point(369, 50);
            this.linksDataGridView.Name = "linksDataGridView";
            this.linksDataGridView.Size = new System.Drawing.Size(308, 261);
            this.linksDataGridView.TabIndex = 3;
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Location = new System.Drawing.Point(12, 328);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.Size = new System.Drawing.Size(665, 95);
            this.resultsDataGridView.TabIndex = 4;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(521, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Выбранные";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStartAll
            // 
            this.buttonStartAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartAll.Location = new System.Drawing.Point(602, 12);
            this.buttonStartAll.Name = "buttonStartAll";
            this.buttonStartAll.Size = new System.Drawing.Size(75, 23);
            this.buttonStartAll.TabIndex = 6;
            this.buttonStartAll.Text = "Все";
            this.buttonStartAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя процедуры";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.сохранитьToolStripButton.Text = "&Сохранить задачу";
            this.сохранитьToolStripButton.Click += new System.EventHandler(this.сохранитьToolStripButton_Click);
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.HeaderText = "Select";
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.Width = 50;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnHost
            // 
            this.ColumnHost.HeaderText = "Host";
            this.ColumnHost.Name = "ColumnHost";
            // 
            // ColumnPort
            // 
            this.ColumnPort.HeaderText = "Port";
            this.ColumnPort.Name = "ColumnPort";
            // 
            // ColumnServicename
            // 
            this.ColumnServicename.HeaderText = "Servicename";
            this.ColumnServicename.Name = "ColumnServicename";
            // 
            // ColumnUser
            // 
            this.ColumnUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUser.HeaderText = "User";
            this.ColumnUser.MinimumWidth = 100;
            this.ColumnUser.Name = "ColumnUser";
            // 
            // ColumnPass
            // 
            this.ColumnPass.HeaderText = "Pass";
            this.ColumnPass.Name = "ColumnPass";
            this.ColumnPass.Visible = false;
            // 
            // ColumnLinkId
            // 
            this.ColumnLinkId.HeaderText = "LinkId";
            this.ColumnLinkId.Name = "ColumnLinkId";
            this.ColumnLinkId.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartAll);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.resultsDataGridView);
            this.Controls.Add(this.linksDataGridView);
            this.Controls.Add(this.outDataGridView);
            this.Controls.Add(this.inDataGridView);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form5";
            this.Text = "Выполнить процедуру";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView inDataGridView;
        private System.Windows.Forms.DataGridView outDataGridView;
        private System.Windows.Forms.DataGridView linksDataGridView;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStartAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn InParam;
        private System.Windows.Forms.DataGridViewComboBoxColumn InType;
        private System.Windows.Forms.DataGridViewTextBoxColumn InValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutParam;
        private System.Windows.Forms.DataGridViewComboBoxColumn OutType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnServicename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLinkId;
    }
}
namespace Extra_Credit
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.save = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.incidentReportNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocurrenceTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryOfIncidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicalLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Extra_Credit.DatabaseDataSet();
            this.catofin = new System.Windows.Forms.TextBox();
            this.inreno = new System.Windows.Forms.TextBox();
            this.loc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.incidentsTableAdapter1 = new Extra_Credit.DatabaseDataSetTableAdapters.IncidentsTableAdapter();
            this.tableAdapterManager1 = new Extra_Credit.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.label4 = new System.Windows.Forms.Label();
            this.srch = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.summary = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._public_safety_10_7DataSet = new Extra_Credit._public_safety_10_7DataSet();
            this.incidentsTableAdapter = new Extra_Credit._public_safety_10_7DataSetTableAdapters.IncidentsTableAdapter();
            this.tableAdapterManager = new Extra_Credit._public_safety_10_7DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._public_safety_10_7DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(442, 179);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(85, 30);
            this.save.TabIndex = 0;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(549, 179);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(78, 30);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(662, 179);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(81, 30);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incidentReportNoDataGridViewTextBoxColumn,
            this.ocurrenceTimeDataGridViewTextBoxColumn,
            this.categoryOfIncidentDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.physicalLocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incidentsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(373, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // incidentReportNoDataGridViewTextBoxColumn
            // 
            this.incidentReportNoDataGridViewTextBoxColumn.DataPropertyName = "Incident Report No";
            this.incidentReportNoDataGridViewTextBoxColumn.HeaderText = "Incident Report No";
            this.incidentReportNoDataGridViewTextBoxColumn.Name = "incidentReportNoDataGridViewTextBoxColumn";
            // 
            // ocurrenceTimeDataGridViewTextBoxColumn
            // 
            this.ocurrenceTimeDataGridViewTextBoxColumn.DataPropertyName = "Ocurrence Time";
            this.ocurrenceTimeDataGridViewTextBoxColumn.HeaderText = "Ocurrence Time";
            this.ocurrenceTimeDataGridViewTextBoxColumn.Name = "ocurrenceTimeDataGridViewTextBoxColumn";
            // 
            // categoryOfIncidentDataGridViewTextBoxColumn
            // 
            this.categoryOfIncidentDataGridViewTextBoxColumn.DataPropertyName = "Category of Incident";
            this.categoryOfIncidentDataGridViewTextBoxColumn.HeaderText = "Category of Incident";
            this.categoryOfIncidentDataGridViewTextBoxColumn.Name = "categoryOfIncidentDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // physicalLocationDataGridViewTextBoxColumn
            // 
            this.physicalLocationDataGridViewTextBoxColumn.DataPropertyName = "Physical Location";
            this.physicalLocationDataGridViewTextBoxColumn.HeaderText = "Physical Location";
            this.physicalLocationDataGridViewTextBoxColumn.Name = "physicalLocationDataGridViewTextBoxColumn";
            // 
            // incidentsBindingSource1
            // 
            this.incidentsBindingSource1.DataMember = "Incidents";
            this.incidentsBindingSource1.DataSource = this.databaseDataSet;
            this.incidentsBindingSource1.CurrentChanged += new System.EventHandler(this.incidentsBindingSource1_CurrentChanged);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catofin
            // 
            this.catofin.Location = new System.Drawing.Point(643, 66);
            this.catofin.Name = "catofin";
            this.catofin.Size = new System.Drawing.Size(100, 20);
            this.catofin.TabIndex = 4;
            // 
            // inreno
            // 
            this.inreno.Location = new System.Drawing.Point(643, 104);
            this.inreno.Name = "inreno";
            this.inreno.Size = new System.Drawing.Size(100, 20);
            this.inreno.TabIndex = 5;
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(643, 143);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(100, 20);
            this.loc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category of Incident";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Incident Report No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Location";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(932, 25);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // incidentsTableAdapter1
            // 
            this.incidentsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.IncidentsTableAdapter = this.incidentsTableAdapter1;
            this.tableAdapterManager1.InfoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Extra_Credit.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search";
            // 
            // srch
            // 
            this.srch.Location = new System.Drawing.Point(643, 29);
            this.srch.Name = "srch";
            this.srch.Size = new System.Drawing.Size(100, 20);
            this.srch.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.databaseDataSet;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(55, 50);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // summary
            // 
            this.summary.Location = new System.Drawing.Point(763, 179);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(83, 29);
            this.summary.TabIndex = 14;
            this.summary.Text = "Summary";
            this.summary.UseVisualStyleBackColor = true;
            this.summary.Click += new System.EventHandler(this.summary_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(137, 357);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(78, 32);
            this.load.TabIndex = 15;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "Incidents";
            this.incidentsBindingSource.DataSource = this._public_safety_10_7DataSet;
            this.incidentsBindingSource.CurrentChanged += new System.EventHandler(this.incidentsBindingSource_CurrentChanged);
            // 
            // _public_safety_10_7DataSet
            // 
            this._public_safety_10_7DataSet.DataSetName = "_public_safety_10_7DataSet";
            this._public_safety_10_7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IncidentsTableAdapter = this.incidentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Extra_Credit._public_safety_10_7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 401);
            this.Controls.Add(this.load);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.srch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.inreno);
            this.Controls.Add(this.catofin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.save);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._public_safety_10_7DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button delete;
        private _public_safety_10_7DataSet _public_safety_10_7DataSet;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private _public_safety_10_7DataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private _public_safety_10_7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox catofin;
        private System.Windows.Forms.TextBox inreno;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentReportNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocurrenceTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryOfIncidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicalLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource incidentsBindingSource1;
        private DatabaseDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter1;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox srch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button summary;
        private System.Windows.Forms.Button load;
    }
}
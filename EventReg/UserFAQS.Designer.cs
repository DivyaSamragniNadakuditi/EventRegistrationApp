namespace EventReg
{
    partial class UserFAQS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eventRegDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventRegDataSet5 = new EventReg.EventRegDataSet5();
            this.eventRegDataSet6 = new EventReg.EventRegDataSet6();
            this.tblFAQSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_FAQSTableAdapter = new EventReg.EventRegDataSet6TableAdapters.tbl_FAQSTableAdapter();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thingsToBringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prerequisitesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilitiesAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dressCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFAQSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIDDataGridViewTextBoxColumn,
            this.thingsToBringDataGridViewTextBoxColumn,
            this.prerequisitesDataGridViewTextBoxColumn,
            this.facilitiesAvailableDataGridViewTextBoxColumn,
            this.dressCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblFAQSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 196);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eventRegDataSet5BindingSource
            // 
            this.eventRegDataSet5BindingSource.DataSource = this.eventRegDataSet5;
            this.eventRegDataSet5BindingSource.Position = 0;
            // 
            // eventRegDataSet5
            // 
            this.eventRegDataSet5.DataSetName = "EventRegDataSet5";
            this.eventRegDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventRegDataSet6
            // 
            this.eventRegDataSet6.DataSetName = "EventRegDataSet6";
            this.eventRegDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFAQSBindingSource
            // 
            this.tblFAQSBindingSource.DataMember = "tbl_FAQS";
            this.tblFAQSBindingSource.DataSource = this.eventRegDataSet6;
            // 
            // tbl_FAQSTableAdapter
            // 
            this.tbl_FAQSTableAdapter.ClearBeforeFill = true;
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            // 
            // thingsToBringDataGridViewTextBoxColumn
            // 
            this.thingsToBringDataGridViewTextBoxColumn.DataPropertyName = "ThingsToBring";
            this.thingsToBringDataGridViewTextBoxColumn.HeaderText = "ThingsToBring";
            this.thingsToBringDataGridViewTextBoxColumn.Name = "thingsToBringDataGridViewTextBoxColumn";
            // 
            // prerequisitesDataGridViewTextBoxColumn
            // 
            this.prerequisitesDataGridViewTextBoxColumn.DataPropertyName = "Prerequisites";
            this.prerequisitesDataGridViewTextBoxColumn.HeaderText = "Prerequisites";
            this.prerequisitesDataGridViewTextBoxColumn.Name = "prerequisitesDataGridViewTextBoxColumn";
            // 
            // facilitiesAvailableDataGridViewTextBoxColumn
            // 
            this.facilitiesAvailableDataGridViewTextBoxColumn.DataPropertyName = "FacilitiesAvailable";
            this.facilitiesAvailableDataGridViewTextBoxColumn.HeaderText = "FacilitiesAvailable";
            this.facilitiesAvailableDataGridViewTextBoxColumn.Name = "facilitiesAvailableDataGridViewTextBoxColumn";
            // 
            // dressCodeDataGridViewTextBoxColumn
            // 
            this.dressCodeDataGridViewTextBoxColumn.DataPropertyName = "DressCode";
            this.dressCodeDataGridViewTextBoxColumn.HeaderText = "DressCode";
            this.dressCodeDataGridViewTextBoxColumn.Name = "dressCodeDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back TO Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserFAQS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserFAQS";
            this.Text = "UserFAQS";
            this.Load += new System.EventHandler(this.UserFAQS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFAQSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eventRegDataSet5BindingSource;
        private EventRegDataSet5 eventRegDataSet5;
        private EventRegDataSet6 eventRegDataSet6;
        private System.Windows.Forms.BindingSource tblFAQSBindingSource;
        private EventRegDataSet6TableAdapters.tbl_FAQSTableAdapter tbl_FAQSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thingsToBringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prerequisitesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitiesAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dressCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}
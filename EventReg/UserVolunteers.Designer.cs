namespace EventReg
{
    partial class UserVolunteers
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
            this.eventRegDataSet7 = new EventReg.EventRegDataSet7();
            this.tblVolunteersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_VolunteersTableAdapter = new EventReg.EventRegDataSet7TableAdapters.tbl_VolunteersTableAdapter();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportingDateAndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thingsToBringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dressCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVolunteersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIDDataGridViewTextBoxColumn,
            this.reportAtDataGridViewTextBoxColumn,
            this.reportToDataGridViewTextBoxColumn,
            this.reportingDateAndTimeDataGridViewTextBoxColumn,
            this.thingsToBringDataGridViewTextBoxColumn,
            this.dressCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblVolunteersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // eventRegDataSet7
            // 
            this.eventRegDataSet7.DataSetName = "EventRegDataSet7";
            this.eventRegDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVolunteersBindingSource
            // 
            this.tblVolunteersBindingSource.DataMember = "tbl_Volunteers";
            this.tblVolunteersBindingSource.DataSource = this.eventRegDataSet7;
            // 
            // tbl_VolunteersTableAdapter
            // 
            this.tbl_VolunteersTableAdapter.ClearBeforeFill = true;
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            // 
            // reportAtDataGridViewTextBoxColumn
            // 
            this.reportAtDataGridViewTextBoxColumn.DataPropertyName = "ReportAt";
            this.reportAtDataGridViewTextBoxColumn.HeaderText = "ReportAt";
            this.reportAtDataGridViewTextBoxColumn.Name = "reportAtDataGridViewTextBoxColumn";
            // 
            // reportToDataGridViewTextBoxColumn
            // 
            this.reportToDataGridViewTextBoxColumn.DataPropertyName = "ReportTo";
            this.reportToDataGridViewTextBoxColumn.HeaderText = "ReportTo";
            this.reportToDataGridViewTextBoxColumn.Name = "reportToDataGridViewTextBoxColumn";
            // 
            // reportingDateAndTimeDataGridViewTextBoxColumn
            // 
            this.reportingDateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "ReportingDateAndTime";
            this.reportingDateAndTimeDataGridViewTextBoxColumn.HeaderText = "ReportingDateAndTime";
            this.reportingDateAndTimeDataGridViewTextBoxColumn.Name = "reportingDateAndTimeDataGridViewTextBoxColumn";
            // 
            // thingsToBringDataGridViewTextBoxColumn
            // 
            this.thingsToBringDataGridViewTextBoxColumn.DataPropertyName = "ThingsToBring";
            this.thingsToBringDataGridViewTextBoxColumn.HeaderText = "ThingsToBring";
            this.thingsToBringDataGridViewTextBoxColumn.Name = "thingsToBringDataGridViewTextBoxColumn";
            // 
            // dressCodeDataGridViewTextBoxColumn
            // 
            this.dressCodeDataGridViewTextBoxColumn.DataPropertyName = "DressCode";
            this.dressCodeDataGridViewTextBoxColumn.HeaderText = "DressCode";
            this.dressCodeDataGridViewTextBoxColumn.Name = "dressCodeDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back TO Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserVolunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserVolunteers";
            this.Text = "UserVolunteers";
            this.Load += new System.EventHandler(this.UserVolunteers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVolunteersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EventRegDataSet7 eventRegDataSet7;
        private System.Windows.Forms.BindingSource tblVolunteersBindingSource;
        private EventRegDataSet7TableAdapters.tbl_VolunteersTableAdapter tbl_VolunteersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportingDateAndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thingsToBringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dressCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}
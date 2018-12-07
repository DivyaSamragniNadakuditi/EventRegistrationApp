namespace EventReg
{
    partial class ViewMessage
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
            this.eventRegDataSet8 = new EventReg.EventRegDataSet8();
            this.tbl_MessengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MessengerTableAdapter = new EventReg.EventRegDataSet8TableAdapters.tbl_MessengerTableAdapter();
            this.tableAdapterManager = new EventReg.EventRegDataSet8TableAdapters.TableAdapterManager();
            this.eventRegDataSet1 = new EventReg.EventRegDataSet();
            this.dataSet1 = new System.Data.DataSet();
            this.eventRegDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblMessengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventRegDataSet9 = new EventReg.EventRegDataSet9();
            this.tblMessengerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MessengerTableAdapter1 = new EventReg.EventRegDataSet9TableAdapters.tbl_MessengerTableAdapter();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventRegDataSet10 = new EventReg.EventRegDataSet10();
            this.tblMessengerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MessengerTableAdapter2 = new EventReg.EventRegDataSet10TableAdapters.tbl_MessengerTableAdapter();
            this.senderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MessengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMessengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMessengerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMessengerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // eventRegDataSet8
            // 
            this.eventRegDataSet8.DataSetName = "EventRegDataSet8";
            this.eventRegDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MessengerBindingSource
            // 
            this.tbl_MessengerBindingSource.DataMember = "tbl_Messenger";
            this.tbl_MessengerBindingSource.DataSource = this.eventRegDataSet8;
            // 
            // tbl_MessengerTableAdapter
            // 
            this.tbl_MessengerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_MessengerTableAdapter = this.tbl_MessengerTableAdapter;
            this.tableAdapterManager.UpdateOrder = EventReg.EventRegDataSet8TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eventRegDataSet1
            // 
            this.eventRegDataSet1.DataSetName = "EventRegDataSet";
            this.eventRegDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // eventRegDataSet8BindingSource
            // 
            this.eventRegDataSet8BindingSource.DataSource = this.eventRegDataSet8;
            this.eventRegDataSet8BindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back to Admin Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.senderNameDataGridViewTextBoxColumn,
            this.eventIDDataGridViewTextBoxColumn1,
            this.messageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMessengerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(125, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 196);
            this.dataGridView1.TabIndex = 3;
            // 
            // tblMessengerBindingSource
            // 
            this.tblMessengerBindingSource.DataMember = "tbl_Messenger";
            this.tblMessengerBindingSource.DataSource = this.eventRegDataSet8BindingSource;
            // 
            // eventRegDataSet9
            // 
            this.eventRegDataSet9.DataSetName = "EventRegDataSet9";
            this.eventRegDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMessengerBindingSource1
            // 
            this.tblMessengerBindingSource1.DataMember = "tbl_Messenger";
            this.tblMessengerBindingSource1.DataSource = this.eventRegDataSet9;
            // 
            // tbl_MessengerTableAdapter1
            // 
            this.tbl_MessengerTableAdapter1.ClearBeforeFill = true;
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            // 
            // eventRegDataSet10
            // 
            this.eventRegDataSet10.DataSetName = "EventRegDataSet10";
            this.eventRegDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMessengerBindingSource2
            // 
            this.tblMessengerBindingSource2.DataMember = "tbl_Messenger";
            this.tblMessengerBindingSource2.DataSource = this.eventRegDataSet10;
            // 
            // tbl_MessengerTableAdapter2
            // 
            this.tbl_MessengerTableAdapter2.ClearBeforeFill = true;
            // 
            // senderNameDataGridViewTextBoxColumn
            // 
            this.senderNameDataGridViewTextBoxColumn.DataPropertyName = "SenderName";
            this.senderNameDataGridViewTextBoxColumn.HeaderText = "SenderName";
            this.senderNameDataGridViewTextBoxColumn.Name = "senderNameDataGridViewTextBoxColumn";
            // 
            // eventIDDataGridViewTextBoxColumn1
            // 
            this.eventIDDataGridViewTextBoxColumn1.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn1.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn1.Name = "eventIDDataGridViewTextBoxColumn1";
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            // 
            // ViewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewMessage";
            this.Text = "ViewMessage";
            this.Load += new System.EventHandler(this.ViewMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MessengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMessengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMessengerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRegDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMessengerBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EventRegDataSet8 eventRegDataSet8;
        private System.Windows.Forms.BindingSource tbl_MessengerBindingSource;
        private EventRegDataSet8TableAdapters.tbl_MessengerTableAdapter tbl_MessengerTableAdapter;
        private EventRegDataSet8TableAdapters.TableAdapterManager tableAdapterManager;
        private EventRegDataSet eventRegDataSet1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.BindingSource eventRegDataSet8BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblMessengerBindingSource;
        private EventRegDataSet9 eventRegDataSet9;
        private System.Windows.Forms.BindingSource tblMessengerBindingSource1;
        private EventRegDataSet9TableAdapters.tbl_MessengerTableAdapter tbl_MessengerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private EventRegDataSet10 eventRegDataSet10;
        private System.Windows.Forms.BindingSource tblMessengerBindingSource2;
        private EventRegDataSet10TableAdapters.tbl_MessengerTableAdapter tbl_MessengerTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
    }
}
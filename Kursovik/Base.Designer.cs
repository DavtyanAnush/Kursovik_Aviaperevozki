namespace Kursovik
{
    partial class Base
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
            this.database1DataSet = new Kursovik.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписаниеTableAdapter = new Kursovik.Database1DataSetTableAdapters.РасписаниеTableAdapter();
            this.номерРейсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.откудаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кудаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВылетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяВылетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПрилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПрилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоМестDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимотьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерРейсаDataGridViewTextBoxColumn,
            this.откудаDataGridViewTextBoxColumn,
            this.кудаDataGridViewTextBoxColumn,
            this.датаВылетаDataGridViewTextBoxColumn,
            this.времяВылетаDataGridViewTextBoxColumn,
            this.датаПрилетаDataGridViewTextBoxColumn,
            this.времяПрилетаDataGridViewTextBoxColumn,
            this.количествоМестDataGridViewTextBoxColumn,
            this.стоимотьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.расписаниеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(996, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // расписаниеBindingSource
            // 
            this.расписаниеBindingSource.DataMember = "Расписание";
            this.расписаниеBindingSource.DataSource = this.database1DataSet;
            // 
            // расписаниеTableAdapter
            // 
            this.расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // номерРейсаDataGridViewTextBoxColumn
            // 
            this.номерРейсаDataGridViewTextBoxColumn.DataPropertyName = "Номер рейса";
            this.номерРейсаDataGridViewTextBoxColumn.HeaderText = "Номер рейса";
            this.номерРейсаDataGridViewTextBoxColumn.Name = "номерРейсаDataGridViewTextBoxColumn";
            // 
            // откудаDataGridViewTextBoxColumn
            // 
            this.откудаDataGridViewTextBoxColumn.DataPropertyName = "Откуда";
            this.откудаDataGridViewTextBoxColumn.HeaderText = "Откуда";
            this.откудаDataGridViewTextBoxColumn.Name = "откудаDataGridViewTextBoxColumn";
            // 
            // кудаDataGridViewTextBoxColumn
            // 
            this.кудаDataGridViewTextBoxColumn.DataPropertyName = "Куда";
            this.кудаDataGridViewTextBoxColumn.HeaderText = "Куда";
            this.кудаDataGridViewTextBoxColumn.Name = "кудаDataGridViewTextBoxColumn";
            // 
            // датаВылетаDataGridViewTextBoxColumn
            // 
            this.датаВылетаDataGridViewTextBoxColumn.DataPropertyName = "Дата вылета";
            this.датаВылетаDataGridViewTextBoxColumn.HeaderText = "Дата вылета";
            this.датаВылетаDataGridViewTextBoxColumn.Name = "датаВылетаDataGridViewTextBoxColumn";
            // 
            // времяВылетаDataGridViewTextBoxColumn
            // 
            this.времяВылетаDataGridViewTextBoxColumn.DataPropertyName = "Время вылета";
            this.времяВылетаDataGridViewTextBoxColumn.HeaderText = "Время вылета";
            this.времяВылетаDataGridViewTextBoxColumn.Name = "времяВылетаDataGridViewTextBoxColumn";
            // 
            // датаПрилетаDataGridViewTextBoxColumn
            // 
            this.датаПрилетаDataGridViewTextBoxColumn.DataPropertyName = "Дата прилета";
            this.датаПрилетаDataGridViewTextBoxColumn.HeaderText = "Дата прилета";
            this.датаПрилетаDataGridViewTextBoxColumn.Name = "датаПрилетаDataGridViewTextBoxColumn";
            // 
            // времяПрилетаDataGridViewTextBoxColumn
            // 
            this.времяПрилетаDataGridViewTextBoxColumn.DataPropertyName = "Время прилета";
            this.времяПрилетаDataGridViewTextBoxColumn.HeaderText = "Время прилета";
            this.времяПрилетаDataGridViewTextBoxColumn.Name = "времяПрилетаDataGridViewTextBoxColumn";
            // 
            // количествоМестDataGridViewTextBoxColumn
            // 
            this.количествоМестDataGridViewTextBoxColumn.DataPropertyName = "Количество мест";
            this.количествоМестDataGridViewTextBoxColumn.HeaderText = "Количество мест";
            this.количествоМестDataGridViewTextBoxColumn.Name = "количествоМестDataGridViewTextBoxColumn";
            // 
            // стоимотьDataGridViewTextBoxColumn
            // 
            this.стоимотьDataGridViewTextBoxColumn.DataPropertyName = "Стоимоть";
            this.стоимотьDataGridViewTextBoxColumn.HeaderText = "Стоимоть";
            this.стоимотьDataGridViewTextBoxColumn.Name = "стоимотьDataGridViewTextBoxColumn";
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 341);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.Load += new System.EventHandler(this.Base_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource расписаниеBindingSource;
        private Database1DataSetTableAdapters.РасписаниеTableAdapter расписаниеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерРейсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn откудаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кудаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВылетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяВылетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПрилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПрилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоМестDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимотьDataGridViewTextBoxColumn;
    }
}
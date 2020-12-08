namespace Наклейка
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.характеристикиЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наклейкаDataSet = new Наклейка.НаклейкаDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.характеристикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.характеристикиTableAdapter = new Наклейка.НаклейкаDataSetTableAdapters.ХарактеристикиTableAdapter();
            this.характеристикиЗапросTableAdapter = new Наклейка.НаклейкаDataSetTableAdapters.ХарактеристикиЗапросTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.характеристикиЗапросBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.наклейкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.характеристикиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView.DataSource = this.характеристикиЗапросBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 89);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1719, 728);
            this.dataGridView.TabIndex = 29;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Цвет";
            this.dataGridViewTextBoxColumn2.HeaderText = "Цвет";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Размер памяти";
            this.dataGridViewTextBoxColumn3.HeaderText = "Размер памяти";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Модель";
            this.dataGridViewTextBoxColumn4.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Тип номера памяти";
            this.dataGridViewTextBoxColumn5.HeaderText = "Тип номера памяти";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Номер партии";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер партии";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Тип";
            this.dataGridViewTextBoxColumn7.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Тип серийного номера";
            this.dataGridViewTextBoxColumn8.HeaderText = "Тип серийного номера";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Серийный номер";
            this.dataGridViewTextBoxColumn9.HeaderText = "Серийный номер";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "imei";
            this.dataGridViewTextBoxColumn10.HeaderText = "imei";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "imei2";
            this.dataGridViewTextBoxColumn11.HeaderText = "imei2";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Штрих-код";
            this.dataGridViewTextBoxColumn12.HeaderText = "Штрих-код";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Код на наклейке";
            this.dataGridViewTextBoxColumn13.HeaderText = "Код на наклейке";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Фон";
            this.dataGridViewTextBoxColumn14.HeaderText = "Фон";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Цвет текста";
            this.dataGridViewTextBoxColumn15.HeaderText = "Цвет текста";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // характеристикиЗапросBindingSource
            // 
            this.характеристикиЗапросBindingSource.DataMember = "ХарактеристикиЗапрос";
            this.характеристикиЗапросBindingSource.DataSource = this.наклейкаDataSet;
            // 
            // наклейкаDataSet
            // 
            this.наклейкаDataSet.DataSetName = "НаклейкаDataSet";
            this.наклейкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(274, 38);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Дабавить новую наклейку";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(292, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 38);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(78, 53);
            this.textBox3.MaxLength = 30;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1615, 30);
            this.textBox3.TabIndex = 35;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Поиск";
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Image = global::Наклейка.Properties.Resources.кнопка_3;
            this.button11.Location = new System.Drawing.Point(1699, 53);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 30);
            this.button11.TabIndex = 33;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // характеристикиBindingSource
            // 
            this.характеристикиBindingSource.DataMember = "Характеристики";
            this.характеристикиBindingSource.DataSource = this.наклейкаDataSet;
            // 
            // характеристикиTableAdapter
            // 
            this.характеристикиTableAdapter.ClearBeforeFill = true;
            // 
            // характеристикиЗапросTableAdapter
            // 
            this.характеристикиЗапросTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 829);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Наклейка";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.характеристикиЗапросBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.наклейкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.характеристикиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПамятиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button11;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерПамятиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типНомераПамятиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типСерийногоНомераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серийныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imei2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn штрихкодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНаНаклейкеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветТекстаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПартииDataGridViewTextBoxColumn;
        private НаклейкаDataSet наклейкаDataSet;
        private System.Windows.Forms.BindingSource характеристикиBindingSource;
        private НаклейкаDataSetTableAdapters.ХарактеристикиTableAdapter характеристикиTableAdapter;
        private System.Windows.Forms.BindingSource характеристикиЗапросBindingSource;
        private НаклейкаDataSetTableAdapters.ХарактеристикиЗапросTableAdapter характеристикиЗапросTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}


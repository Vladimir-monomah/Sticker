namespace Наклейка
{
    partial class ДобавитьНаклейки
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ДобавитьНаклейки));
            this.ColorText = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.Kod = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.Label();
            this.imei2 = new System.Windows.Forms.Label();
            this.imei1 = new System.Windows.Forms.Label();
            this.SerNumber = new System.Windows.Forms.Label();
            this.TypeSerNumber = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.NumberPart = new System.Windows.Forms.Label();
            this.TypeNumberPart = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.MemorySize = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbMemorySize = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbTypeNumberPart = new System.Windows.Forms.TextBox();
            this.tbNumberPart = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbTypeSerNumber = new System.Windows.Forms.TextBox();
            this.tbSerNumber = new System.Windows.Forms.TextBox();
            this.tbImei1 = new System.Windows.Forms.TextBox();
            this.tbImei2 = new System.Windows.Forms.TextBox();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.tbKod = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbBackColor = new System.Windows.Forms.ComboBox();
            this.cbTextColor = new System.Windows.Forms.ComboBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorText
            // 
            this.ColorText.AutoSize = true;
            this.ColorText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorText.Location = new System.Drawing.Point(13, 71);
            this.ColorText.Name = "ColorText";
            this.ColorText.Size = new System.Drawing.Size(145, 29);
            this.ColorText.TabIndex = 3;
            this.ColorText.Text = "Цвет текста";
            // 
            // background
            // 
            this.background.AutoSize = true;
            this.background.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.background.Location = new System.Drawing.Point(13, 11);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(58, 29);
            this.background.TabIndex = 2;
            this.background.Text = "Фон";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.cbTextColor);
            this.panel.Controls.Add(this.cbBackColor);
            this.panel.Controls.Add(this.ColorText);
            this.panel.Controls.Add(this.background);
            this.panel.Location = new System.Drawing.Point(1149, 21);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(384, 108);
            this.panel.TabIndex = 53;
            // 
            // Kod
            // 
            this.Kod.AutoSize = true;
            this.Kod.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kod.Location = new System.Drawing.Point(20, 700);
            this.Kod.Name = "Kod";
            this.Kod.Size = new System.Drawing.Size(651, 29);
            this.Kod.TabIndex = 39;
            this.Kod.Text = "Код на большой наклейке без чёрточки и А(\"А\") в конце";
            // 
            // barcode
            // 
            this.barcode.AutoSize = true;
            this.barcode.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcode.Location = new System.Drawing.Point(20, 644);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(133, 29);
            this.barcode.TabIndex = 38;
            this.barcode.Text = "Штрих-код";
            // 
            // imei2
            // 
            this.imei2.AutoSize = true;
            this.imei2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imei2.Location = new System.Drawing.Point(20, 593);
            this.imei2.Name = "imei2";
            this.imei2.Size = new System.Drawing.Size(69, 29);
            this.imei2.TabIndex = 37;
            this.imei2.Text = "imei2";
            // 
            // imei1
            // 
            this.imei1.AutoSize = true;
            this.imei1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imei1.Location = new System.Drawing.Point(20, 541);
            this.imei1.Name = "imei1";
            this.imei1.Size = new System.Drawing.Size(56, 29);
            this.imei1.TabIndex = 36;
            this.imei1.Text = "imei";
            // 
            // SerNumber
            // 
            this.SerNumber.AutoSize = true;
            this.SerNumber.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerNumber.Location = new System.Drawing.Point(20, 486);
            this.SerNumber.Name = "SerNumber";
            this.SerNumber.Size = new System.Drawing.Size(202, 29);
            this.SerNumber.TabIndex = 35;
            this.SerNumber.Text = "Серийный номер";
            // 
            // TypeSerNumber
            // 
            this.TypeSerNumber.AutoSize = true;
            this.TypeSerNumber.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeSerNumber.Location = new System.Drawing.Point(20, 433);
            this.TypeSerNumber.Name = "TypeSerNumber";
            this.TypeSerNumber.Size = new System.Drawing.Size(267, 29);
            this.TypeSerNumber.TabIndex = 34;
            this.TypeSerNumber.Text = "Тип серийного номера";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type.Location = new System.Drawing.Point(20, 377);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(55, 29);
            this.Type.TabIndex = 33;
            this.Type.Text = "Тип";
            // 
            // NumberPart
            // 
            this.NumberPart.AutoSize = true;
            this.NumberPart.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberPart.Location = new System.Drawing.Point(20, 317);
            this.NumberPart.Name = "NumberPart";
            this.NumberPart.Size = new System.Drawing.Size(170, 29);
            this.NumberPart.TabIndex = 32;
            this.NumberPart.Text = "Номер партии";
            // 
            // TypeNumberPart
            // 
            this.TypeNumberPart.AutoSize = true;
            this.TypeNumberPart.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeNumberPart.Location = new System.Drawing.Point(20, 258);
            this.TypeNumberPart.Name = "TypeNumberPart";
            this.TypeNumberPart.Size = new System.Drawing.Size(231, 29);
            this.TypeNumberPart.TabIndex = 31;
            this.TypeNumberPart.Text = "Тип номера партии";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model.Location = new System.Drawing.Point(20, 204);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(96, 29);
            this.Model.TabIndex = 30;
            this.Model.Text = "Модель";
            // 
            // MemorySize
            // 
            this.MemorySize.AutoSize = true;
            this.MemorySize.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemorySize.Location = new System.Drawing.Point(20, 146);
            this.MemorySize.Name = "MemorySize";
            this.MemorySize.Size = new System.Drawing.Size(179, 29);
            this.MemorySize.TabIndex = 29;
            this.MemorySize.Text = "Размер памяти";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color.Location = new System.Drawing.Point(20, 88);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(66, 29);
            this.Color.TabIndex = 28;
            this.Color.Text = "Цвет";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(20, 28);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(111, 29);
            this.Phone.TabIndex = 27;
            this.Phone.Text = "Телефон";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(1339, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 55);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.Location = new System.Drawing.Point(738, 35);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(376, 40);
            this.tbPhone.TabIndex = 4;
            // 
            // tbColor
            // 
            this.tbColor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbColor.Location = new System.Drawing.Point(738, 95);
            this.tbColor.Multiline = true;
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(376, 40);
            this.tbColor.TabIndex = 55;
            // 
            // tbMemorySize
            // 
            this.tbMemorySize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMemorySize.Location = new System.Drawing.Point(738, 149);
            this.tbMemorySize.Multiline = true;
            this.tbMemorySize.Name = "tbMemorySize";
            this.tbMemorySize.Size = new System.Drawing.Size(376, 40);
            this.tbMemorySize.TabIndex = 56;
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModel.Location = new System.Drawing.Point(738, 204);
            this.tbModel.Multiline = true;
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(376, 40);
            this.tbModel.TabIndex = 57;
            // 
            // tbTypeNumberPart
            // 
            this.tbTypeNumberPart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTypeNumberPart.Location = new System.Drawing.Point(738, 261);
            this.tbTypeNumberPart.Multiline = true;
            this.tbTypeNumberPart.Name = "tbTypeNumberPart";
            this.tbTypeNumberPart.Size = new System.Drawing.Size(376, 40);
            this.tbTypeNumberPart.TabIndex = 58;
            // 
            // tbNumberPart
            // 
            this.tbNumberPart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumberPart.Location = new System.Drawing.Point(738, 320);
            this.tbNumberPart.Multiline = true;
            this.tbNumberPart.Name = "tbNumberPart";
            this.tbNumberPart.Size = new System.Drawing.Size(376, 40);
            this.tbNumberPart.TabIndex = 59;
            // 
            // tbType
            // 
            this.tbType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbType.Location = new System.Drawing.Point(738, 377);
            this.tbType.Multiline = true;
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(376, 40);
            this.tbType.TabIndex = 60;
            // 
            // tbTypeSerNumber
            // 
            this.tbTypeSerNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTypeSerNumber.Location = new System.Drawing.Point(738, 436);
            this.tbTypeSerNumber.Multiline = true;
            this.tbTypeSerNumber.Name = "tbTypeSerNumber";
            this.tbTypeSerNumber.Size = new System.Drawing.Size(376, 40);
            this.tbTypeSerNumber.TabIndex = 61;
            // 
            // tbSerNumber
            // 
            this.tbSerNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSerNumber.Location = new System.Drawing.Point(738, 489);
            this.tbSerNumber.Multiline = true;
            this.tbSerNumber.Name = "tbSerNumber";
            this.tbSerNumber.Size = new System.Drawing.Size(376, 40);
            this.tbSerNumber.TabIndex = 62;
            // 
            // tbImei1
            // 
            this.tbImei1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbImei1.Location = new System.Drawing.Point(738, 544);
            this.tbImei1.Multiline = true;
            this.tbImei1.Name = "tbImei1";
            this.tbImei1.Size = new System.Drawing.Size(376, 40);
            this.tbImei1.TabIndex = 63;
            this.tbImei1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbImei1_KeyPress);
            // 
            // tbImei2
            // 
            this.tbImei2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbImei2.Location = new System.Drawing.Point(738, 596);
            this.tbImei2.Multiline = true;
            this.tbImei2.Name = "tbImei2";
            this.tbImei2.Size = new System.Drawing.Size(376, 40);
            this.tbImei2.TabIndex = 64;
            this.tbImei2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbImei1_KeyPress);
            // 
            // tbBarcode
            // 
            this.tbBarcode.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBarcode.Location = new System.Drawing.Point(738, 647);
            this.tbBarcode.Multiline = true;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(376, 40);
            this.tbBarcode.TabIndex = 65;
            // 
            // tbKod
            // 
            this.tbKod.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKod.Location = new System.Drawing.Point(738, 703);
            this.tbKod.Multiline = true;
            this.tbKod.Name = "tbKod";
            this.tbKod.Size = new System.Drawing.Size(376, 40);
            this.tbKod.TabIndex = 66;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.btnPrint.Location = new System.Drawing.Point(1149, 146);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(149, 55);
            this.btnPrint.TabIndex = 67;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbBackColor
            // 
            this.cbBackColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBackColor.FormattingEnabled = true;
            this.cbBackColor.Location = new System.Drawing.Point(190, 7);
            this.cbBackColor.Name = "cbBackColor";
            this.cbBackColor.Size = new System.Drawing.Size(191, 23);
            this.cbBackColor.TabIndex = 68;
            this.cbBackColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            // 
            // cbTextColor
            // 
            this.cbTextColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTextColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextColor.FormattingEnabled = true;
            this.cbTextColor.Location = new System.Drawing.Point(190, 71);
            this.cbTextColor.Name = "cbTextColor";
            this.cbTextColor.Size = new System.Drawing.Size(191, 23);
            this.cbTextColor.TabIndex = 68;
            this.cbTextColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            // 
            // ДобавитьНаклейки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 790);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tbKod);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.tbImei2);
            this.Controls.Add(this.tbImei1);
            this.Controls.Add(this.tbSerNumber);
            this.Controls.Add(this.tbTypeSerNumber);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbNumberPart);
            this.Controls.Add(this.tbTypeNumberPart);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMemorySize);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Kod);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.imei2);
            this.Controls.Add(this.imei1);
            this.Controls.Add(this.SerNumber);
            this.Controls.Add(this.TypeSerNumber);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.NumberPart);
            this.Controls.Add(this.TypeNumberPart);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.MemorySize);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Phone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ДобавитьНаклейки";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ДобавитьНаклейки";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ColorText;
        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label Kod;
        private System.Windows.Forms.Label barcode;
        private System.Windows.Forms.Label imei2;
        private System.Windows.Forms.Label imei1;
        private System.Windows.Forms.Label SerNumber;
        private System.Windows.Forms.Label TypeSerNumber;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label NumberPart;
        private System.Windows.Forms.Label TypeNumberPart;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label MemorySize;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbMemorySize;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbTypeNumberPart;
        private System.Windows.Forms.TextBox tbNumberPart;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbTypeSerNumber;
        private System.Windows.Forms.TextBox tbSerNumber;
        private System.Windows.Forms.TextBox tbImei1;
        private System.Windows.Forms.TextBox tbImei2;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.TextBox tbKod;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cbBackColor;
        private System.Windows.Forms.ComboBox cbTextColor;
    }
}
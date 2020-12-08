namespace Ean13Barcode2005
{
	partial class frmEan13
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEan13));
            this.butDraw = new System.Windows.Forms.Button();
            this.butPrint = new System.Windows.Forms.Button();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.txtManufacturerCode = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtChecksumDigit = new System.Windows.Forms.TextBox();
            this.cboScale = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butCreateBitmap = new System.Windows.Forms.Button();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // butDraw
            // 
            this.butDraw.Location = new System.Drawing.Point(182, 50);
            this.butDraw.Name = "butDraw";
            this.butDraw.Size = new System.Drawing.Size(211, 26);
            this.butDraw.TabIndex = 0;
            this.butDraw.Text = "Нарисовать штрих-код";
            this.butDraw.Click += new System.EventHandler(this.butDraw_Click);
            // 
            // butPrint
            // 
            this.butPrint.Location = new System.Drawing.Point(182, 102);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(211, 26);
            this.butPrint.TabIndex = 1;
            this.butPrint.Text = "Печать штрих-кода";
            this.butPrint.Click += new System.EventHandler(this.butPrint_Click);
            // 
            // picBarcode
            // 
            this.picBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBarcode.Location = new System.Drawing.Point(16, 262);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(408, 214);
            this.picBarcode.TabIndex = 2;
            this.picBarcode.TabStop = false;
            // 
            // txtManufacturerCode
            // 
            this.txtManufacturerCode.Location = new System.Drawing.Point(16, 107);
            this.txtManufacturerCode.Name = "txtManufacturerCode";
            this.txtManufacturerCode.Size = new System.Drawing.Size(145, 22);
            this.txtManufacturerCode.TabIndex = 3;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(16, 163);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(145, 22);
            this.txtProductCode.TabIndex = 4;
            // 
            // txtChecksumDigit
            // 
            this.txtChecksumDigit.Location = new System.Drawing.Point(16, 216);
            this.txtChecksumDigit.Name = "txtChecksumDigit";
            this.txtChecksumDigit.Size = new System.Drawing.Size(145, 22);
            this.txtChecksumDigit.TabIndex = 6;
            // 
            // cboScale
            // 
            this.cboScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScale.FormattingEnabled = true;
            this.cboScale.Items.AddRange(new object[] {
            "0,8",
            "0,9",
            "1,0",
            "1,1",
            "1,2",
            "1,3",
            "1,4",
            "1,5",
            "1,6",
            "1,7",
            "1,8",
            "1,9",
            "2,0"});
            this.cboScale.Location = new System.Drawing.Point(182, 212);
            this.cboScale.Name = "cboScale";
            this.cboScale.Size = new System.Drawing.Size(211, 24);
            this.cboScale.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Код страны :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Код производителя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Код продукта :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Контрольная сумма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Масштаб";
            // 
            // butCreateBitmap
            // 
            this.butCreateBitmap.Location = new System.Drawing.Point(182, 151);
            this.butCreateBitmap.Name = "butCreateBitmap";
            this.butCreateBitmap.Size = new System.Drawing.Size(211, 27);
            this.butCreateBitmap.TabIndex = 13;
            this.butCreateBitmap.Text = "Создать растровое изображение";
            this.butCreateBitmap.Click += new System.EventHandler(this.butCreateBitmap_Click);
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(16, 52);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(145, 22);
            this.txtCountryCode.TabIndex = 14;
            // 
            // frmEan13
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(436, 488);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.butCreateBitmap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboScale);
            this.Controls.Add(this.txtChecksumDigit);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtManufacturerCode);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.butPrint);
            this.Controls.Add(this.butDraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEan13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EAN13 Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button butDraw;
		private System.Windows.Forms.Button butPrint;
		private System.Windows.Forms.PictureBox picBarcode;
		private System.Windows.Forms.TextBox txtManufacturerCode;
		private System.Windows.Forms.TextBox txtProductCode;
		private System.Windows.Forms.TextBox txtChecksumDigit;
		private System.Windows.Forms.ComboBox cboScale;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button butCreateBitmap;
		private System.Windows.Forms.TextBox txtCountryCode;
	}
}


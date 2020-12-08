using Microsoft.Office.Interop.Word;
using OnBarcode.Barcode;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Наклейка.НаклейкаDataSetTableAdapters;
using static Наклейка.НаклейкаDataSet;
using Word = Microsoft.Office.Interop.Word;
using ColorStruct = System.Drawing.Color;
using System.Drawing;
using System.Drawing.Text;

namespace Наклейка
{
    public partial class ДобавитьНаклейки : Form
    {

        private ХарактеристикиRow характеристики;

        private НаклейкаDataSet характеристикиDataSet;

        public ДобавитьНаклейки(НаклейкаDataSet наклейкаDataSet)
        {
            this.InitializeComponent();

            this.характеристикиDataSet = наклейкаDataSet;

        }

        public void Loadнаклейка(ХарактеристикиЗапросRow характеристики)
        {
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    cbBackColor.Items.Add(prop.GetValue(null));
                    cbTextColor.Items.Add(prop.GetValue(null));
                }
            }

            this.характеристики = EntityManager.FilterSpecification($"Id={характеристики.Id}").FirstOrDefault();
            this.tbPhone.Text = характеристики.Телефон;
            this.tbColor.Text = характеристики.Цвет;
            this.tbMemorySize.Text = характеристики.Размер_памяти;
            this.tbModel.Text = характеристики.Модель;
            this.tbTypeNumberPart.Text = характеристики.Тип_номера_памяти;
            this.tbNumberPart.Text = характеристики.Номер_партии;
            this.tbType.Text = характеристики.Тип;
            this.tbTypeSerNumber.Text = характеристики.Тип_серийного_номера;
            this.tbSerNumber.Text = характеристики.Серийный_номер;
            this.tbImei1.Text = характеристики.imei;
            this.tbImei2.Text = характеристики.imei2;
            this.tbBarcode.Text = характеристики._Штрих_код;
            this.tbKod.Text = характеристики.Код_на_наклейке;
            if (int.TryParse(характеристики.Фон, out var color))
            {
                for (var i = 0; i < this.cbBackColor.Items.Count; i++)
                {
                    if (((ColorStruct)cbBackColor.Items[i]).ToArgb() == color)
                    {
                        this.cbBackColor.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (int.TryParse(характеристики.Цвет_текста, out color))
            {
                for (var i = 0; i < this.cbTextColor.Items.Count; i++)
                {
                    if (((ColorStruct)cbTextColor.Items[i]).ToArgb() == color)
                    {
                        this.cbTextColor.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private bool CheckTextBoxes()
        {
            if(this.tbPhone.Text==""||this.tbColor.Text==""|| this.tbMemorySize.Text==""
                || this.tbModel.Text==""|| this.tbTypeNumberPart.Text==""||
                this.tbNumberPart.Text==""||this.tbType.Text==""||this.tbTypeSerNumber.Text==""||
                this.tbSerNumber.Text==""||this.tbImei1.Text==""||
                this.tbBarcode.Text==""||this.tbKod.Text=="")
            {
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните необходимые поля!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idSpecifications = this.характеристики?.Id;
            var adapter = new ХарактеристикиTableAdapter();
            adapter.Fill(EntityManager.SpecificationsDataTable);
            var savingSpetifications = EntityManager.SpecificationsDataTable.FindById(idSpecifications ?? -1)
                ?? EntityManager.SpecificationsDataTable.NewХарактеристикиRow();

            savingSpetifications.Телефон = this.tbPhone.Text;
            savingSpetifications.Цвет = this.tbColor.Text;
            savingSpetifications.Размер_памяти = this.tbMemorySize.Text;
            savingSpetifications.Модель = this.tbModel.Text;
            savingSpetifications.Тип_номера_памяти = this.tbTypeNumberPart.Text;
            savingSpetifications.Номер_партии = this.tbNumberPart.Text;
            savingSpetifications.Тип = this.tbType.Text;
            savingSpetifications.Тип_серийного_номера = this.tbTypeSerNumber.Text;
            savingSpetifications.Серийный_номер = this.tbSerNumber.Text;
            savingSpetifications.imei = this.tbImei1.Text;
            savingSpetifications.imei2 = this.tbImei2.Text;
            savingSpetifications._Штрих_код = this.tbBarcode.Text;
            savingSpetifications.Код_на_наклейке = this.tbKod.Text;
            if (this.cbBackColor.SelectedIndex > -1)
            {
                savingSpetifications.Фон = ((ColorStruct)this.cbBackColor.Items[this.cbBackColor.SelectedIndex]).ToArgb().ToString();
            }

            if (this.cbTextColor.SelectedIndex > -1)
            {
                savingSpetifications.Цвет_текста = ((ColorStruct)this.cbTextColor.Items[this.cbTextColor.SelectedIndex]).ToArgb().ToString();
            }

            try
            {
                if (this.характеристики == null)
                {
                    EntityManager.SpecificationsDataTable.AddХарактеристикиRow(savingSpetifications);
                    EntityManager.Updatespetifications();
                }
                else
                {
                    var характеристикиTableAdapter = new ХарактеристикиTableAdapter();
                    характеристикиTableAdapter.Adapter.Update(savingSpetifications.Table);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при добавлении/изменении! \r\n" + ex.ToString(),
                    "Ошибка",
                    MessageBoxButtons.OK);
                return;
            }

            var message = this.характеристики == null
                ? "Добавление прошло успешно!"
                : "Изменение завершено успешно!";

            MessageBox.Show(message, "Информация", MessageBoxButtons.OK);
            this.Close();
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void tbImei1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var templateFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Наклейка.docx");
            if (!File.Exists(templateFile))
            {
                throw new Exception("Не найден файл " + templateFile);
            }

            var oWord = new Word.Application();
            _Document oDoc = null;
            var newTamplateFile = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                $"Наклейка/Характеристики_по_наклейкам_{DateTime.Now:dd.MM.yyyy_HH.mm.ss}_{this.tbPhone.Text}.docx");
            try
            {
                oDoc = oWord.Documents.Add(templateFile);
                this.SetTemplate(oDoc);

                oDoc.SaveAs2(FileName: newTamplateFile);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                oDoc?.Close();
                oWord.Quit();
            }

            MessageBox.Show("Сохранение прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start(newTamplateFile);
        }

        private void SetTemplate(_Document oDoc)
        {
            var tableInfo = oDoc.Tables[1];
            if (cbTextColor.SelectedIndex > -1)
            {
                var color = (ColorStruct)cbTextColor.Items[cbTextColor.SelectedIndex];
                tableInfo.Range.Font.TextColor.RGB =
                    color.R + 0x100 * color.G + 0x10000 * color.B;
            }
                
            if (cbBackColor.SelectedIndex > -1)
            {
                var color = (ColorStruct)cbBackColor.Items[cbBackColor.SelectedIndex];
                tableInfo.Range.Shading.BackgroundPatternColor =
                    (WdColor)(color.R + 0x100 * color.G + 0x10000 * color.B);
            }

            tableInfo.Cell(1,0).Range.Text = this.tbMemorySize.Text;
            tableInfo.Cell(2, 2).Range.Text = this.tbPhone.Text;
            tableInfo.Cell(4, 2).Range.Text = this.tbPhone.Text;
            tableInfo.Cell(6, 2).Range.Text = this.tbPhone.Text;
            tableInfo.Cell(8, 2).Range.Text = this.tbKod.Text;
            tableInfo.Cell(10, 1).Range.Text = this.tbNumberPart.Text;
            tableInfo.Cell(10, 2).Range.Text = this.tbPhone.Text;
            tableInfo.Cell(10, 3).Range.Text = this.tbColor.Text;
            tableInfo.Cell(10, 4).Range.Text = this.tbMemorySize.Text;
            tableInfo.Cell(12, 2).Range.Text = this.tbModel.Text;
            tableInfo.Cell(13, 1).Range.Text = this.tbTypeNumberPart.Text;
            tableInfo.Cell(13, 3).Range.Text = this.tbNumberPart.Text;
            tableInfo.Cell(15, 1).Range.Text = this.tbTypeSerNumber.Text;
            tableInfo.Cell(15, 3).Range.Text = this.tbSerNumber.Text;
            tableInfo.Cell(17, 2).Range.Text = this.tbImei1.Text;
            tableInfo.Cell(17, 3).Range.Text = this.tbImei2.Text;

            // Формируем и вставляем в ворд изображение штрих-кода Code 128
           CreateBarCode(this.tbKod.Text, tableInfo.Cell(9, 2).Range, BarcodeType.CODE128);
           CreateBarCode(this.tbNumberPart.Text, tableInfo.Cell(14, 1).Range, BarcodeType.CODE128);
           CreateBarCode(this.tbNumberPart.Text, tableInfo.Cell(16, 0).Range, BarcodeType.CODE128);
           CreateBarCode(this.tbImei1.Text, tableInfo.Cell(18, 1).Range, BarcodeType.CODE128);            

            // Формируем и вставляем в ворд изображение штрих-кода продукта
            if (tbBarcode.Text.Length < 11)
            {
                throw new Exception("Количество чисел в штрих-коде меньше нормы!");
            }

            CreateBarCode(this.tbBarcode.Text, tableInfo.Cell(16, 2).Range, BarcodeType.EAN13);
        }

        /// <summary>
        /// Создаёт изображение со штрих-кодом
        /// </summary>
        /// <param name="countryCode">Код страны</param>
        /// <param name="manufacturerCode">Код предприятия</param>
        /// <param name="productCode">Код продукта</param>
        /// <returns></returns>
        private void CreateBarCode(string barCodeText, Range barCodePlace, BarcodeType type)
        {
            var barCodeEngine = new Linear
            {
                Type = type,
                Data = barCodeText
            };
            switch (type)
            {
                case BarcodeType.EAN13:
                    barCodeEngine.ShowText = true;
                    break;

                case BarcodeType.CODE128:
                    barCodeEngine.BarcodeWidth = 10;
                    barCodeEngine.ShowText = false;
                    break;
            }

            using (var barCode = barCodeEngine.drawBarcode())
            {
                Clipboard.SetImage(barCode);
                barCodePlace.Paste();
            }
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            const int MarginWidth = 4;
            const int MarginHeight = 4;

            // Clear the background appropriately.
            e.DrawBackground();

            // Draw the color sample.
            int hgt = e.Bounds.Height - 2 * MarginHeight;
            var rect = new System.Drawing.Rectangle(
                e.Bounds.X + MarginWidth,
                e.Bounds.Y + MarginHeight,
                hgt, hgt);
            ComboBox cbo = sender as ComboBox;
            var color = (ColorStruct)cbo.Items[e.Index];
            using (var brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            // Outline the sample in black.
            e.Graphics.DrawRectangle(Pens.Black, rect);

            // Draw the color's name to the right.
            using (var font = new System.Drawing.Font(cbo.Font.FontFamily,
                cbo.Font.Size * 0.75f, FontStyle.Bold))
            {
                using (var sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    int x = hgt + 2 * MarginWidth;
                    int y = e.Bounds.Y + e.Bounds.Height / 2;
                    e.Graphics.TextRenderingHint =
                        TextRenderingHint.AntiAliasGridFit;
                    e.Graphics.DrawString(color.Name, font,
                        Brushes.Black, x, y, sf);
                }
            }

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }
    }
}

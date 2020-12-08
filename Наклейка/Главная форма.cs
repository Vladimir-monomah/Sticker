using DGV2Printer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Наклейка.Properties;
using static Наклейка.НаклейкаDataSet;

namespace Наклейка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            this.Form1_Load();
        }

        private void Form1_Load()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "наклейкаDataSet.ХарактеристикиЗапрос". При необходимости она может быть перемещена или удалена.
            this.характеристикиЗапросTableAdapter.Fill(this.наклейкаDataSet.ХарактеристикиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "наклейкаDataSet.Характеристики". При необходимости она может быть перемещена или удалена.
            this.характеристикиTableAdapter.Fill(this.наклейкаDataSet.Характеристики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "наклейкаDataSet.ХарактеристикиЗапрос". При необходимости она может быть перемещена или удалена.
            this.характеристикиЗапросTableAdapter.Fill(this.наклейкаDataSet.ХарактеристикиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "наклейкаDataSet.Характеристики". При необходимости она может быть перемещена или удалена.
            this.характеристикиTableAdapter.Fill(this.наклейкаDataSet.Характеристики);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ДобавитьНаклейки открыть = new ДобавитьНаклейки(this.наклейкаDataSet);
            открыть.ShowDialog();

            this.характеристикиЗапросTableAdapter.Fill(this.наклейкаDataSet.ХарактеристикиЗапрос);
        }

        /// <summary>
        /// Кнопка удалить строку характеристик из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var idSpecifications = ((ХарактеристикиЗапросRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row)?.Id;
            if (!idSpecifications.HasValue)
            {
                return;
            }

            var deleteSpecificationsQuestionResult = MessageBox.Show("Вы действительно хотите удалить?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteSpecificationsQuestionResult != DialogResult.Yes)
            {
                return;
            }

            using (var connection = new OleDbConnection(Settings.Default.НаклейкаConnectionString))
            {
                connection.Open();
                using (var sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = $"DELETE FROM Характеристики WHERE Id = {idSpecifications.Value}";
                    sqlCommand.ExecuteNonQuery();
                }
            }

            this.Form1_Load();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                ДобавитьНаклейки открыть = new ДобавитьНаклейки(this.наклейкаDataSet);
                открыть.Loadнаклейка(
                    (ХарактеристикиЗапросRow)((DataRowView)this.dataGridView.CurrentRow.DataBoundItem).Row);
                открыть.ShowDialog();

            this.характеристикиЗапросTableAdapter.Fill(this.наклейкаDataSet.ХарактеристикиЗапрос);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.характеристикиЗапросBindingSource.Filter = this.BuildWorkerCardFilter();
        }

        private string BuildWorkerCardFilter()
        {
            var filterExpressionList = new List<string>();
            var fieldFilter = this.textBox3.Text;
            if (!string.IsNullOrEmpty(fieldFilter))
            {
                filterExpressionList.Add(string.Format("(([Телефон] Like '%{0}%'))", fieldFilter));
            }

            return string.Join(" AND ", filterExpressionList);
        }

        /// <summary>
        /// Печать формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDataGridView pr = new PrintDataGridView(this.dataGridView);
            pr.isRightToLeft = true;
            pr.Print();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ХарактеристикиDataTable har = this.наклейкаDataSet.Характеристики;
            this.характеристикиTableAdapter.Fill(har);
            this.ImportDataExcel(
            this.GetImportingExcelFileName(),
            har,
            new[] { "Телефон" });
            this.характеристикиTableAdapter.Update(har);
            this.Form1_Load();
        }

        private void ImportDataExcel(string sourceFileName, DataTable destinationTable, IEnumerable<string> keyFields)
        {
            if (!File.Exists(sourceFileName))
            {
                MessageBox.Show("Введите имя существующего файла");
                return;
            }

            // Загрузка данных в память из файла
            var connectionString = string.Format(
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\";",
                    sourceFileName);
            using (var connection = new OleDbConnection(connectionString))
            using (var adapter = new OleDbDataAdapter("SELECT * FROM [Лист1$]", connection))
            using (var excelTable = new DataTable())
            {
                adapter.Fill(excelTable);

                // Определяем общий набор полей для excel-файла и целевой таблицы
                var commonColumns = new List<string>();
                foreach (DataColumn destinationColumn in destinationTable.Columns)
                {
                    if (excelTable.Columns.Contains(destinationColumn.ColumnName))
                    {
                        commonColumns.Add(destinationColumn.ColumnName);
                    }
                }

                var nonExistingFields = keyFields
                    .Where(column => !commonColumns.Exists(keyField => keyField == column))
                    .ToList();
                if (nonExistingFields.Count > 0)
                {
                    var missingKeyFieldsMessage = "Поля \"" + string.Join("\", \"", nonExistingFields) + " \" " +
                        "обязательно должны присутствовать в импортируемых данных!";
                    throw new Exception(missingKeyFieldsMessage);
                }

                // Создание кэша строк по ключевым полям для быстрого поиска
                var destinationRowsCache = new Dictionary<string, DataRow>();
                var buildKeyFunc = new Func<DataRow, string>(
                    importingRow => string.Join("→", keyFields.Select(keyField => importingRow[keyField].ToString())));
                foreach (DataRow row in destinationTable.Rows)
                {
                    var key = buildKeyFunc(row);
                    destinationRowsCache[key] = row;
                }

                // Добавление новых строк или обновление существующих по ключевым полям
                foreach (DataRow importingRow in excelTable.Rows)
                {
                    var key = buildKeyFunc(importingRow);
                    var isNeedAdd = false;
                    if (!destinationRowsCache.TryGetValue(key, out var destinationRow))
                    {
                        destinationRow = destinationTable.NewRow();
                        isNeedAdd = true;
                    }

                    foreach (var columnName in commonColumns)
                    {
                        this.HandleColumnWithValue(columnName, destinationRow, importingRow);
                    }

                    if (isNeedAdd)
                    {
                        destinationTable.Rows.Add(destinationRow);
                    }
                }
            }
        }

        /// <summary>
        /// Обрабатывает определённым образом некоторые поля
        /// Например, если поле в целевой таблице является ссылочным,
        /// то пытаемся найти запись с импортируемым значением в другой таблице.
        /// Если не находим - создаём
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="destinationRow"></param>
        /// <param name="importingRow"></param>
        private void HandleColumnWithValue(string columnName, DataRow destinationRow, DataRow importingRow)
        {
            switch (columnName)
            {
                case "Телефон":
                    var phoneValue = importingRow[columnName].ToString();
                    var phoneTable = EntityManager.FilterSpecification($"Телефон='{phoneValue}'");
                    if (phoneTable.Rows.Count == 0 && !string.IsNullOrEmpty(phoneValue))
                    {
                        var newphone = phoneTable.NewХарактеристикиRow();
                        newphone.Телефон = importingRow[columnName].ToString();
                        EntityManager.Updatespetifications();
                    }

                    destinationRow[columnName] = importingRow[columnName];
                    break;

                case "Цвет":
                    var colorValue = importingRow[columnName].ToString();
                    var colorTable = EntityManager.FilterSpecification($"[Цвет]='{colorValue}'");
                    if (colorTable.Rows.Count == 0 && !string.IsNullOrEmpty(colorValue))
                    {
                        var newColor = colorTable.NewХарактеристикиRow();
                        newColor.Цвет = importingRow[columnName].ToString();
                        colorTable.AddХарактеристикиRow(newColor);
                        EntityManager.Updatespetifications();
                    }

                    destinationRow[columnName] = importingRow[columnName];
                    break;

                default:
                    destinationRow[columnName] = importingRow[columnName];
                    break;
            }
        }

        /// <summary>
        /// Отображает диалоговое окно для выбора файла
        /// </summary>
        /// <returns>Полный путь выбранного файла, либо Null, если файл не выбран</returns>
        private string GetImportingExcelFileName()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Файл Excel|*.XLSX;*.XLS";
            return dialog.ShowDialog() == DialogResult.OK
                ? dialog.FileName
                : null;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            for (int i = 0; i < this.dataGridView.Columns.Count; i++)
            {
                var cellCaption = this.dataGridView.Columns[i].HeaderText;
                var bracketIndex = cellCaption.IndexOf('(') - 1;
                if (bracketIndex > -1)
                {
                    cellCaption = cellCaption.Substring(0, bracketIndex);
                }

                cellCaption = cellCaption.Replace("Размер памяти", "Размер памяти");

                ExcelWorkSheet.Cells[1, i + 1] = cellCaption;
            }
            for (int i = 0; i < this.dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < this.dataGridView.Columns.Count; j++)
                {
                    ExcelWorkSheet.Cells[i + 2, j + 1] = this.dataGridView.Rows[i].Cells[j].Value.ToString();
                    if (!this.dataGridView.Columns[j].Visible)
                    {
                        ExcelWorkSheet.Cells[i + 2, j + 1].ColumnWidth = 0;
                    }
                }
            }

            for (int j = 0; j < this.dataGridView.Columns.Count; j++)
            {
                if (this.dataGridView.Columns[j].Visible)
                {
                    ExcelWorkSheet.Columns[j + 1].AutoFit();
                }
            }
            ExcelApp.Visible = true;
        }
    }
}

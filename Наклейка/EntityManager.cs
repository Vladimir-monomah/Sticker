using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Наклейка.НаклейкаDataSetTableAdapters;
using static Наклейка.НаклейкаDataSet;
using System.Data.OleDb;
using System.Data;

namespace Наклейка
{
    public class EntityManager
    {
        static НаклейкаDataSet НаклейкаDataSet = new НаклейкаDataSet();

        private static ХарактеристикиTableAdapter ХарактеристикиTableAdapter = new ХарактеристикиTableAdapter();

        public static ХарактеристикиDataTable SpecificationsDataTable
        {
            get
            {
                return НаклейкаDataSet.Характеристики;
            }
        }

        public static void Updatespetifications()
        {
            ХарактеристикиTableAdapter.Update(SpecificationsDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу характеристик по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ХарактеристикиDataTable FilterSpecification(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterSpetificationsCommand = new OleDbCommand()
            {
                Connection = ХарактеристикиTableAdapter.Connection,
                CommandText = "SELECT Id, Телефон, Цвет, [Размер памяти], Модель, [Тип номера памяти], " +
                "[Номер партии], Тип, [Тип серийного номера], [Серийный номер], imei," +
                "[Штрих-код], [Код на наклейке], Фон, [Цвет текста]" +
                $" FROM Характеристики {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(ХарактеристикиTableAdapter.Adapter, filterSpetificationsCommand, SpecificationsDataTable);

            return SpecificationsDataTable;
        }

        /// <summary>
        /// Создает строку для фильтрации: всевозможные комбинации по сравнению предоставленных полей с текстом поиска
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public static string GetFilterStringByFields(string[] fields, string searchText)
        {
            var findValues = string.IsNullOrEmpty(searchText)
                ? new string[] { }
                : searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filterStrings = new List<string>();
            foreach (var findingField in fields)
            {
                foreach (var findingValue in findValues)
                {
                    filterStrings.Add($"{findingField} LIKE '%{findingValue}%'");
                }
            }

            return string.Join(" OR ", filterStrings);
        }

        /// <summary>
        /// Заполняет таблицу по фильтрующей команде выбора строк
        /// </summary>
        /// <param name="adapter"></param>
        /// <param name="selectCommand"></param>
        /// <param name="table"></param>
        private static void FillFilteredTable(OleDbDataAdapter adapter, OleDbCommand selectCommand, DataTable table)
        {
            var oldSelectComand = adapter.SelectCommand;
            adapter.SelectCommand = selectCommand;

            table.Clear();

            adapter.Fill(table);
            adapter.SelectCommand = oldSelectComand;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBroser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        // method to add item to history database
        public static void AddItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.Title, item.URL, item.Date);
        }

        // method to retrieve items from history database
        public static List<HistoryItem> GetItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.Title = row.Title;
                item.URL = row.URL;
                item.Date = row.Date;
                results.Add(item);
            }
            return results;
        }

        // method to remove all items from history database
        public static void ClearItems()
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                row.Delete();
            }
            adapter.Update(rows);
        }

        // method to delete a singular item from history database
        public static void DeleteItem(int Id, string Title, string URL, DateTime Date)
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                if (row.Date.ToString().Equals(Date.ToString()))
                {
                    row.Delete();
                }
            }
            adapter.Update(rows);
        }
    }
}

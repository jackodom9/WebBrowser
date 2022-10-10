using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBroser.Data.BookmarksDataSetTableAdapters;
using WebBroser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        // method to add item to bookmarks database
        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }

        // method to retrieve all items from bookmarks database
        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.Title = row.Title;
                item.URL = row.URL;
                results.Add(item);
            }
            return results;
        }

        // method to remove item from database
        public static void DeleteItem(int Id, string Title, string URL)
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                if (row.URL.Equals(URL))
                {
                    row.Delete();
                }
            }
            adapter.Update(rows);
        }
    }
}

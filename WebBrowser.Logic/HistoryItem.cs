using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    // class to store items in History database
    public class HistoryItem
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; } 
    }
}

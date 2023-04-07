using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.CW._00010959.Models
{
    public class ListItemsViewModel
    {
        public int ListId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        // public List<Item> Items { get; set; }
        public List<Item> Items { get; set; }
        public List<List> Lists { get; set; }
    }
}

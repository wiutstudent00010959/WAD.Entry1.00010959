using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.CW._00010959.Models
{
    public class Item
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter title")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Range(1, 100, ErrorMessage = "Enter number between 1 and 100")]
        public int Quantity { get; set; }

        public bool IsPurchased { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "When to buy:")]
        public DateTime PurchaseDate { get; set; }


        //naigatin prperties fr cnnectin with List class
        public int ListId { get; set; }
        public List List { get; set; }
    }
}

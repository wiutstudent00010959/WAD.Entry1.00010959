using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.CW._00010959.Models
{
    public class List
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}

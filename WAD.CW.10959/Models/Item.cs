﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.CW._10959.Models
{
    public class Item
    {
        //basic prperties
        public int Id { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public bool IsDone { get; set; }
    }
}

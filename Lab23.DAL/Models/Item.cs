using System;
using System.Collections.Generic;
using System.Text;

namespace Lab23.DAL.Models
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Desc { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab23.DAL.Models
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}

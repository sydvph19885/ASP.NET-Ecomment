using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EComment.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string ProductName { get; set; }
        [DisplayFormat(DataFormatString ="{0:C}")]
        public decimal price { get; set; }
        [DisplayFormat(DataFormatString ="{0: dd-MM-yyyy}")]
        public DateTime BirthDay { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
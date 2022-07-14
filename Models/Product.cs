using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace FourthTemplateforfoodordering.Models
{
    public class Product
    {
        [Key]
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Detail { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        
        public string CategoryName { get; set; }
        public virtual ICollection<OrderDetails> OrderDetail { get; set; }
    }
}

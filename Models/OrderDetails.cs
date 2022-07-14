using System.ComponentModel.DataAnnotations;

namespace FourthTemplateforfoodordering.Models
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        public virtual OrderMaster OrderID { get; set; }

        public virtual Product FoodID { get; set; }
        public int Qnt { get; set; }
        public float Price { get; set; }
        public float TotalPrice { get; set; }
    }
}

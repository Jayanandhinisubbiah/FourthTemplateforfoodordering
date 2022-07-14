using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FourthTemplateforfoodordering.Models
{
    public class OrderMaster
    {
        [Key]
        public int OrderId { get; set; }
        public virtual User UserID { get; set; }
        public float TotalPrice { get; set; }
        public string Type { get; set; }
        public string BankName { get; set; }
        public string CardNo { get; set; }
        public int CCV { get; set; }
        public float Amount { get; set; }
        public virtual ICollection<OrderDetails> OrderDetail { get; set; }
    }
}

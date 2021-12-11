using System.ComponentModel.DataAnnotations;

namespace AcceptOrderDelivery.Models
{
    public class Order
    {
        [Required]
        [MaxLength(50)]
        public string SenderCity { get; set; }
        [Required]
        [MaxLength(50)]
        public string SenderAddress { get; set; }
        [Required]
        [MaxLength(50)]
        public string RecipientCity { get; set; }
        [Required]
        [MaxLength(50)]
        public string RecipientAddress { get; set; }
        [Required]
        [Range(0, 999)]
        public decimal Weight { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int Id { get; set; }

        public string OrderNumber { get; set; } = "";
    }
}

using System.ComponentModel.DataAnnotations.Schema;

using EF.Support.Entities.Interfaces;

namespace Domain.Entities
{
    public class OrderItemEntity : IEntity
    {
        public OrderEntity Order { get; set; }
        public Guid OrderId { get; set; }
        public ProductEntity Product { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
    }
}

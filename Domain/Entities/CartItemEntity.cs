using EF.Support.Entities.Interfaces;

namespace Domain.Entities
{
    public class CartItemEntity  :  IEntity
    {
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; } = 1;
    }
}



using System.ComponentModel.DataAnnotations;

using EF.Support.Entities.Interfaces;

namespace Domain.Entities
{
    public class ProductEntity : IEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal OriginalPrice { get; set; }
        [DataType(DataType.Currency)]
        public decimal NewPrice { get; set; }

        public string? Description { get; set; }

        public int Quantity { get; set; } = 1;

        public string? Image { get; set; }
        [DataType(DataType.Date)]
        public DateTime UploadedDate { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; }

        //Relationship : many to one
        public virtual CategoryEntity? Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}

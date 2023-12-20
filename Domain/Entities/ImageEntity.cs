using EF.Support.Entities.Interfaces;

namespace Domain.Entities
{
    public class ImageEntity:IEntity 
    {
        public Guid Id { get; set; }
        public string Data { get; set; } = string.Empty;
    }
}

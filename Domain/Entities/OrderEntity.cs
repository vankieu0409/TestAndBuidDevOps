﻿using System.ComponentModel.DataAnnotations.Schema;

using EF.Support.Entities.Interfaces;

namespace Domain.Entities
{
    public class OrderEntity : IEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        public List<OrderItemEntity> OrderItems { get; set; }
    }
}

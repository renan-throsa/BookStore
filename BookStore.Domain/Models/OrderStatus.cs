using System;
using BookApp.Domain.Enums;

namespace BookApp.Domain.Models
{
    public class OrderStatus : BaseEntity
    {
        public int OrderStatusId { get; set; }
        public OrderStatusEnum Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Order Order { get; set; }
    }
}

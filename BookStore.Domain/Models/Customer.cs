using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Domain.Models
{
    public class Customer : BaseEntity
    {
        public int CustomerId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(101)]
        public string FullName { get; private set; }

        //public string Email { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}

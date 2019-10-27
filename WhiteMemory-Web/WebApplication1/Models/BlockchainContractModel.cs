using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class BlockchainContract
    {
        public Guid Id { get; set; }
        [MaxLength(256)]
        public string FirstName { get; set; }
        [MaxLength(256)]
        public string MiddleName { get; set; }
        [MaxLength(256)]
        public string LastName { get; set; }
        [MaxLength(256)]
        public string GPS { get; set; }
        [MaxLength(64)]
        public string Birthday { get; set; }
        [MaxLength(64)]
        public string DateOfDath { get; set; }
        [MaxLength(256)]
        public string Country { get; set; }
        [MaxLength(256)]
        public string City { get; set; }
    }
}

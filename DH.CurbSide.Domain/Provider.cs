using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DH.CurbSide.Domain
{
    [Table("Provider")]
    public class Provider
    {
        public long ProviderId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Speciality { get; set; }
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string EmailAddress { get; set; }

        
        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTimeOffset? ModifiedDate { get; set; }
        
    }
}

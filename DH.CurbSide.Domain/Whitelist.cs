using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DH.CurbSide.Domain
{
    [Table("WhitelistEmail1")]
    public class Whitelist
    {
        [Key]
        public long WhitelistEmailId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset DeactivatedDate { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueNet.Models
{
    public class UserCreateRequest
    {
        [MaxLength(250)]
        [Required]
        public string UserName { get; set; }

        [MaxLength(250)]
        //[Required]
        public string NormalizedUserName { get; set; }

        [MaxLength(250)]
        //[Required]
        public string Email { get; set; }

        [MaxLength(250)]
        //[Required]
        public string NormalizedEmail { get; set; }

        [MaxLength(250)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(250)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(250)]
        //[Required]
        public string SecurityStamp { get; set; }

        [MaxLength(250)]
        [Required]
        public string Password { get; set; }

        
        [Required]
        public Guid RoleId { get; set; }
    }
}

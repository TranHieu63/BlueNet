using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueNet.Models
{
    public class UserDto
    {
        public Guid Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Email { get; set; }

        [MaxLength(250)]
        [Required]
        public string UserName { get; set; }

        [MaxLength(250)]
        [Required]
        public string FullName { get; set; }

        [MaxLength(250)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(250)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(250)]
        public string RoleName { get; set; }

        public Guid RoleId { get; set; }
    }
}

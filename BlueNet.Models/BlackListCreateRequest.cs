using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueNet.Models
{
    public class BlackListCreateRequest
    {
        public Guid BlackListId { get; set; } = Guid.NewGuid();

        [MaxLength(250)]
        [Required]
        public string Url { get; set; }
        public Guid? UserId { get; set; } 
        public DateTime CreatedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueNet.Models
{
    public class BlackListUpdateRequest
    {
        [MaxLength(250)]
        [Required]
        public string Url { get; set; }
        public Guid? UserId { get; set; }
     
    }
}

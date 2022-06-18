using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueNet.Models
{
    public class BlackListDto
    {
        public Guid BlackListId { get; set; }

        [MaxLength(250)]
        [Required]
        public string Url { get; set; }
        public Guid? UserId { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

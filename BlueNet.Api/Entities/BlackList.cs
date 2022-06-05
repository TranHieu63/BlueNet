using BlueNet.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueNet.Api.Entities
{
    public class BlackList
    {
        [Key]
        public Guid BlackListId { get; set; }

        [MaxLength(250)]
        [Required]
        public string Url { get; set; }
        public Guid? UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public DateTime CreatedDate { get; set; }

        internal object Select(Func<object, BlackListDto> value)
        {
            throw new NotImplementedException();
        }
    }
}

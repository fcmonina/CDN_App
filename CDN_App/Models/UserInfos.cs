using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDN_App.Models
{
    [Table("Users")]
    public class UserInfos
    {
        [Key]
        public int ID { get; set; }
        public int userid { get; set; }
        public string? username { get; set; }
        public string? mail { get; set; }
        public string? phonenumber { get; set; }
        public string? skillsets { get; set; }
        public string? hobby { get; set; }
    }
}

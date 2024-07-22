using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QueteASP.NetMVC.Models
{
    public class Article
    {
        public int Id { get; set; }
        [DisplayName("Title")]
        [Required(ErrorMessage = "An Article's Title is required")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "An Article's Content is required")]
        [DisplayName("Content")]
        public string Content { get; set; } = string.Empty;
    }
}

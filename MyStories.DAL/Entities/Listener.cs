using System.ComponentModel.DataAnnotations;

namespace MyStories.DAL.Entities
{
    public class Listener
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
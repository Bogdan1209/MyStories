using System.Collections.Generic;

namespace MyStories.DAL.Entities
{
    public class User
    {
        public User()
        {
            Stories = new List<Story>();
            Listeners = new List<Listener>();
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<Story> Stories { get; set; } 
        public IEnumerable<Listener> Listeners { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyStories.DAL.Entities
{
    public class Listener
    {
        public Listener()
        {
            StoryListeners = new List<StoryListener>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<StoryListener> StoryListeners { get; set; }
    }
}
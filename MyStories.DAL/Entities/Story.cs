using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyStories.DAL.Entities
{
    public class Story 
    {
        public Story()
        {
            StoryListeners = new List<StoryListener>();
        }
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public IEnumerable<StoryListener> StoryListeners { get; set; }
    }
}
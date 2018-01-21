using System.Collections.Generic;
using MyStories.DAL.Entities;

namespace MyStories.BL.DTO
{
    public class StoryDto
    {
        public StoryDto()
        {
            StoryListeners = new List<StoryListenerDto>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public IEnumerable<StoryListenerDto> StoryListeners { get; set; }
    }
}
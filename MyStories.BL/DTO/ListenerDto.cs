using System.Collections.Generic;
using MyStories.DAL.Entities;

namespace MyStories.BL.DTO
{
    public class ListenerDto
    {
        public ListenerDto()
        {
            StoryListeners = new List<StoryListenerDto>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<StoryListenerDto> StoryListeners { get; set; }
    }
}
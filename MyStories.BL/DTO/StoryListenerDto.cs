using MyStories.DAL.Entities;

namespace MyStories.BL.DTO
{
    public class StoryListenerDto
    {
        public int ListenerId { get; set; }
        public int StoryId { get; set; }
        public StoryDto Story { get; set; }
        public ListenerDto Listener { get; set; }
    }
}
namespace MyStories.DAL.Entities
{
    public class StoryListener
    {
        public int ListenerId { get; set; }
        public int StoryId { get; set; }
        public Story Story { get; set; }
        public Listener Listener { get; set; }
    }
}
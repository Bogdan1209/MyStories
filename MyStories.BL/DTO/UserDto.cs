using System.Collections.Generic;
using MyStories.DAL.Entities;

namespace MyStories.BL.DTO
{
    public class UserDto
    {
        public UserDto()
        {
            Stories = new List<StoryDto>();
            Listeners = new List<ListenerDto>();
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<StoryDto> Stories { get; set; } 
        public IEnumerable<ListenerDto> Listeners { get; set; }
    }
}
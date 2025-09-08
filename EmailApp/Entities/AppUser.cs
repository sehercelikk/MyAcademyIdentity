using Microsoft.AspNetCore.Identity;

namespace EmailApp.Entities;

public class AppUser : IdentityUser<int>
{
    public string FristName { get; set; }
    public string LastName { get; set; }
    public string? ImgUrl { get; set; }
    public ICollection<Message> SentMessage { get; set; }
    public ICollection<Message> RecievedMessage { get; set; }

}

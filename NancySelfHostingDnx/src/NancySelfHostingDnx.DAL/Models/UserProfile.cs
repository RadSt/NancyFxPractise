using Microsoft.AspNet.Identity;

namespace NancySelfHostingDnx.DAL.Models
{
    public class UserProfile : IUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
    }
}
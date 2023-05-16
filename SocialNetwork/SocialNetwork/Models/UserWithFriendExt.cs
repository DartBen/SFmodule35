using SocialNetwork.Models.Users;

namespace SocialNetwork.Models
{
    public class UserWithFriendExt : User
    {
        public bool IsFriendWithCurrent { get; set; }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data.Context;
using SocialNetwork.Models.Users;

namespace SocialNetwork.Data.Repository
{
    public class FriendsRepository : Repository<Friend>
    {
        public FriendsRepository(ApplicationDbContext db): base(db)
        {

        }


        public async Task AddFriend(User target, User Friend)
        {
            var friends = Set.AsEnumerable().FirstOrDefault(x => x.UserId == target.Id && x.CurrentFriendId == Friend.Id);

            if (friends == null)
            {
                var item = new Friend()
                {
                    UserId = target.Id,
                    User = target,
                    CurrentFriend = Friend,
                    CurrentFriendId = Friend.Id,
                };

                await Create(item);
            }
        }

        public async Task<List<User>> GetFriendsByUser(User target)
        {
            var friends =  Set
                .Include(x => x.CurrentFriend)
                .AsQueryable()
                .Where(x => x.User!=null && x.User.Id == target.Id)
                .Select(x => x.CurrentFriend)
                .ToList();

            return friends;
        }


        public async Task DeleteFriend(User target, User Friend)
        {
            var friends = Set.AsQueryable().FirstOrDefault(x => x.UserId == target.Id && x.CurrentFriendId == Friend.Id);

            if (friends != null)
            {
                await Delete(friends);
            }
        }

    }
}

using System.Collections.Generic;
using System.Linq;
using MovecoinApp.Models;

namespace MovecoinApp.Services
{
    public class UserService
    {
        private List<User> users;

        public UserService()
        {
            users = new List<User>();
        }

        public void CreateUser(string name, string email)
        {
            var user = new User
            {
                Id = GenerateUserId(),
                Name = name,
                Email = email,
                Challenges = new List<Challenge>()
            };
            users.Add(user);
        }

        public User GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public void JoinChallenge(int userId, Challenge challenge)
        {
            var user = GetUserById(userId);
            if (user != null && !user.Challenges.Contains(challenge))
            {
                user.Challenges.Add(challenge);
            }
        }

        private int GenerateUserId()
        {
            return users.Count > 0 ? users.Max(u => u.Id) + 1 : 1;
        }
    }
}
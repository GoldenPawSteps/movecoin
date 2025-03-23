using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovecoinApp.Models;

namespace MovecoinApp.Services
{
    public class AuthService
    {
        private readonly Dictionary<string, string> users = new Dictionary<string, string>();
        
        // Add a default user for demo purposes
        private readonly User currentUser = new User("DemoUser");

        public User GetCurrentUser()
        {
            return currentUser;
        }

        public async Task<bool> RegisterAsync(string username, string password)
        {
            if (users.ContainsKey(username))
            {
                return false; // User already exists
            }

            users[username] = password;
            return true; // Registration successful
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            return users.TryGetValue(username, out var storedPassword) && storedPassword == password;
        }

        public async Task<bool> LogoutAsync(string username)
        {
            // Implement logout logic if needed
            return true; // Logout successful
        }
    }
}
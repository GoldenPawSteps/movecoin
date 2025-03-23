using System;

namespace MovecoinApp.Models
{
    public class User
    {
        public string Username { get; set; }
        public int MovecoinsBalance { get; set; }
        public MovecoinWallet MovecoinWallet { get; private set; }
        
        public User(string username)
        {
            Username = username;
            MovecoinsBalance = 0;
            MovecoinWallet = new MovecoinWallet(username);
        }

        public void AddMovecoins(int amount)
        {
            MovecoinsBalance += amount;
        }

        public void DeductMovecoins(int amount)
        {
            if (MovecoinsBalance >= amount)
            {
                MovecoinsBalance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient movecoins.");
            }
        }
    }
}
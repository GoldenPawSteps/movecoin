using System;
using System.Collections.Generic;

namespace MovecoinApp.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Challenge> Challenges { get; set; }

        public User()
        {
            Challenges = new List<Challenge>();
        }

        public void JoinChallenge(Challenge challenge)
        {
            if (!Challenges.Contains(challenge))
            {
                Challenges.Add(challenge);
            }
        }

        public void CreateChallenge(Challenge challenge)
        {
            // Logic to create a challenge and add it to the user's challenges
            Challenges.Add(challenge);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using MovecoinApp.Models;

namespace MovecoinApp.Services
{
    public class ChallengeService
    {
        private List<Challenge> challenges = new List<Challenge>();

        public void CreateChallenge(Challenge challenge)
        {
            challenges.Add(challenge);
        }

        public List<Challenge> GetChallenges()
        {
            return challenges;
        }

        public Challenge GetChallengeById(Guid id)
        {
            return challenges.FirstOrDefault(c => c.Id == id);
        }

        public void UpdateChallenge(Challenge updatedChallenge)
        {
            var challenge = GetChallengeById(updatedChallenge.Id);
            if (challenge != null)
            {
                challenge.Name = updatedChallenge.Name;
                challenge.Metrics = updatedChallenge.Metrics;
                challenge.Scores = updatedChallenge.Scores;
                challenge.Stakes = updatedChallenge.Stakes;
                challenge.Rewards = updatedChallenge.Rewards;
                challenge.Duration = updatedChallenge.Duration;
            }
        }

        public void DeleteChallenge(Guid id)
        {
            var challenge = GetChallengeById(id);
            if (challenge != null)
            {
                challenges.Remove(challenge);
            }
        }
    }
}
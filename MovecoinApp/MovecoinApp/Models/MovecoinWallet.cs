using System;
using System.Collections.Generic;

namespace MovecoinApp.Models
{
    public class MovecoinWallet
    {
        public string UserId { get; set; }
        public decimal Balance { get; private set; }
        public List<Transaction> Transactions { get; private set; }

        public MovecoinWallet(string userId)
        {
            UserId = userId;
            Balance = 0;
            Transactions = new List<Transaction>();
        }

        public void AddMovecoins(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive.");
            Balance += amount;
            Transactions.Add(new Transaction { Amount = amount, Date = DateTime.Now, Type = TransactionType.Credit });
        }

        public void DeductMovecoins(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive.");
            if (amount > Balance) throw new InvalidOperationException("Insufficient balance.");
            Balance -= amount;
            Transactions.Add(new Transaction { Amount = amount, Date = DateTime.Now, Type = TransactionType.Debit });
        }
    }

    public class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
    }

    public enum TransactionType
    {
        Credit,
        Debit
    }
}
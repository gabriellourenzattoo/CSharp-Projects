using System;

namespace Library
{
    class Account
    {   
        public int AccountNumbers = 1000;

        private const int MAX_BOOKS_ALLOWED = 3; // Limite padrão de livros

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int BorrowedBooksCount { get; private set; }
        public decimal PenaltyFee { get; private set; }
        public bool IsBlocked { get; private set; }

        public Account(string Name, string Email)
        {
            this.Name = Name;
            this.Email = Email;
            this.BorrowedBooksCount = BorrowedBooksCount;
            this.PenaltyFee = PenaltyFee;
            this.IsBlocked = IsBlocked;

            this.Id = AccountNumbers.ToString();
            AccountNumbers++;
        }
    }
}

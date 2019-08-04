using Cryptography;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockWithMultipleTransactions.Interfaces
{
    public interface ITransaction
    {
        string ClaimNumber { get; set; }
        decimal SettlementAmount { get; set; }
        DateTime SettlementDate { get; set; }
        string CarRegistration { get; set; }
        int Mileage { get; set; }
        ClaimType ClaimType { get; set; }

        string CalculateTransactionHash();
    }
}

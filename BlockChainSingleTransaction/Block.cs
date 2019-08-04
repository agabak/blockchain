using BlockChainSingleTransaction.Interfaces;
using Cryptography;
using System;
using System.Text;


namespace BlockChainSingleTransaction
{
    public class Block : IBlock
    {
        //Provided by user
        public string ClaimNumber { get; set; }
        public decimal SettlementAmount { get; set; }
        public DateTime SettlementDate { get; set; }
        public string CarRegistration { get; set; }
        public int Mileage { get; set; }
        public ClaimType ClaimType { get; set; }

        // Set as part of block creation
        public int BlockNumber { get; }

        public DateTime CreatedDate { get; set; }

        public string BlockHash { get; set; }

        public string PreviousBlockHash { get; set; }
        public IBlock NextBlock { get; set; }

        public Block(int blockNumber, string claimNumber, decimal settlementAmount, DateTime settlementDate, 
                     string carRegistration, int mileage, ClaimType claimType, IBlock parent)
        {
            BlockNumber = blockNumber;
            SettlementAmount = settlementAmount;
            SettlementDate = settlementDate;
            CarRegistration = carRegistration;
            Mileage = mileage;
            ClaimType = claimType;
            CreatedDate = DateTime.Now;
            SetBlockHash(parent);
        }


        public string CalculateBlockHash(string previousBlockHash)
        {
            string txnHash = ClaimNumber + SettlementAmount + SettlementDate + CarRegistration + Mileage + ClaimType;
            string blockheader = BlockNumber + CreatedDate.ToString() + previousBlockHash;
            string combined = txnHash + blockheader;

            return Convert.ToBase64String(HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(combined)));
        }

        public void SetBlockHash(IBlock parent)
        {
            if(parent != null)
            {
                PreviousBlockHash = parent.BlockHash;
                parent.NextBlock = this;
            }
            else
            {
                PreviousBlockHash = null;
            }

            BlockHash = CalculateBlockHash(PreviousBlockHash);
        }

        public bool IsValidChain(string prevBlockHash, bool verbose)
        {
            bool isValid = true;

            string newBlockHash = CalculateBlockHash(prevBlockHash);

            if(newBlockHash != BlockHash)
            {
                isValid = false;
            }
            else
            {
                isValid |= PreviousBlockHash == prevBlockHash;
            }

            PrintVerficationMessage(verbose, isValid);

            if(NextBlock != null)
            {
                return NextBlock.IsValidChain(newBlockHash, isValid);
            }
            return isValid;
        }

        private void PrintVerficationMessage(bool verbose, bool isValide)
        {
            if(verbose)
            {
                if(!isValide)
                {
                    Console.WriteLine("Block Number " + BlockNumber + ": FAILED VERIFICATION ");
                }
                else
                {
                    Console.WriteLine("Block Number " + BlockNumber + ": PASS VERIFICATION ");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BlockWithMultipleTransactions.Interfaces
{
    public interface IBlockChain
    {
        void AcceptBlock(IBlock block);
        int NextBlockNumber { get; }
        void VerifyChain();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Core.BaseClass
{
    public abstract class BlockBase
    {
       public   int  BlockNumber { get; }
       public abstract  DateTime CreatedDate { get; set; }
       public abstract string BlockHash { get; }
       public abstract  string PreviousBlockHash { get; set; }

        public BlockBase(int blockNumber)
        {
            BlockNumber = blockNumber;
        }

      public abstract string CalculateBlockHash(string previousBlockHash);
      public abstract void SetBlockHash(BlockBase parent);
      public  BlockBase NextBlock { get; set; }

     public virtual bool IsValidChain(string prevBlockHash, bool verbose)
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

         PrintVerificationMessage(verbose, isValid);

         if (NextBlock != null)
         {
              return NextBlock.IsValidChain(newBlockHash, isValid);
         }
            return isValid;
     }

        private void PrintVerificationMessage(bool verbose, bool isValid)
        {
            if (verbose)
            {
                if (!isValid)
                {
                    Console.WriteLine("Block Number " + BlockNumber + " : FAILED VERIFICATION");
                }
                else
                {
                    Console.WriteLine("Block Number " + BlockNumber + " : PASS VERIFICATION");
                }
            }
        }

    }
}

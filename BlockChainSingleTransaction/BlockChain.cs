﻿using BlockChainSingleTransaction.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockChainSingleTransaction
{
    public class BlockChain : IBlockChain
    {
        public IBlock CurrentBlock { get; private set; }
        public IBlock HeadBlock { get;  private set; }
        public List<IBlock> Blocks { get; set; }

        public BlockChain()
        {
            Blocks = new List<IBlock>();
        }
        public void AcceptBlock(IBlock block)
        {
            if(HeadBlock == null)
            {
                HeadBlock = block;
                HeadBlock.PreviousBlockHash = null;
            }
            CurrentBlock = block;
            Blocks.Add(block);
        }

        public void VerifyChain()
        {
           if(HeadBlock == null)
            {
                throw new InvalidOperationException();
            }

            bool isValid = HeadBlock.IsValidChain(null, true);
            if(isValid)
            {
                Console.WriteLine("Blockchain integrity intack.");
            }
            else
            {
                Console.WriteLine("Blockchain integrity NOT intack. ");
            }
        }
    }
}

using BlockWithTransactionPool;
using BlockWithTransactionPool.Interfaces;
using Cryptography;
using System;

namespace Insurance.Blochain
{
    class Program
    {
        static readonly TransactionPool txnPool = new TransactionPool();
        ///
        /// Single block with a single transaction, in an immutable chain.
        /// Standard SHA-256 Hashing
        ///
        static void Main(string[] args)
        {
            //BlockChain chain = new BlockChain();
            //IBlock block1 = new Block(0, "ABC123", 1000.00m, DateTime.Now, "QWE123", 10000, ClaimType.TotalLoss, null);
            //IBlock block2 = new Block(1, "VBG345", 2000.00m, DateTime.Now, "JKH567", 20000, ClaimType.TotalLoss, block1);
            //IBlock block3 = new Block(2, "XCF234", 3000.00m, DateTime.Now, "DH23ED", 30000, ClaimType.TotalLoss, block2);
            //IBlock block4 = new Block(3, "CBHD45", 4000.00m, DateTime.Now, "DH34K6", 40000, ClaimType.TotalLoss, block3);
            //IBlock block5 = new Block(4, "AJD345", 5000.00m, DateTime.Now, "28FNF4", 50000, ClaimType.TotalLoss, block4);
            //IBlock block6 = new Block(5, "QAX367", 6000.00m, DateTime.Now, "FJK676", 60000, ClaimType.TotalLoss, block5);
            //IBlock block7 = new Block(6, "CGO444", 7000.00m, DateTime.Now, "LKU234", 70000, ClaimType.TotalLoss, block6);
            //IBlock block8 = new Block(7, "PLO254", 8000.00m, DateTime.Now, "VBN456", 80000, ClaimType.TotalLoss, block7);

            //chain.AcceptBlock(block1);
            //chain.AcceptBlock(block2);
            //chain.AcceptBlock(block3);
            //chain.AcceptBlock(block4);
            //chain.AcceptBlock(block5);
            //chain.AcceptBlock(block6);
            //chain.AcceptBlock(block7);
            //chain.AcceptBlock(block8);

            //chain.VerifyChain();

            //Console.WriteLine("");
            //Console.WriteLine("");

            //block4.CreatedDate = new DateTime(2017, 09, 20);

            //chain.VerifyChain();

            //Console.WriteLine();

            // ITransaction txn1 = new Transaction("ABC123", 1000.00m, DateTime.Now, "QWE123", 10000, ClaimType.TotalLoss);
            // ITransaction txn2 = new Transaction("VBG345", 2000.00m, DateTime.Now, "JKH567", 20000, ClaimType.TotalLoss);
            // ITransaction txn3 = new Transaction("XCF234", 3000.00m, DateTime.Now, "DH23ED", 30000, ClaimType.TotalLoss);
            // ITransaction txn4 = new Transaction("CBHD45", 4000.00m, DateTime.Now, "DH34K6", 40000, ClaimType.TotalLoss);
            // ITransaction txn5 = new Transaction("AJD345", 5000.00m, DateTime.Now, "28FNF4", 50000, ClaimType.TotalLoss);
            // ITransaction txn6 = new Transaction("QAX367", 6000.00m, DateTime.Now, "FJK676", 60000, ClaimType.TotalLoss);
            // ITransaction txn7 = new Transaction("CGO444", 7000.00m, DateTime.Now, "LKU234", 70000, ClaimType.TotalLoss);
            // ITransaction txn8 = new Transaction("PLO254", 8000.00m, DateTime.Now, "VBN456", 80000, ClaimType.TotalLoss);
            // ITransaction txn9 = new Transaction("ABC123", 1000.00m, DateTime.Now, "QWE123", 10000, ClaimType.TotalLoss);
            // ITransaction txn10 = new Transaction("VBG345", 2000.00m, DateTime.Now, "JKH567", 20000, ClaimType.TotalLoss);
            // ITransaction txn11 = new Transaction("XCF234", 3000.00m, DateTime.Now, "DH23ED", 30000, ClaimType.TotalLoss);
            // ITransaction txn12 = new Transaction("CBHD45", 4000.00m, DateTime.Now, "DH34K6", 40000, ClaimType.TotalLoss);
            // ITransaction txn13 = new Transaction("AJD345", 5000.00m, DateTime.Now, "28FNF4", 50000, ClaimType.TotalLoss);
            // ITransaction txn14 = new Transaction("QAX367", 6000.00m, DateTime.Now, "FJK676", 60000, ClaimType.TotalLoss);
            // ITransaction txn15 = new Transaction("CGO444", 7000.00m, DateTime.Now, "LKU234", 70000, ClaimType.TotalLoss);
            // ITransaction txn16 = new Transaction("PLO254", 8000.00m, DateTime.Now, "VBN456", 80000, ClaimType.TotalLoss);


            // IBlock block1 = new BlockWithMultipleTransactions.Block(0);
            // IBlock block2 = new BlockWithMultipleTransactions.Block(1);
            // IBlock block3 = new BlockWithMultipleTransactions.Block(2);
            // IBlock block4 = new BlockWithMultipleTransactions.Block(3);

            // block1.AddTransaction(txn1);
            // block1.AddTransaction(txn2);
            // block1.AddTransaction(txn3);
            // block1.AddTransaction(txn4);

            // block2.AddTransaction(txn5);
            // block2.AddTransaction(txn6);
            // block2.AddTransaction(txn7);
            // block2.AddTransaction(txn8);

            // block3.AddTransaction(txn9);
            // block3.AddTransaction(txn10);
            // block3.AddTransaction(txn11);
            // block3.AddTransaction(txn12);

            // block4.AddTransaction(txn13);
            // block4.AddTransaction(txn14);
            // block4.AddTransaction(txn15);
            // block4.AddTransaction(txn16);

            // block1.SetBlockHash(null);
            // block2.SetBlockHash(block1);
            // block3.SetBlockHash(block2);
            // block4.SetBlockHash(block3);


            //BlockWithMultipleTransactions.BlockChain chain = new BlockWithMultipleTransactions.BlockChain();
            // chain.AcceptBlock(block1);
            // chain.AcceptBlock(block2);
            // chain.AcceptBlock(block3);
            // chain.AcceptBlock(block4);


            // chain.VerifyChain();

            // Console.WriteLine("");
            // Console.WriteLine("");

            // txn5.ClaimNumber = "weqwewe";
            // chain.VerifyChain();

            // Console.WriteLine();

            ITransaction txn5 = SetupTransactions();
            IKeyStore keyStore = new KeyStore(Hmac.GenerateKey());

            IBlock block1 = new Block(0, keyStore);
            IBlock block2 = new Block(1, keyStore);
            IBlock block3 = new Block(2, keyStore);
            IBlock block4 = new Block(3, keyStore);

            AddTransactionsToBlocksAndCalculateHashes(block1, block2, block3, block4);

            BlockChain chain = new BlockChain();
            chain.AcceptBlock(block1);
            chain.AcceptBlock(block2);
            chain.AcceptBlock(block3);
            chain.AcceptBlock(block4);

            chain.VerifyChain();

            Console.WriteLine("");
            Console.WriteLine("");

            txn5.ClaimNumber = "weqwewe";
            chain.VerifyChain();

            Console.WriteLine();
        }

        private static void AddTransactionsToBlocksAndCalculateHashes(IBlock block1, IBlock block2, IBlock block3, IBlock block4)
        {
            block1.AddTransaction(txnPool.GetTransaction());
            block1.AddTransaction(txnPool.GetTransaction());
            block1.AddTransaction(txnPool.GetTransaction());
            block1.AddTransaction(txnPool.GetTransaction());

            block2.AddTransaction(txnPool.GetTransaction());
            block2.AddTransaction(txnPool.GetTransaction());
            block2.AddTransaction(txnPool.GetTransaction());
            block2.AddTransaction(txnPool.GetTransaction());

            block3.AddTransaction(txnPool.GetTransaction());
            block3.AddTransaction(txnPool.GetTransaction());
            block3.AddTransaction(txnPool.GetTransaction());
            block3.AddTransaction(txnPool.GetTransaction());

            block4.AddTransaction(txnPool.GetTransaction());
            block4.AddTransaction(txnPool.GetTransaction());
            block4.AddTransaction(txnPool.GetTransaction());
            block4.AddTransaction(txnPool.GetTransaction());

            block1.SetBlockHash(null);
            block2.SetBlockHash(block1);
            block3.SetBlockHash(block2);
            block4.SetBlockHash(block3);
        }

        private static ITransaction SetupTransactions()
        {
            ITransaction txn1 = new Transaction("ABC123", 1000.00m, DateTime.Now, "QWE123", 10000, ClaimType.TotalLoss);
            ITransaction txn2 = new Transaction("VBG345", 2000.00m, DateTime.Now, "JKH567", 20000, ClaimType.TotalLoss);
            ITransaction txn3 = new Transaction("XCF234", 3000.00m, DateTime.Now, "DH23ED", 30000, ClaimType.TotalLoss);
            ITransaction txn4 = new Transaction("CBHD45", 4000.00m, DateTime.Now, "DH34K6", 40000, ClaimType.TotalLoss);
            ITransaction txn5 = new Transaction("AJD345", 5000.00m, DateTime.Now, "28FNF4", 50000, ClaimType.TotalLoss);
            ITransaction txn6 = new Transaction("QAX367", 6000.00m, DateTime.Now, "FJK676", 60000, ClaimType.TotalLoss);
            ITransaction txn7 = new Transaction("CGO444", 7000.00m, DateTime.Now, "LKU234", 70000, ClaimType.TotalLoss);
            ITransaction txn8 = new Transaction("PLO254", 8000.00m, DateTime.Now, "VBN456", 80000, ClaimType.TotalLoss);
            ITransaction txn9 = new Transaction("ABC123", 1000.00m, DateTime.Now, "QWE123", 10000, ClaimType.TotalLoss);
            ITransaction txn10 = new Transaction("VBG345", 2000.00m, DateTime.Now, "JKH567", 20000, ClaimType.TotalLoss);
            ITransaction txn11 = new Transaction("XCF234", 3000.00m, DateTime.Now, "DH23ED", 30000, ClaimType.TotalLoss);
            ITransaction txn12 = new Transaction("CBHD45", 4000.00m, DateTime.Now, "DH34K6", 40000, ClaimType.TotalLoss);
            ITransaction txn13 = new Transaction("AJD345", 5000.00m, DateTime.Now, "28FNF4", 50000, ClaimType.TotalLoss);
            ITransaction txn14 = new Transaction("QAX367", 6000.00m, DateTime.Now, "FJK676", 60000, ClaimType.TotalLoss);
            ITransaction txn15 = new Transaction("CGO444", 7000.00m, DateTime.Now, "LKU234", 70000, ClaimType.TotalLoss);
            ITransaction txn16 = new Transaction("PLO254", 8000.00m, DateTime.Now, "VBN456", 80000, ClaimType.TotalLoss);

            txnPool.AddTransaction(txn1);
            txnPool.AddTransaction(txn2);
            txnPool.AddTransaction(txn3);
            txnPool.AddTransaction(txn4);
            txnPool.AddTransaction(txn5);
            txnPool.AddTransaction(txn6);
            txnPool.AddTransaction(txn7);
            txnPool.AddTransaction(txn8);
            txnPool.AddTransaction(txn9);
            txnPool.AddTransaction(txn10);
            txnPool.AddTransaction(txn11);
            txnPool.AddTransaction(txn12);
            txnPool.AddTransaction(txn13);
            txnPool.AddTransaction(txn14);
            txnPool.AddTransaction(txn15);
            txnPool.AddTransaction(txn16);

            return txn5;
        }
    }
}

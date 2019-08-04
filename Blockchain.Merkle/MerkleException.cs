using System;
using System.Collections.Generic;
using System.Text;

namespace Blockchain.Merkle
{
    public class MerkleException : ApplicationException
    {
        public MerkleException(string msg) : base(msg)
        {
        }
    }
}

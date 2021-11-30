using System.Collections.Generic;

namespace Seminar
{
    public abstract class SymbolChain
    {
        protected List<char> chain = new();

        public abstract int GetChainLength { get; }

        public abstract void AddToChain(char newSimb);
    }
}
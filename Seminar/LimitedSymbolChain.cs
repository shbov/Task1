using System;

namespace Seminar
{
    public class LimitedSymbolChain : SymbolChain
    {
        protected int StartCode;
        protected int EndCode;

        public LimitedSymbolChain(int startCode, int endCode)
        {
            StartCode = startCode;
            EndCode = endCode;
        }

        public override int GetChainLength => chain.Count;

        public override void AddToChain(char newSimb)
        {
            if (newSimb > EndCode || newSimb < StartCode)
                throw new ArgumentOutOfRangeException();

            chain.Add(newSimb);
        }

        public override string ToString() => new(chain.ToArray());
    }
}
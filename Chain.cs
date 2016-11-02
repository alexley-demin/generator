using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regular_languages_generator
{
    class Chain
    {
        public string chain;
        public Chain genericChain;
        public Chain(string chain, Chain generic = null)
        {
            this.chain = chain;
            genericChain = generic;
        }
        public string ShowChain()
        {
            Chain ch = this;
            string res = "";
            while (ch != null)
            {
                res = ch.chain + (ch != this ? " -> " : "") + res;
                ch = ch.genericChain;
            }
            return res;
        }
        public bool CheckRepeatedGenerates()
        {
            bool result = false;
            Chain ch = this.genericChain;
            while (ch != null)
            {
                if (ch.chain == this.chain)
                    return true;
                ch = ch.genericChain;
            }
            return result;
        }
    }
}

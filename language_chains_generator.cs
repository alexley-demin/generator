﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace regular_languages_generator
{
    class Language_chains_generator
    {
        public HashSet<Chain> resultChain = new HashSet<Chain>(new BoxEqualityComparer());
        public List<Chain> listCh = new List<Chain>();
        List<NonTerminal> nonTerminals;

        public Language_chains_generator(Chain chain, List<NonTerminal> list)
        {
            Debug.Assert(list != null, "NonTerminal List cant be equal to null");
            listCh.Add(chain);
            nonTerminals = list;
        }

        public void GenerateChains(int minLength, int maxLength, string typeGrammar)
        {
            NonTerminal n = null;
            bool flag = false;
            if(typeGrammar == "left")
             {
                 for (int k = 0; k < listCh.Count; k++)
                 {
                     if (listCh[k].chain.Length > maxLength + 1) continue;
                     flag = false;
                     n = null;
                     if (listCh[k].chain.Length == 0)
                    {
                        if (minLength == 0) resultChain.Add(listCh[k]);
                        continue;
                    }
                     if (flag == false)
                     {
                         n = nonTerminals.Find(nt => nt.Symbol == listCh[k].chain[0]);
                         if (n != null)
                         {
                             flag = true;
                             for (int j = 0; j < n.replacements.Count; j++)
                             {
                                 string a = listCh[k].chain.Remove(0, 1);
                                 string b = a.Insert(0, n.replacements[j]);
                                 b = b.Replace(" ", string.Empty);
                                 Chain ch1 = new Chain(b.Trim(), listCh[k]);
                                 if (!ch1.CheckRepeatedGenerates())
                                     listCh.Add(ch1);
                             }
                         }
                     }
                     listCh[k].chain = listCh[k].chain.Replace(" ", string.Empty);
                     if (flag == false && listCh[k].chain.Length <= maxLength && listCh[k].chain.Length >= minLength) resultChain.Add(listCh[k]);
                 }
             }
             else
             {
                 for (int k = 0; k < listCh.Count; k++)
                 {
                     if (listCh[k].chain.Length > maxLength + 1) continue;
                     flag = false;
                     n = null;
                     if (listCh[k].chain.Length == 0)
                        {
                            if(minLength==0)resultChain.Add(listCh[k]);
                            continue;
                        }
                    if (flag == false)
                    {
                        int num = listCh[k].chain.Length - 1;
                        n = nonTerminals.Find(nt => nt.Symbol == listCh[k].chain[num]);
                        if (n != null)
                        {
                            flag = true;
                            for (int j = 0; j < n.replacements.Count; j++)
                            {
                                string a = listCh[k].chain.Remove(num, 1);
                                string b = a.Insert(num, n.replacements[j]);
                                b = b.Replace(" ", string.Empty);
                                Chain ch1 = new Chain(b.Trim(), listCh[k]);
                                if (!ch1.CheckRepeatedGenerates())
                                    listCh.Add(ch1);
                            }
                        }
                    }
                     listCh[k].chain = listCh[k].chain.Replace(" ", string.Empty);
                     if (flag == false && listCh[k].chain.Length <= maxLength && listCh[k].chain.Length >= minLength) resultChain.Add(listCh[k]);
                 }
             }
        }
        class BoxEqualityComparer : IEqualityComparer<Chain>
        {
            public bool Equals(Chain a, Chain b)
            {
                if (a.chain == b.chain) return true;
                return false;
            }
            public int GetHashCode(Chain bx)
            {
                int hCode = Convert.ToInt32(bx.chain);
                return hCode.GetHashCode();
            }
        }
    }
}

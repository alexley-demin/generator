using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regular_languages_generator
{
    class grammar_generator
    {
        List<NonTerminal> nonTerminals = new List<NonTerminal>();
        public List<NonTerminal> grammar_generator_one(List<char> alphabet,string finalSubstring,char symbol,int multiplicity,string typeGrammar)
        {
            int n = 0;
            for (int i = 0; i < finalSubstring.Length; i++)
            {
                if (finalSubstring[i] == symbol) n++;
            }
            if (n > multiplicity) n %= multiplicity;
            if (typeGrammar=="left")
            {
                if (finalSubstring.Length != 0)
                {
                    NonTerminal pt;
                    pt = new NonTerminal('S');
                    pt.AddReplacement("B" + finalSubstring);
                    nonTerminals.Add(pt);
                }
                for (int i = 1; i <= multiplicity; i++)
                {
                    NonTerminal pt1;

                    pt1 = new NonTerminal((char)('A' + (char)i));
                    foreach (char c in alphabet)
                    {
                        char nonT;
                        if (c == symbol)
                        {
                            if (i == multiplicity - n + 1)
                            {
                                pt1.AddReplacement("");

                            }
                            nonT = (char)('A' + (char)((i) % multiplicity + 1));
                            pt1.AddReplacement("" + nonT + c);
                            if (i == 1 && n == 0)
                            {
                                pt1.AddReplacement("");
                            }
                            continue;
                        }
                        nonT = (char)('A' + (char)i);
                        pt1.AddReplacement("" + nonT + c);
                    }
                    nonTerminals.Add(pt1);
                }
            }
            if (typeGrammar == "right")
            {
                for (int i = 1; i <= multiplicity; i++)
                {
                    NonTerminal pt1;

                    pt1 = new NonTerminal((char)('A' + (char)i));
                    foreach (char c in alphabet)
                    {
                        char nonT;
                        if (c == symbol)
                        {
                            if (i == multiplicity - n + 1)
                            {
                                pt1.AddReplacement(finalSubstring);
                                
                            }
                            nonT = (char)('A' + (char)((i) % multiplicity + 1));
                            pt1.AddReplacement("" + c + nonT);
                            if (i == 1 && n == 0)
                            {
                                pt1.AddReplacement(finalSubstring);
                            }
                            continue;
                        }
                            nonT = (char)('A' + (char)i);
                        pt1.AddReplacement("" + c + nonT);
                    }
                    nonTerminals.Add(pt1);
                }
            }

            return nonTerminals;
        }
        public List<NonTerminal> grammar_generator_two(List<char> alphabet, string initialSubstring, string finalSubstring, int multiplicity, string typeGrammar)
        {
            int finalstr = 0;
            int initstr = 0;
            if (finalSubstring.Length == 0) finalstr = 1;
            else finalstr = finalSubstring.Length;
            if (initialSubstring.Length == 0) initstr = 1;
            else initstr = initialSubstring.Length;
            int n = finalstr + initstr;
            string exiting = " ";
            if (n % multiplicity == 0) n = multiplicity;
            else if (n > multiplicity)
            {
                n %= multiplicity;
            }
                
            if (typeGrammar == "left")
            {

                if (finalSubstring.Length != 0)
                {
                    if (initialSubstring.Length != 0)
                    {
                        NonTerminal pt;
                        pt = new NonTerminal('S');
                        pt.AddReplacement("B" + finalSubstring);
                        
                        if (finalSubstring.Length + initialSubstring.Length > multiplicity /*&& finalSubstring.Length<= multiplicity%finalSubstring.Length && initialSubstring.Length<=multiplicity%finalSubstring.Length*/)
                        {
                            exiting = initialSubstring.Remove(Math.Abs(multiplicity - finalSubstring.Length));
                            exiting = exiting.Insert(exiting.Length , finalSubstring);
                            if (exiting.StartsWith(initialSubstring))
                            {
                                pt.AddReplacement(exiting);
                            }
                        }
                        nonTerminals.Add(pt);
                    }
                    else
                    {
                        NonTerminal pt;
                        pt = new NonTerminal('S');
                        pt.AddReplacement("B" + finalSubstring);
                        if (finalSubstring.Length % multiplicity == 0)
                        {
                            pt.AddReplacement(finalSubstring);
                        }
                        nonTerminals.Add(pt);
                    }
                }
                else
                {
                    if (initialSubstring.Length != 0)
                    {
                        NonTerminal pt;
                        pt = new NonTerminal('S');
                        foreach (char c in alphabet)
                        {
                            pt.AddReplacement("" + 'B' + c);
                        }
                        if(initialSubstring.Length%multiplicity == 0)
                        {
                            pt.AddReplacement(initialSubstring);
                        }
                        nonTerminals.Add(pt);
                    }
                    else
                    {
                        NonTerminal pt;
                        pt = new NonTerminal('S');
                        if (multiplicity == 1)
                        {
                            foreach (char c in alphabet)
                            {
                                pt.AddReplacement("" + 'S' + c);
                            }
                            pt.AddReplacement("");
                            nonTerminals.Add(pt);
                            return nonTerminals;
                        }
                            foreach (char c in alphabet)
                        {
                            pt.AddReplacement("" + 'B' + c);
                        }
                        pt.AddReplacement("");
                        nonTerminals.Add(pt);
                        
                        for(int i = 1; i < multiplicity; i++)
                        {
                            NonTerminal pt1;
                            pt1 = new NonTerminal((char)('A' + (char)i));
                            if (i == multiplicity-1)
                            {
                                foreach (char c in alphabet)
                                {
                                    pt1.AddReplacement("" + 'S' + c);
                                }
                            }
                            else
                                foreach (char c in alphabet)
                                {
                                    pt1.AddReplacement("" + (char)('A' + (char)(i + 1)) + c);
                                }
                            nonTerminals.Add(pt1);
                        }
                        return nonTerminals;
                    }

                }
                for (int i = 1; i <= multiplicity; i++)
                {
                    NonTerminal pt1;
                    pt1 = new NonTerminal((char)('A' + (char)i));
                    if (i == multiplicity - n + 1)
                    {
                        if (initialSubstring.Length != 0)
                        {
                            pt1.AddReplacement(initialSubstring);
                        }
                        else
                        {
                            foreach (char c in alphabet)
                            {
                                pt1.AddReplacement("" + c);
                            }
                        }
                    }
                    if (i != multiplicity)
                    {
                        foreach (char c in alphabet)
                        {
                            char nonT;
                            nonT = (char)('B' + (char)i);
                            pt1.AddReplacement("" + nonT + c);
                        }
                    }
                    else
                    {
                        foreach (char c in alphabet)
                        {
                            pt1.AddReplacement("" + 'B' + c);
                        }

                    }
                    nonTerminals.Add(pt1);
                }
            }

                if (typeGrammar == "right")
                {

                    if (initialSubstring.Length != 0)
                    {
                        if (finalSubstring.Length !=0)
                        {
                            NonTerminal pt;
                            pt = new NonTerminal('S');
                            pt.AddReplacement(initialSubstring + "B");
                            if (finalSubstring.Length + initialSubstring.Length > multiplicity /*&& finalSubstring.Length <= multiplicity && initialSubstring.Length <= multiplicity*/)
                            {
                                exiting = initialSubstring.Remove(Math.Abs(multiplicity - finalSubstring.Length));
                                exiting = exiting.Insert(exiting.Length, finalSubstring);
                                if (exiting.StartsWith(initialSubstring))
                                {
                                    pt.AddReplacement(exiting);
                                }
                            }
                            nonTerminals.Add(pt);
                        }
                        else
                        {
                            NonTerminal pt;
                            pt = new NonTerminal('S');
                            pt.AddReplacement(initialSubstring + "B");
                            if (initialSubstring.Length % multiplicity==0)
                            {
                                pt.AddReplacement(initialSubstring);
                               
                            }
                        nonTerminals.Add(pt);
                        }
                    }
                    else
                    {
                        NonTerminal pt;
                        pt = new NonTerminal('S');
                        if (finalSubstring.Length!=0)
                        {

                            foreach (char c in alphabet)
                                {
                                    pt.AddReplacement("" + c + 'B');
                                }
                            if (finalSubstring.Length % multiplicity == 0) pt.AddReplacement(finalSubstring);
                        }
                        else
                        {
                            if (multiplicity == 1)
                            {
                                foreach (char c in alphabet)
                                {
                                    pt.AddReplacement("" + c + 'S');
                                }
                                pt.AddReplacement("");
                                nonTerminals.Add(pt);
                                return nonTerminals;
                            }
                            foreach (char c in alphabet)
                            {
                                pt.AddReplacement("" + c + 'B');
                            }
                            pt.AddReplacement("");
                            nonTerminals.Add(pt);

                            for (int i = 1; i < multiplicity; i++)
                            {
                                NonTerminal pt1;
                                pt1 = new NonTerminal((char)('A' + (char)i));
                                if (i == multiplicity - 1)
                                {
                                    foreach (char c in alphabet)
                                    {
                                        pt1.AddReplacement("" + c + 'S');
                                    }
                                }
                                else
                                    foreach (char c in alphabet)
                                    {
                                        pt1.AddReplacement("" + c + (char)('A' + (char)(i + 1)));
                                    }
                                nonTerminals.Add(pt1);
                            }
                        return nonTerminals;
                        }
                        nonTerminals.Add(pt);
                    }
                    for (int i = 1; i <= multiplicity; i++)
                    {
                        NonTerminal pt1;
                        pt1 = new NonTerminal((char)('A' + (char)i));
                        if (i == multiplicity - n + 1)
                        {
                            if (finalSubstring.Length != 0)
                            {
                                pt1.AddReplacement(finalSubstring);
                            }
                            else
                            {
                                foreach (char c in alphabet)
                                {
                                    pt1.AddReplacement("" + c);
                                }
                            }
                        }
                        if (i != multiplicity)
                        {
                            foreach (char c in alphabet)
                            {
                                char nonT;
                                nonT = (char)('B' + (char)i);
                                pt1.AddReplacement("" + c + nonT);
                            }
                        }
                        else
                        {
                            foreach (char c in alphabet)
                            {
                                pt1.AddReplacement("" + c + 'B');
                            }

                        }
                        nonTerminals.Add(pt1);
                    }
                }
            return nonTerminals;
        }
        public List<NonTerminal> grammar_generator_three(List<char> alphabet, string substring, int multiplicity, string typeGrammar)
        {
            if(typeGrammar == "left")
            {
                int difference = 0;
                if (substring.Length % multiplicity != 0) difference = multiplicity - substring.Length % multiplicity;
                NonTerminal pt;
                pt = new NonTerminal('A');
                if (multiplicity == 1)
                {
                    foreach (char c in alphabet)
                    {
                        pt.AddReplacement("" + 'A' + c);
                    }
                }
                else
                {
                    foreach (char c in alphabet)
                    {
                        pt.AddReplacement("" + 'B' + c);
                    }
                }
                if (substring.Length != 0) pt.AddReplacement((char)('A' + multiplicity) + substring);
                else pt.AddReplacement("");

                nonTerminals.Add(pt);
                for (int i = 1; i <= multiplicity - 1; i++)
                {
                    NonTerminal pt1;
                    pt1 = new NonTerminal((char)('A' + i));
                    if (i == multiplicity - 1)
                    {
                        foreach (char c in alphabet)
                        {
                            pt1.AddReplacement("" + 'A' + c);
                        }
                    }
                    else
                    {
                        foreach (char c in alphabet)
                        {
                            pt1.AddReplacement("" + (char)('A' + i + 1) + c);
                        }
                    }
                    if (substring.Length != 0) pt1.AddReplacement((char)('A' + i + multiplicity) + substring);
                    nonTerminals.Add(pt1);
                }
                if (substring.Length != 0)
                {
                    for (int i = multiplicity; i < multiplicity * 2; i++)
                    {
                        NonTerminal pt1;
                        pt1 = new NonTerminal((char)('A' + i));
                        if (i == multiplicity + difference)
                        {
                            pt1.AddReplacement("");
                        }
                        if (i == multiplicity * 2 - 1)
                        {
                            foreach (char c in alphabet)
                            {
                                pt1.AddReplacement("" + (char)('A' + multiplicity) + c);
                            }
                        }
                        else
                        {
                            foreach (char c in alphabet)
                            {
                                pt1.AddReplacement("" + (char)('A' + i + 1) + c);
                            }
                        }
                        nonTerminals.Add(pt1);
                    }
                }
            }
            else
            {
                int difference = 0;
                if (substring.Length % multiplicity != 0) difference = multiplicity - substring.Length % multiplicity;
                NonTerminal pt;
                pt = new NonTerminal('A');
                if (multiplicity == 1)
                {
                    foreach (char c in alphabet)
                    {
                        pt.AddReplacement("" + c + 'A');
                    }
                }
                else
                {
                    foreach (char c in alphabet)
                    {
                        pt.AddReplacement("" + c + 'B');
                    }
                }
                if (substring.Length != 0) pt.AddReplacement(substring + (char)('A' + multiplicity));
                else pt.AddReplacement("");
                    
                nonTerminals.Add(pt);
                for(int i = 1; i <= multiplicity-1; i++)
                {
                    NonTerminal pt1;
                    pt1 = new NonTerminal((char)('A'+i));
                    if (i == multiplicity - 1)
                    {
                        foreach (char c in alphabet)
                        {
                            pt1.AddReplacement("" + c + 'A');
                        }
                    }
                    else
                    {
                        foreach (char c in alphabet)
                        {
                            pt1.AddReplacement("" + c + (char)('A' + i + 1));
                        }
                    }
                    if (substring.Length != 0) pt1.AddReplacement(substring + (char)('A' + i + multiplicity));
                    nonTerminals.Add(pt1);
                }
                if (substring.Length != 0)
                {
                    for (int i = multiplicity; i < multiplicity * 2; i++)
                    {
                        NonTerminal pt1;
                        pt1 = new NonTerminal((char)('A' + i));
                        if (i == multiplicity + difference)
                        {
                            pt1.AddReplacement("");
                        }
                        if (i == multiplicity * 2 - 1)
                        {
                            foreach (char c in alphabet)
                            {
                                pt1.AddReplacement("" + c + (char)('A' + multiplicity));
                            }
                        }
                        else
                        {
                            foreach (char c in alphabet)
                            {
                                pt1.AddReplacement("" + c + (char)('A' + i + 1));
                            }
                        }
                        nonTerminals.Add(pt1);
                    }
                }
 

            }
            return nonTerminals;
        }
    }
}

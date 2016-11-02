using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
namespace regular_languages_generator
{
    public partial class Form1 : Form
    {
        List<Chain> listFinished = new List<Chain>();
        List<NonTerminal> nonTerminals = new List<NonTerminal>();
        char symbol;
        int multiplicity;
        string finalSubstring;
        string initialSubstring;
        string alp;
        string substring;
        string typeGrammar = "";
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button_process_Click(object sender, EventArgs e)
        {
            if(listBox_nonterminals.Items.Count==0)
            {
                MessageBox.Show("Постройте правила");
                return;
            }
            listFinished.Clear();
            NonTerminal nt = null;
            nt = nonTerminals.Find(n => n.Symbol == label9.Text[0]);
            Chain ch = new Chain("" + nt.Symbol);
            Language_chains_generator pt = new Language_chains_generator(ch, nonTerminals);
            pt.GenerateChains((int)nonTermSequenceMinLength.Value, (int)nonTermSequenceMaxLength.Value,typeGrammar);
            listBox_sequences.Items.Clear();
            foreach (Chain ch1 in pt.resultChain)
            {
                listBox_sequences.Items.Add(ch1.chain);
                listFinished.Add(ch1);
            }
            label11.Text = pt.resultChain.Count.ToString();
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_sequences.SelectedIndex != -1)
            {
                Chain ch = listFinished[listBox_sequences.SelectedIndex];
                MessageBox.Show(ch.ShowChain());
            }
        }


        private void nonTermSequenceMinLength_ValueChanged(object sender, EventArgs e)
        {
            if (nonTermSequenceMinLength.Value > nonTermSequenceMaxLength.Value)
                nonTermSequenceMinLength.Value = nonTermSequenceMaxLength.Value;
        }
/*        private void nonTermSequenceMaxLength_ValueChanged(object sender, EventArgs e)
        {
            if (nonTermSequenceMinLength.Value > nonTermSequenceMaxLength.Value)
                nonTermSequenceMaxLength.Value = nonTermSequenceMinLength.Value;
        }*/


        private void grammar_generation_button_Click(object sender, EventArgs e)
        {
            List<char> alphabet = new List<char>();
            nonTerminals = new List<NonTerminal>();
            grammar_generator grammar = new grammar_generator();
            listBox_nonterminals.Items.Clear();
            string reading_alp;
            reading_alp=textBoxAlphabet.Text.ToString();
            if (reading_alp.Length == 0)
            {
                MessageBox.Show("введите алфавит");
                return;
            }
            textBoxAlphabet.Clear();
            string pattern = @"[\s\p{P}]";
            string clearalp = Regex.Replace(reading_alp, pattern, string.Empty);
            alp = new string(clearalp.Distinct().ToArray());
            if (alp.Length == 0)
            {
                MessageBox.Show("введите алфавит");
                return;
            }
            int amount = 0;
            string replaceSymbols = "";
            if (clearalp != alp)
            {
                foreach(char c in alp)
                {
                    amount = new Regex(""+c).Matches(clearalp).Count;
                    if (amount > 1) replaceSymbols += " " +c;
                }
                MessageBox.Show("Из алфавита были удалены дубликаты символа(ов):"+replaceSymbols);
            } 

            alphabet.AddRange(alp);
            for(int i = 0; i < alphabet.Count-1; i++)
            {
                textBoxAlphabet.Text += alphabet[i] + ",";
            }
            textBoxAlphabet.Text += alphabet[alphabet.Count()-1];
            alp = textBoxAlphabet.Text;

            if (radioButton3.Checked == true)
            {
                if (textBoxSubstring.TextLength == 0)
                    finalSubstring = " ";
                else
                {
                    finalSubstring = textBoxSubstring.Text.ToString();
                    for(int i = 0;i < finalSubstring.Length; i++)
                    {
                        if (!alphabet.Contains(finalSubstring[i]))
                        {
                            MessageBox.Show("Неверный конец цепочки. Символ " + "'" + finalSubstring[i] + "'" + " не является символом алфавита.");
                            return;
                        }
                    }
                }
                

                if (textBoxParameter.TextLength == 0)
                {
                    MessageBox.Show("введите символ");
                    return;
                }
                symbol = textBoxParameter.Text[0];
                if (!alphabet.Contains(symbol))
                {
                    MessageBox.Show("Неверный символ. " + "'" + symbol + "'" + " не является символом алфавита.");
                    return;
                }
                int n = 0;
                Int32.TryParse(textBoxMultiplicity.Text, out multiplicity);
                if (multiplicity > 10 || multiplicity <= 0)
                {
                    MessageBox.Show("введите кратность в диапазоне от 1 до 10");
                    return;
                }
                if (radioButton1.Checked == true)
                {
                    if (finalSubstring.Length != 0)
                    {
                        label9.Text = "S";
                    }
                    else label9.Text = "B";
                    typeGrammar = "left";
                }
                else
                {
                    typeGrammar = "right";
                    label9.Text = "B";
                }
                nonTerminals = grammar.grammar_generator_one(alphabet, finalSubstring, symbol, multiplicity, typeGrammar);

            }
            if(radioButton4.Checked == true)
            {
 
                label9.Text = "S";
                if (textBoxSubstring.TextLength == 0) initialSubstring = "";
                else
                {
                    initialSubstring = textBoxSubstring.Text.ToString();
                    for (int i = 0; i < initialSubstring.Length; i++)
                    {
                        if (!alphabet.Contains(initialSubstring[i]))
                        {
                            MessageBox.Show("Неверная начальная подцепочка. Символ " + "'" + initialSubstring[i] + "'" + " не является символом алфавита.");
                            return;
                        }
                    }
                }

                if (textBoxParameter.TextLength == 0) finalSubstring = "";
                else
                {
                    finalSubstring = textBoxParameter.Text.ToString();
                    for (int i = 0; i < finalSubstring.Length; i++)
                    {
                        if (!alphabet.Contains(finalSubstring[i]))
                        {
                            MessageBox.Show("Неверная конечная подцепочка. Символ " + "'" + finalSubstring[i] + "'" + " не является символом алфавита.");
                            return;
                        }
                    }
                }


                Int32.TryParse(textBoxMultiplicity.Text, out multiplicity);
                if (multiplicity > 10 || multiplicity <= 0)
                {
                    MessageBox.Show("введите кратность в диапазоне от 1 до 10");
                    return;
                }
                if (radioButton1.Checked == true) typeGrammar = "left";
                else typeGrammar = "right";
                nonTerminals = grammar.grammar_generator_two(alphabet, initialSubstring, finalSubstring, multiplicity, typeGrammar);
            }
            if(radioButton5.Checked == true)
            {
                label9.Text = "A";
                if (textBoxSubstring.TextLength == 0) substring = "";
                else
                {
                    substring = textBoxSubstring.Text.ToString();
                    for (int i = 0; i < substring.Length; i++)
                    {
                        if (!alphabet.Contains(substring[i]))
                        {
                            MessageBox.Show("Неверная фиксированная подцепочка. Символ " + "'" + substring[i] + "'" + " не является символом алфавита.");
                            return;
                        }
                    }
                }
                    
                if (radioButton1.Checked == true) typeGrammar = "left";
                else typeGrammar = "right";
                Int32.TryParse(textBoxParameter.Text, out multiplicity);
                if (multiplicity > 10 || multiplicity <= 0)
                {
                    MessageBox.Show("введите кратность в диапазоне от 1 до 10");
                    return;
                }
                nonTerminals = grammar.grammar_generator_three(alphabet, substring, multiplicity, typeGrammar);
            }
            foreach (NonTerminal nt in nonTerminals)
                listBox_nonterminals.Items.Add(nt.ToString());
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Описание языка (*.rl)|*.rl";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader F = new StreamReader(openFileDialog.FileName);
                
                if (radioButton3.Checked == true)
                {
                    if (File.ReadLines(openFileDialog.FileName).Count() > 4)
                    {
                        MessageBox.Show("В файле указаны некорректные данные");
                        return;
                    }
                    textBoxAlphabet.Text = F.ReadLine().ToString();
                    textBoxSubstring.Text = F.ReadLine().ToString().Trim();
                    string parameter = F.ReadLine().ToString().Trim();
                    if (parameter.Length > 1)
                    {
                        MessageBox.Show("В файле указаны некорректные данные");
                        return;
                    }
                    textBoxParameter.Text = parameter;
                    Int32.TryParse(F.ReadLine(), out multiplicity);
                    if (multiplicity > 10 || multiplicity <= 0)
                    {
                        MessageBox.Show("В файле указаны некорректные данные");
                        return;
                    }
                    textBoxMultiplicity.Text = multiplicity.ToString();
                    F.Close();
                }
                if(radioButton4.Checked == true)
                {
                    if (File.ReadLines(openFileDialog.FileName).Count() > 4)
                    {
                        MessageBox.Show("В файле указаны некорректные данные");
                        return;
                    }
                    textBoxAlphabet.Text = F.ReadLine();
                    textBoxSubstring.Text = F.ReadLine();
                    textBoxParameter.Text = F.ReadLine();
                    Int32.TryParse(F.ReadLine(), out multiplicity);
                    if (multiplicity > 10 || multiplicity <= 0)
                    {
                        MessageBox.Show("В файле указаны некорректные данные");
                        return;
                    }
                    textBoxMultiplicity.Text = multiplicity.ToString();
                    F.Close();
                }
                if(radioButton5.Checked == true)
                {
                    if (File.ReadLines(openFileDialog.FileName).Count() > 3)
                    {
                        MessageBox.Show("В файле указаны некорректные данные");
                        return;
                    }
                    textBoxAlphabet.Text = F.ReadLine();
                    textBoxSubstring.Text = F.ReadLine();
                    Int32.TryParse(F.ReadLine(), out multiplicity);
                    if (multiplicity > 10 || multiplicity <= 0)
                    {
                        MessageBox.Show("В файле указаны некорректные данные");
                        return;
                    }
                    textBoxParameter.Text = multiplicity.ToString();
                    F.Close();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                string sym = "";
                foreach (NonTerminal nt in nonTerminals)
                {
                    sym += nt.Symbol;
                    sym += ",";
                }
                sym = sym.Remove(sym.Length-1);
                if (radioButton3.Checked == true)
                    streamWriter.WriteLine(label4.Text +" : " + alp + "; " + label5.Text + " : " + finalSubstring + "; " + label6.Text + " : " + symbol + "; " + label7.Text + " : " + multiplicity + ";");
                if (radioButton4.Checked == true)
                    streamWriter.WriteLine(label4.Text + " : " + alp + "; " + label5.Text + " : " + initialSubstring + "; " + label6.Text + " : " + finalSubstring + "; " + label7.Text + " : " + multiplicity + ";");
                if (radioButton5.Checked == true)
                    streamWriter.WriteLine(label4.Text + " : " + alp + "; " + label5.Text + " : " + substring + "; " + label6.Text + " : " + multiplicity + "; ");
                streamWriter.WriteLine("G(" + "{" + alp + "}" + "," + "{" + sym + "}" + "," + label9.Text + "," + "P)");
                foreach (var item in listBox_nonterminals.Items)
                    streamWriter.WriteLine(item.ToString());
                foreach (var item in listBox_sequences.Items)
                    streamWriter.WriteLine(item.ToString());

                streamWriter.Close();
            }
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Демин Алексей ИП-213");
        }

        private void темаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа предназначе для генерации регулярных языков по заданному описанию.\n Программа позваляет считывать исходные данные из файла и сохранять в файл резулаты работы программы.\n Пользователь может посмотреть поэтапное построение цепочки нажав на неё дважды левой кнопкой мыши");
        }



        private void ClearData()
        {
            alp = "";
            finalSubstring = "";
            initialSubstring = "";
            substring = "";
            multiplicity = 1;
            symbol=' ';
        }
        private void ClearField()
        {
            textBoxAlphabet.Clear();
            textBoxMultiplicity.Clear();
            textBoxParameter.Clear();
            textBoxSubstring.Clear();
            listBox_sequences.Items.Clear();
            listBox_nonterminals.Items.Clear();
            label9.ResetText();
            label11.ResetText();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Конец цепочки";
            label6.Text = "Символ";
            label7.Text = "Кратность символа (от 1 до 10)";
            label6.Visible = true;
            textBoxParameter.Visible = true;
            label7.Visible = true;
            textBoxMultiplicity.Visible = true;
            ClearField();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Начальная подцепочка";
            label6.Text = "Конечная подцепочка";
            label7.Text = "Кратность длины цепочек языка";
            label6.Visible = true;
            textBoxParameter.Visible = true;
            label7.Visible = true;
            textBoxMultiplicity.Visible = true;
            ClearField();
            ClearData();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Фиксированная подцепочка";
            label6.Visible = true;
            label6.Text = "Кратность длины цепочек языка";
            textBoxParameter.Visible = true;
            label7.Visible = false;
            textBoxMultiplicity.Visible = false;
            ClearField();
            ClearData();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBoxAlphabet_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBoxAlphabet, "Пример:a,b,c");
        }
        private void button_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(chains_generation_button, "Выполнить построение цепочек");
        }
    }
}

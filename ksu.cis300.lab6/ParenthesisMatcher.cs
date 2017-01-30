using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ksu.cis300.lab6
{
    public partial class ParenthesisMatcher : Form
    {
        public ParenthesisMatcher()
        {
            InitializeComponent();
        }

        private void uxCheckButton_Click(object sender, EventArgs e)
        {
            string inputText = uxTextEntry.Text;
            Stack < Char > paranthesisStack = new Stack<Char>();
            int count = 0;
            foreach (char c in inputText)
            {
                count++;
                if (IsOpeningParenthesis(c))
                {
                    paranthesisStack.Push(c);
                }
                else if (IsClosingParenthesis(c))
                {
                    if (paranthesisStack.Count > 0)
                    {
                        if (Matches(paranthesisStack.Peek(), c)) 
                        {
                            paranthesisStack.Pop();
                        }
                        else
                        {
                            
                            break;
                        }
                    }
                    else
                    {
                        
                        count--;
                        break;
                    }
                }

            }
            if (paranthesisStack.Count == 0 && count == inputText.Length)
            {
                ShowSuccess();
            }
            else
            {
                ShowError();
            }
        }
        /// <summary>
        /// Determines whether the given character is an opening parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is an opening parenthesis.</returns>
        private bool IsOpeningParenthesis(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        /// <summary>
        /// Determines whether the given character is a closing parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is a closing parenthesis.</returns>
        private bool IsClosingParenthesis(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        /// <summary>
        /// Determines whether the given characters for a matched pair
        /// of parentheses.
        /// </summary>
        /// <param name="a">The opening character.</param>
        /// <param name="b">The closing character.</param>
        /// <returns>Whether a and b form a matched pair of parentheses.</returns>
        private bool Matches(char a, char b)
        {
            return (a == '(' && b == ')') || (a == '[' && b == ']') ||
                (a == '{' && b == '}');
        }

        /// <summary>
        /// Displays a success message.
        /// </summary>
        private void ShowSuccess()
        {
            MessageBox.Show("The string is matched.");
        }

        /// <summary>
        /// Displays an error message.
        /// </summary>
        private void ShowError()
        {
            MessageBox.Show("The string is not matched.");
        }
    }
}

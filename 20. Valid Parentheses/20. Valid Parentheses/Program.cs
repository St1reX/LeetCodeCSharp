using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("(]"));
        }

        static public bool IsValid(string s)
        {
            List<char> list = new List<char>();
            list.Add(' ');
            int amount = 0;
            
            for(int i = 0; i < s.Length; i++) 
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    list.Add(s[i]);
                    amount++;
                }
                else
                {
                    switch (s[i])
                    {
                        case ')':
                            if (list[list.Count-1] != '(')
                            {
                                return false;
                            }
                            amount--;
                            list.RemoveAt(list.Count - 1);
                            break;
                        case ']':
                            if (list[list.Count-1] != '[')
                            {
                                return false;
                            }
                            amount--;
                            list.RemoveAt(list.Count - 1);
                            break;
                        case '}':
                            if (list[list.Count-1] != '{')
                            {
                                return false;
                            }
                            amount--;
                            list.RemoveAt(list.Count - 1);
                            break;
                    }
                }
            }
            if(amount > 0) 
            {
                return false;
            }

            return true;
        }
    }
}

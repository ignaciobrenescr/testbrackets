using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace bracketbalance
{
    public class Balance
    {
        static List<int> nodes = new List<int>();
        public static bool isBalance(string s)
        {
            s = s.Replace(" ", "");
            for (int i = 0; i < s.Length;i++)
            {
                if (nodes.Where(x => i == x).Count() > 0) continue;

                if (s[i] == '{')
                {
                    if (!checkright(s, i)){
                        return false;
                    }
                }
                else
                {
                    if (!checkleft(s, i))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private static bool checkright(string s, int position)
        {
            for (int i = position+1; i < s.Length;i++)
            {
                if (nodes.Where(x => i == x).Count() > 0) continue;
                if (s[i] == '{')
                {
                    if (!checkright(s, i))
                    {
                        return false;
                    }
                }
                else
                {
                    nodes.Add(position);
                    nodes.Add(i);
                    return true;
                }

            }
            return false;
        }

        private static bool checkleft(string s, int position)
        {
            for (int i = 0; i < position; i++)
            {
                if (nodes.Where(x => i == x).Count() > 0) continue;
                if (s[i] == '}')
                {
                    if (!checkleft(s, i))
                    {
                        return false;
                    }
                }
                else
                {
                    nodes.Add(position);
                    nodes.Add(i);
                    return true;
                }

            }
            return false;
        }
        

    }
}

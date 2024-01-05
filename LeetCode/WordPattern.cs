using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public bool WordPattern(string pattern, string s)
    {
        Char[] pattern_letter = pattern.ToCharArray();
        List<String> words = s.Split(' ').ToList();

        Dictionary<String, Char> mapped = new Dictionary<String, Char>();
        Dictionary<Char, String> map = new Dictionary<Char, String>();

        if (pattern_letter.Length != words.Count)
            return false;

        for (int i = 0; i < pattern_letter.Length; i++)
        {
            // Add key to dict
            try
            {
                map.Add(pattern_letter[i], words[i]);
                mapped.Add(words[i], pattern_letter[i]);
            }
            // KEY ALREADY EXISTS
            catch (Exception)
            {
                try
                {
                    if (mapped[words[i]] != pattern_letter[i])
                        return false;
                }
                catch (Exception exc)
                {
                    return false;
                }
            }
        }

        return true;
    }

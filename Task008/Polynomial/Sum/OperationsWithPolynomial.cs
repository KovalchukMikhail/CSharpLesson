using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial.Sum
{
    internal class OperationsWithPolynomial
    {
        public Dictionary<int, int> GetSumPolinomialsAsDict(string first, string second)
        {
            Dictionary<int, int> firstAsDict = ParseStringToListOfDict(first);
            Dictionary<int, int> SecondAsDict = ParseStringToListOfDict(second);
            Dictionary<int, int> resultAsDict = SumDict(firstAsDict, SecondAsDict);
            return resultAsDict;
        }

        private Dictionary<int, int> ParseStringToListOfDict(string polynomial)
        {
            List<string> list = polynomial.Replace('+', ' ').Replace("-", " -").TrimStart().Split(" ").ToList().Where(s => s != "+").ToList();
            Dictionary<int, int> Dict = new Dictionary<int, int>();
            foreach(string s in list)
            {
                if (s.Contains("*x^"))
                {
                    string[] temp = s.Split("*x^");
                    Dict.Add(Convert.ToInt32(temp[1]), Convert.ToInt32(temp[0]));

                }
                else if (s.Contains("*x"))
                {
                    string[] temp = s.Split("*x");
                    Dict.Add(1, Convert.ToInt32(temp[0]));
                }
                else if (s.Contains("-x^"))
                {
                    string[] temp = s.Split("-x^");
                    Dict.Add(Convert.ToInt32(temp[1]), -1);
                }
                else if (s.Contains("x^"))
                {
                    string[] temp = s.Split("x^");
                    Dict.Add(Convert.ToInt32(temp[1]), 1);
                }
                else if (s.Contains("-x"))
                {
                    string[] temp = s.Split("-x");
                    Dict.Add(1, -1);
                }
                else if (s.Contains("x"))
                {
                    string[] temp = s.Split("x");
                    Dict.Add(1, 1);
                }
                else
                {
                    Dict.Add(0, Convert.ToInt32(s));
                }
            }
            return Dict;
        }
        private Dictionary<int, int> SumDict(Dictionary<int, int> firstDict, Dictionary<int, int> secondDict)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            int maxKey = GetMaxKey(firstDict);
            int temp = GetMaxKey(secondDict);
            maxKey = temp > maxKey? temp: maxKey;
            for(int i = 0; i <= maxKey; i++)
            {
                if (firstDict.ContainsKey(i) && secondDict.ContainsKey(i))
                {
                    result[i] = firstDict[i] + secondDict[i];
                }
                else if (!firstDict.ContainsKey(i) && secondDict.ContainsKey(i))
                {
                    result[i] = secondDict[i];
                }
                else if (firstDict.ContainsKey(i) && !secondDict.ContainsKey(i))
                {
                    result[i] = firstDict[i];
                }
            }
            return result;
        }

        private int GetMaxKey(Dictionary<int, int> Dict)
        {
            int result = 0;
            foreach(var kv  in Dict)
            {
                if(kv.Key > result) result = kv.Key;
            }
            return result;
        }
    }
}

// 4*x^5+4*x^4-x^3+2*x^2+4*x^1-4
// -4*x^5+4*x^4-x^3+x^2-2*x^1+5
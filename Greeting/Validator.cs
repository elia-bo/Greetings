using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting.Chain
{
    public static class Validator
    {
        public static string[] Validate(params string[] input)
        {
            if (input == null) return null;
            List<string> result = new List<string>();
            if (input.Any(x => x.Contains(@"""")))
            {
                foreach (var item in input)
                {
                    if (item.Contains(@""""))
                        result.Add(MakeSingleItem(item));
                    else result.Add(item);
                }
            }
            else
            {
                foreach (var item in input)
                {
                    if (item.Contains(','))
                    {
                        result.Add(item.Split(',')[0].Trim());
                        result.Add(item.Split(',')[1].Trim());
                    }
                    else result.Add(item);
                }
            }
            return RemoveEmptyNames(result).ToArray();
        }

        private static string MakeSingleItem(string input)
        {
            var temp = input.Remove(0, 1).Remove(input.Length - 2);
            return temp;
        }

        private static List<string> RemoveEmptyNames(List<string> input) => input.Where(x => x != "").ToList();
    }
}

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
            var result = new List<string>();
            if (input.Any(x => x.Contains(@"""")))
                result = AddNamesWithoutQuotesToList(input);
            else
                result = AddPairedNamesToList(input);
            return RemoveEmptyNames(result).ToArray();
        }

        private static List<string> AddPairedNamesToList(string[] input)
        {
            var result = new List<string>();
            foreach (var item in input)
            {
                if (item.Contains(','))
                {
                    var temp = item.Split(',').Select(x => x.Trim());
                    result.AddRange(temp);
                }
                else result.Add(item);
            }
            return result;
        }

        private static List<string> AddNamesWithoutQuotesToList(string[] input)
        {
            var result = new List<string>();
            foreach (var item in input)
            {
                if (item.Contains(@""""))
                    result.Add(MakeSingleItem(item));
                else result.Add(item);
            }
            return result;
        }

        private static string MakeSingleItem(string input) => input.Replace("\"", string.Empty);

        private static List<string> RemoveEmptyNames(List<string> input) => input.Where(x => x != "").ToList();
    }
}

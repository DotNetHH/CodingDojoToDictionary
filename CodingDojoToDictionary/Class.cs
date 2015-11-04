using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojoToDictionary
{
    public class Class
    {
        private static string[] ParseInput(string input)
        {
            return input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static IDictionary<string, string> ToDictionary(string input)
        {
            var values = ParseInput(input);
            var result = new Dictionary<string, string>();

            foreach (var value in values)
            {
                var assignment = value.Split(new[] { '=' }, 2);
                //string key
                if (string.IsNullOrEmpty(assignment[0]))
                    throw new Exception();

                if (result.ContainsKey(assignment[0]))
                    result[assignment[0]] = assignment[1];
                else
                    result.Add(assignment[0], assignment[1]);
            }

            return result;
        }
    }
}
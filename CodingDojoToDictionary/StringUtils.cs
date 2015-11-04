using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojoToDictionary
{
    public class StringUtils
    {
        public static IDictionary<string, string> ToDictionary(string input)
        {
            var assignments = SplitIntoAssignments(input);
            return BuildDictionaryFrom(assignments);
        }

        private static IDictionary<string, string> BuildDictionaryFrom(string[] assignments)
        {
            var result = new Dictionary<string, string>();

            foreach (var assignment in assignments)
            {
                var keyValuePair = SplitIntoKeyValuePair(assignment);
                if (string.IsNullOrEmpty(keyValuePair.Key))
                {
                    throw new Exception();
                }
                result[keyValuePair.Key] = keyValuePair.Value;
            }

            return result;
        }

        private static string[] SplitIntoAssignments(string input)
        {
            return input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static KeyValuePair<string, string> SplitIntoKeyValuePair(string value)
        {
            var pair = value.Split(new[] { '=' }, 2);
            return new KeyValuePair<string, string>(pair[0], pair[1]);
        }
    }
}
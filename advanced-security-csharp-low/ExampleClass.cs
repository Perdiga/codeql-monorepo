using System;
using System.Linq;

namespace LowQualityAnalysisExample
{
    public static class ExampleClass
    {
        private static string secret = "TopSecret";

        // Private method accessed by reflection
        private static string GetSecret(string input)
        {
            // Obfuscate logic and return secret
            return new string(secret.Reverse().ToArray());
        }
    }
}
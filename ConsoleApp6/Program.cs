using System;


namespace QuickPulseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in args)
            {
                sb.Append(s);
                sb.Append(",");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(sb);
        }

        static string[] StripBadWord(string[] args, string wordToStrip)
        {
            string[] vs = new string[args.Length];
            int j = 0;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == wordToStrip)
                {
                    vs[j++] = args[i];
                }
            }
            Array.Resize(ref vs, j);
            return vs;
        }
}

using System.Text.RegularExpressions;

namespace SearchWord_Task_4
{
    public static class SearchWordClass
    {
        public static int Search(string[] args)
        {
            int result = 0;
            try
            {
                if (args.Length != 2)
                {
                    throw new Exception("args.Length != 2");
                }
                string path = string.Empty;
                string word = string.Empty;
                foreach (var arg in args)
                {
                    if (arg.Contains(".txt"))
                    {
                        path = arg;
                    }
                    else
                    {
                        word = arg;
                    }
                }
                if (path == string.Empty)
                {
                    throw new Exception("*.txt not found");
                }
                string text = string.Empty;
                using StreamReader reader = new(path);
                text = reader.ReadToEnd();

                result = Regex
                    .Matches(text, $"\\b{Regex.Escape(word)}\\b", RegexOptions.IgnoreCase)
                    .Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(-1);
            }
            return result;
        }
    }
}

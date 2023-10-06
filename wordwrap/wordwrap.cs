using System;
using System.IO;
using WordWrap;

namespace WordWrap
{
    class Program
    {
        const int WrapLength = 80;

        static void Main(string[] args)
        {
            args = new string[] { @"C:\Users\kevin\source\repos\kns98\resume" };

            string directoryPath = args.Length > 0 ? args[0] : Directory.GetCurrentDirectory();

            foreach (var filePath in Directory.EnumerateFiles(directoryPath, "*.html", SearchOption.AllDirectories))
            {
                string content = File.ReadAllText(filePath);
                HandyTextHandler wrappedTextHandler = new HandyTextHandler(content, WrapLength);

                string wrappedContent = "";
                for (var i = 0; i < wrappedTextHandler.numOfPages; i++)
                {
                    wrappedContent += wrappedTextHandler.Page(i);
                    if (i != wrappedTextHandler.numOfPages - 1) // If not the last page, add a new line
                        wrappedContent += "\n";
                }

                File.WriteAllText(filePath, wrappedContent);
            }
        }
    }
}

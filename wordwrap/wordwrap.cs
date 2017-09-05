using System;
using WordWrap;

namespace WordWrap
{
    class demo
    {
        static void Main(string[] args)
        {
            string str = "Our Expert Guides section draws together " +
                "pieces of work written by area experts, and gives you detailed " +
                "insight into features and topics.These documents tend to differ from " +
                "the rest of Unity’s documentation both-in writing style and content. " +
                "They represent some of the best developers providing their own insight " +
                "into the workings of Unity and how to get the most out of itttttttttttttttttt. \n" +
                "Some of these documents originated as blog posts, which we are collecting " +
                "for convenience here to prevent them from being buried under the constant " +
                "flow of new posts on our site. Others have been written specificially for" +
                " this section by developers who want to get their knowledge into your hands " +
                "directly. Because their length and format differs from the the User Manual’s" +
                " normal style, we provide them to you as downloadable PDFs.";

            HandyTextHandler a = new HandyTextHandler(str, 40, 5);

            //输出书的全部内容
            for (var i = 0; i < a.numOfPages; i++)
            {
                Console.WriteLine("Page {0}:", i);
                Console.WriteLine(a.Page(i));
            }

            //当前页
            Console.WriteLine("\n");
            Console.WriteLine("Current page is: {0}", a.curPage);
            Console.WriteLine("\n");

            //前一页
            Console.WriteLine(a.RPage(-1));
        }
    }
}

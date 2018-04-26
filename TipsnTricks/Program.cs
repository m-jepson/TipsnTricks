using System;
using System.Text;

namespace TipsnTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Henk";
            var hello = "Hello " + name + ", today is " + DateTime.Now.ToString("D") + ".";
            Console.WriteLine(hello);

            var hello2 = string.Format("Hello {0}, today is {1:D}.", name, DateTime.Now);
            Console.WriteLine(hello2);

            var hello3 = $"Hello {name}, today is {DateTime.Now:D}.";
            Console.WriteLine(hello3);

            Console.ReadKey();

var sb = new StringBuilder();
sb.Append("Hello ");
sb.Append(name);
sb.Append(", today is ");
sb.AppendFormat("{0:D}.", DateTime.Now);
sb.AppendLine();
sb.AppendLine("This is an extra line.");
sb.Append("And another").Append(" one.");
var hello4 = sb.ToString();
Console.WriteLine(hello4);

            Console.ReadKey();

            using(var DatabaseConnection)

        }
    }
}

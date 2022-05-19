using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStrings
{
    public class ParseURL
    {
        public static void Start()
        {
            Console.Write("Enter URL: ");
            string url = Console.ReadLine();

            string protocol = "";
            string server = "";
            string resource = "";

            string[] protocols = url.Split(':');
            if (protocols.Length > 1)
            {
                protocol = protocols[0];
                url = String.Join("", protocols[1].TakeLast(protocols[1].Length - 2));
            }

            string[] servers = url.Split('/');
            if (servers.Length > 1)
            {
                server = servers[0];
                resource = servers[1];
            } else
            {
                server = url;
            }

            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}

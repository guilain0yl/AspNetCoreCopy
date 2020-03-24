//using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Hosting;

namespace TestAspNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument xmlDocument = new XmlDocument();

            //xmlDocument.Load(@"F:\m_project\MicrosoftDevs\dotnetcore\aspnetcoreCopy\src\Mvc\Mvc.NewtonsoftJson\src\Resources.resx");

            //var datas = xmlDocument.GetElementsByTagName("data");

            //StringBuilder stringBuilder = new StringBuilder();

            //foreach (XmlNode item in datas)
            //{
            //    var s = item.Attributes["name"].Value;
            //    var o = item.ChildNodes[1].InnerText;
            //    o = o.Replace("\"", "\\\"");
            //    int i = 0;

            //    string args1 = "";
            //    string args2 = "";

            //    while (o.IndexOf($"{{{i}}}") >= 0)
            //    {
            //        args1 += $"string s{i},";
            //        args2 += $"s{i},";
            //        i++;
            //    }

            //    if (args1.Length > 0)
            //    {
            //        args1 = args1.Trim(',');
            //        args2 = args2.Trim(',');
            //        stringBuilder.Append($"internal static string Format{s}({args1}) => string.Format(\"{o}\",{args2});");
            //    }
            //    else
            //    {
            //        stringBuilder.Append($"internal static string {s} = \"{o}\";");
            //    }

            //    stringBuilder.AppendLine();
            //}


            CreateHostBuilder(args).Build().Run();


            Console.WriteLine("Hello World!");
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
        }
    }
}

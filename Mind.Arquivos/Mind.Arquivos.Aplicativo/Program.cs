using Mind.Arquivos.Dominio;
using System;
using System.Linq;
using System.IO;

namespace Mind.Arquivos.Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            VarredorEstrutura.VarreDiretorio(@"C:\Allfiles").Where(r => r is FileInfo).GroupBy(g => g.Extension).Select(r => new { r.Key, ExtensionCount = r.Count() }).ToList().ForEach(i => Console.WriteLine("Tipo: {0}, Total: {1}", i.Key, i.ExtensionCount));
            //foreach (var res in resultado)
            //    Console.WriteLine(res.FullName);
            //Console.ReadLine();

            //foreach (var res in resultado)
            //{
            //    Console.WriteLine("Tipo: {0}, Total: {1}", res.Key, res.ExtensionCount);
            //}

            Console.ReadLine();

        }
    }

}

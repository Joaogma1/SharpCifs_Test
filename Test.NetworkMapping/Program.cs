using System;
using System.IO;
using System.Net;
using SharpCifs.Smb;

namespace Test.NetworkMapping
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var folder = new SmbFile("smb://192.168.0.114/planilhas/", new NtlmPasswordAuthentication("admin:@Tiva100"));

            foreach (SmbFile f in folder.ListFiles())
            {
                Console.WriteLine(f.GetName());
            }

                //using (new ConnectToSharedFolder(@"\\server1\planilhas", new NetworkCredential(@"{admin}", "{@Tiva100}")))
                //{
                //    var FileList = Directory.GetDirectories(@"\\server1\planilhas");

                //    foreach (var f in FileList)
                //    {
                //        Console.WriteLine(f);
                //    }
                //}


            }
    }
}


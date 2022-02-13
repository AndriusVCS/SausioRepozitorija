using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Failai
{
    class CustomAttribute : Attribute
    {

    }

    public class LibWrapper
    {
        [DllImport("Foo.dll")]
        public static extern void DoStuff(IntPtr handle);
        [DllImport("Foo.dll")]
        public static extern void DoStuff2(IntPtr handle);

        public void DoStuff_wrapped(IntPtr h)
        {
            DoStuff(h);
        }
        public void DoStuff_wrapped2(IntPtr h)
        {
            DoStuff2(h);
        }

        public delegate void WrappedMethod(IntPtr h);
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<object> sar = new List<object>();
            var x = sar.FindAll(x => x.GetType().IsDefined(typeof(CustomAttribute), true));


            //Path keliasIFaila = Path.("C:\Users\VPM\Documents\Projektai\SausioRepozitorija\PirmasProjektas\Failai")
            string fullPath = @"C:\Users\VPM\Documents\Projektai\SausioRepozitorija\PirmasProjektas\Failai\duomenys.txt";

            Console.WriteLine("Iveskite duomenis:");
            string duomenys = Console.ReadLine();

            try
            {
                File.WriteAllText(fullPath, duomenys);
                string tekstas = File.ReadAllText(fullPath);
                Console.WriteLine("Duomenys:");
                Console.WriteLine(tekstas);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Ivyko klaida: {e.Message}");
            }

            

            //using(StreamReader streamReader = new StreamReader(File.Open(fullPath, FileMode.OpenOrCreate)))
            //{
                    
            //}

            //string relativePath = @"..\..\..\duomenys.txt";
            //string tekstsas = File.ReadAllText(relativePath);
            //FileInfo manoFailoInformacija = new FileInfo(relativePath);
            
            //Console.WriteLine(tekstsas);
            Console.ReadLine();

        }
    }
}

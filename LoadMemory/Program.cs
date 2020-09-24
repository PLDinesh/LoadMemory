using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Numerics;

namespace LoadMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guid> oList = new List<Guid>();
            List<string> oGuidList = new List<string>();
            List<string> SecondList = new List<string>();
            List<string> ThirdList = new List<string>();
            List<string> FourthList = new List<string>();
            List<string> FifthList = new List<string>();

            string DefaultLoop = ConfigurationManager.AppSettings["DefaultLoop"];
            UInt64 ParsedValue = 100000;
            if(!string.IsNullOrEmpty(DefaultLoop))
            {
                UInt64.TryParse(DefaultLoop, out ParsedValue);
            }

            for (BigInteger i = 0; i < ParsedValue; i++)
            {
                Guid guid = Guid.NewGuid();

                
                oList.Add(guid);
                oGuidList.Add(guid.ToString());
                SecondList.Add(guid.ToString());
                ThirdList.Add(guid.ToString());
                FourthList.Add(guid.ToString());
                FifthList.Add(guid.ToString());
                oGuidList.Add(guid.ToString());
                oGuidList.Add(guid.ToString());
                SecondList.Add(guid.ToString());
                ThirdList.Add(guid.ToString());
                FourthList.Add(guid.ToString());
                FifthList.Add(guid.ToString());
                oGuidList.Add(guid.ToString());
                oGuidList.Add(guid.ToString());
                SecondList.Add(guid.ToString());
                ThirdList.Add(guid.ToString());
                FourthList.Add(guid.ToString());
                FifthList.Add(guid.ToString());
                oGuidList.Add(guid.ToString());
                oGuidList.Add(guid.ToString());
                SecondList.Add(guid.ToString());
                ThirdList.Add(guid.ToString());
                FourthList.Add(guid.ToString());
                FifthList.Add(guid.ToString());
                oGuidList.Add(guid.ToString());
            }

            foreach (string x in oGuidList)
            {
               // Console.WriteLine("test - {0}", x);
            }

            Process currentProcess = Process.GetCurrentProcess();
            long usedMemory = currentProcess.PrivateMemorySize64;
            Console.WriteLine("Currently using .. {0} bytes ",usedMemory );

            Console.WriteLine("Press [enter] to close the program");
            Console.ReadLine();

        }
    }
}

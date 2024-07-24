using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSolidPrinciples.ISP.Initial;
public class HPLaserJetPrinter : IPrinterTasks
{
    public void Fax(string FaxContent)
    {
        Console.WriteLine("Fax Done");
    }

    public void Print(string PrintContent)
    {
        Console.WriteLine("Print Done");
    }

    public void PrintDuplex(string PrintDuplexContent)
    {
        Console.WriteLine("Print Duplex Done");
    }

    public void Scan(string ScanContent)
    {
        Console.WriteLine("Scan Done");
    }
}

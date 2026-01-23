using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// 3
namespace Refactoring101.ShortgunSurgeryEasy
{
    public class ShotgunA
    {
        public void PrintReportA()
        {
            string owner = "Johny Black";
            Console.WriteLine("Owner : " + owner);
        }
    }
    public class ShotgunB
    {
        public void PrintReportB()
        {
            string owner = "Johny Black";
            Console.WriteLine("Signer : " + owner);
        }
    }
}

public class Constant
{
    public const string Owner = "Johny Black";
}
public class ShotgunA
{
    public void PrintReportA()
    {
        Console.WriteLine("Owner : " + Constant.Owner);
    }
}
public class ShotgunB
{
    public void PrintReportB()
    {
        Console.WriteLine("Signer : " + Constant.Owner);
    }
}
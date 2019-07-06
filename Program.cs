using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Package box1 = new Package(1, 42, 69, 2.5, "normal");
            box1.Collected();

            PackageViewer packageViewer1 = new PackageViewer(box1);
            packageViewer1.ShowText();

            Package box2 = new Package(2, 300, 9001, 30, "fast");

            PackageViewer packageViewer2 = new PackageViewer(box2);
            packageViewer2.ShowText();
        
        }
    }
}

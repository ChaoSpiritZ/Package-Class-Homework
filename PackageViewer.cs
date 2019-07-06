using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Homework
{
    class PackageViewer
    {
        private Package _box;

        public PackageViewer(Package box)
        {
            _box = box;
        }

        public void ShowText()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Package #{0} will be collected from customer #{1}, and will cost {2:c}", _box.PackageNum, _box.SenderNum, _box.CalcPrice());
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            if (_box.Delivered() == true)
            {
                Console.WriteLine("Package #{0} has successfully been delivered to customer #{1}", _box.PackageNum, _box.RecieverNum);
            }
            else
            {
                Console.WriteLine("Package #{0} has failed reaching customer #{1}", _box.PackageNum, _box.RecieverNum);
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");
        }


    }
}

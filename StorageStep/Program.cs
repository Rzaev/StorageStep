using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageStep
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage storage1 = new HDD()
            {
                Name = "Hdd",
                Model = "XXX"
            };

            //storage1.Print();
            //try
            //{
            //    Console.WriteLine(storage1.CopyData(2));
            //}
            //catch (NoStorage ex)
            //{
            //    ex.Show();
            //}
            //storage1.Print();

            Storage storage2 = new Flash()
            {
                Name = "Flash",
                Model = "YYY"
            };
            //storage2.Print();
            //try
            //{
            //    Console.WriteLine(storage2.CopyData(2));
            //}
            //catch (NoStorage ex)
            //{
            //    ex.Show();
            //}
            //storage2.Print();

            Storage storage3 = new DVD
            {
                Name = "DVD",
                Model = "YYY"
            };

            storage3.Print();
            try
            {
                Console.WriteLine(storage3.CopyData(2));
            }
            catch (NoStorage ex)
            {
                ex.Show();
            }
            storage3.Print();
        }
    }
}


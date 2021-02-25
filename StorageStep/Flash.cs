using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageStep
{
    class Flash : Storage
    {
        public double Speed { get; set; } = 5;
        public double Memory { get; set; } = 5;
        private double _free = 5;


        public double MediaTipininolcusu()
        {
            return Memory;
        }

        public override double CopyData(double data)
        {
            if (data > _free)
            {
                throw new NoStorage("We dont have enough memory", DateTime.Now, 25, "Flash.cs");
            }
            else
            {
                _free = _free - data;
                return data / Speed;
            }

        }

        public override double FreeMemory()
        {
            return _free;
        }



        public override void Print()
        {
            Console.WriteLine($"Memory:{Memory}");
            Console.WriteLine($"Speed(Data per second):{Speed}");
            Console.WriteLine($"Free Memory:{FreeMemory()}");
        }
    }
}


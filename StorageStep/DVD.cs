using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageStep
{
    class DVD : Storage
    {
        public double Speed { get; set; } = 1;
        public double Memory { get; set; } = 10;
        private double _free = 10;



        public double GetTime()
        {
            return Memory / Speed;
        }

        public double MediaTipininolcusu()
        {
            return Memory;
        }

        public override double CopyData(double data)
        {
            if (data > _free)
            {
                throw new NoStorage("We dont have enought memory", DateTime.Now, 31, "DVD.cs");
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

        public double MemoryPerSecond()
        {
            return Speed;
        }

        public override void Print()
        {
            Console.WriteLine($"Memory:{Memory}");
            Console.WriteLine($"Speed:{Speed}");
            Console.WriteLine($"Time:{GetTime()}");
            Console.WriteLine($"Free Memory:{FreeMemory()}");
        }
    }
}


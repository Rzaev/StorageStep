using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageStep
{
    abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }
        //public double CopyPerSecond { get; set; }
        //public double TimeToCopyAllData { get; set; }

        // public abstract double MaxSize(); //her saniyede kocurulen datani
        //butun datani kocurmek ucun lazim olan zamana vururuq
        public abstract double CopyData(double data); //time qaytarir
        public abstract double FreeMemory();
        public abstract void Print();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4_1302200016
{
    internal class DataGeneric<G>
    {
        private G data;
        public DataGeneric(G data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah : " + this.data);
        }
    }
}

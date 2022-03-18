using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4_1302200016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<String> dataGeneric = new DataGeneric<string>("1302200016");
            dataGeneric.PrintData();
            HaloGeneric<String> haloGeneric = new HaloGeneric<string>();
            haloGeneric.SapaUser("Iqbal");

            // Program akan menampilkan sebuah pesan sapaan dengan Nama dan NIM
        }
    }
}

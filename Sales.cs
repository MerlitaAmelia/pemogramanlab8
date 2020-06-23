using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab8pemograman.ClassInduk;
namespace lab8pemograman.ClassAnak
{
    class Sales : Karyawan
    {
        public int JumlahPenjualan { get; set; }
        public int Komisi { get; set; }

        public override int Gaji() => JumlahPenjualan * Komisi;
        
        
    }
}

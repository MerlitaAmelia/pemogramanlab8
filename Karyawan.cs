using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab8pemograman.ClassAnak;

namespace lab8pemograman.ClassInduk
{
    public abstract class Karyawan
    { 
        public string Nama { get; set; }
        public string Nik { get; set; }

        public abstract int Gaji();

    }
}

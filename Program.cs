using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab8pemograman.ClassAnak;

namespace lab8pemograman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (pertemuan 11) - Polymorpsim, Abstraction & Collections";

            // membuat objek untuk semua karyawan

            KaryawanTetap KaryawanTetap = new KaryawanTetap();
            KaryawanTetap.Nik = "987-876-765";
            KaryawanTetap.Nama = "Merlita Amelia";
            KaryawanTetap.GajiBulanan = 5000000;

            KaryawanHarian KaryawanHarian = new KaryawanHarian();
            KaryawanHarian.Nik = "654-543-432";
            KaryawanHarian.Nama = "Amelia Merlita";
            KaryawanHarian.JumlahJamKerja =7;
            KaryawanHarian.UpahPerjam = 15000;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BasicProject_1
{
    public class Ogrenci
    {
        private string isim;
        private string soyIsim;
        private int vize1, vize2, final, ogrenciNo;
        private string okulIsmi;


        public Ogrenci(string _isim, string _soyIsim, string _okulIsmi, int _vize1, int _vize2, int _final, int _ogrenciNo)
        {
            isim = _isim;
            soyIsim = _soyIsim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            ogrenciNo = _ogrenciNo;
            okulIsmi = _okulIsmi;

        }
        public void ogrenciBiligileriniGoster()
        {
            Console.WriteLine("Öğrenci biligileri = " + isim + soyIsim+ogrenciNo+okulIsmi);
        }
        public int ogrenciOrtalamasiBul()
        {
            int ort = (vize1 * 20 + vize2 * 20 + final * 60) / 100;
            

            return ort;
        }
        public void okUlIsmi()
        {
            
            Console.WriteLine(isim +" "+ soyIsim +"şahsının okul ismi = " + okulIsmi);
        }

    }
}

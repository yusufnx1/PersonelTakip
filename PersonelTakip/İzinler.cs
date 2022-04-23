using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip
{
    public class İzinler:Personeller
    {
        private int _İzinID;
        private DateTime _İzinBaslangic;
        private DateTime _izinBitis;
        private DateTime _Tarih;
        private string _Aciklama;

        public int İzinID { get => _İzinID; set => _İzinID = value; }
        public DateTime İzinBaslangic { get => _İzinBaslangic; set => _İzinBaslangic = value; }
        public DateTime IzinBitis { get => _izinBitis; set => _izinBitis = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public string Aciklama1 { get => _Aciklama; set => _Aciklama = value; }
    }
}

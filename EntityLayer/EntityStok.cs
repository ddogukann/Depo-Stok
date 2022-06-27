using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityStok
    {
        private int id;
        private string urunmarka;
        private string urunmodel;
        private int urunmiktar;
        private string urunbirim;
        private string kategori;
        private string aciklama;


        public int Id { get => id; set => id = value; }
        public string Urunmarka { get => urunmarka; set => urunmarka = value; }
        public string Urunmodel { get => urunmodel; set => urunmodel = value; }
        public int Urunmiktar { get => urunmiktar; set => urunmiktar = value; }

        public string Urunbirim { get => urunbirim; set => urunbirim = value; }
        public string Kategori { get => kategori; set => kategori = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }
        
    }
    public class EntityDate
    {
        private string model;
        private string giristarihi;
        private string cikistarihi;
        private string degisenmiktar;
        private string cikanbirim;

        public string Model { get => model; set => model = value; }
        public string Giristarihi { get => giristarihi; set => giristarihi = value; }
        public string Cikistarihi { get => cikistarihi; set => cikistarihi = value; }
        public string Degisenmiktar { get => degisenmiktar; set => degisenmiktar = value; }
        public string Cikanbirim { get => cikanbirim; set => cikanbirim = value; }
    }
}

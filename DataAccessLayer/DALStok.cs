using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace DataAccessLayer
{
    public class DALStok
    {
        public static List<EntityStok> stoklistesi()
        {
            
            List<EntityStok> degerler = new List<EntityStok>();
            OleDbCommand komut1 = new OleDbCommand("Select * from tblstok order by urunmarka", Baglanti.bgl);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            OleDbDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityStok ent = new EntityStok();
                ent.Id = int.Parse(dr["id"].ToString());
                ent.Urunmarka = dr["urunmarka"].ToString();
                ent.Urunmodel = dr["urunmodel"].ToString();
                ent.Urunmiktar = int.Parse(dr["urunmiktar"].ToString());
                ent.Urunbirim = dr["birim"].ToString();
                ent.Kategori = dr["kategori"].ToString();
                ent.Aciklama= dr["aciklama"].ToString();


                degerler.Add(ent);
            }
            dr.Close();
            return degerler;

        }
        public static List<EntityDate> stoktarih()
        {

            List<EntityDate> degerler1 = new List<EntityDate>();
            OleDbCommand komut1 = new OleDbCommand("Select * from tbldate", Baglanti.bgl);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            OleDbDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityDate ent = new EntityDate();
                ent.Model = dr["model"].ToString();
                ent.Giristarihi = dr["giristarihi"].ToString();
                ent.Cikistarihi = dr["cikistarihi"].ToString();
                ent.Degisenmiktar = dr["degisenmiktar"].ToString();


                degerler1.Add(ent);
            }
            dr.Close();
            return degerler1;

        }
        public static int StokEkle(EntityStok p)
        {
            OleDbCommand komut2 = new OleDbCommand("insert into tblstok(urunmarka,urunmodel,urunmiktar,birim,kategori,aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6)", Baglanti.bgl);
            
            if (komut2.Connection.State != System.Data.ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Urunmarka);
            komut2.Parameters.AddWithValue("@p2", p.Urunmodel);
            komut2.Parameters.AddWithValue("@p3", p.Urunmiktar);
            komut2.Parameters.AddWithValue("@p6", p.Urunbirim);
            komut2.Parameters.AddWithValue("@p4", p.Kategori);
            komut2.Parameters.AddWithValue("@p5", p.Aciklama);

            return komut2.ExecuteNonQuery();
            

        }
        public static bool Stoksil(int p)
        {
            OleDbCommand komut3 = new OleDbCommand("Delete from tblstok where id=@p1", Baglanti.bgl);
            if (komut3.Connection.State != System.Data.ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool StokGuncelle(EntityStok ent)
        {
            OleDbCommand komut4= new OleDbCommand("Update tblstok set urunmarka=@p1,urunmodel=@p2, birim=@p3 where id=@p4",Baglanti.bgl);
            
            if (komut4.Connection.State != System.Data.ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", ent.Urunmarka);
            komut4.Parameters.AddWithValue("@p2", ent.Urunmodel);
            komut4.Parameters.AddWithValue("@p3", ent.Urunbirim);
            
            komut4.Parameters.AddWithValue("@p4", ent.Id);
            
            return komut4.ExecuteNonQuery() > 0;
        }
    }
}

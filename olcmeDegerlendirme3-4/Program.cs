using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniteDegerlendirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televizyon televizyon = new Televizyon();
            televizyon.EkranBoyutu = 108;
            televizyon.GoruntuTeknolojisi = "UHD+";
            televizyon.SesSeviyesi = 100;
            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Cpu = "AMD Ryzen 5700G";
            bilgisayar.RamBellekKapasitesi = 128;
            bilgisayar.HdKapasitesi = 1024;
            Console.WriteLine("Televizyonun.tü Teknolojisi: {0} ", televizyon.GoruntuTeknolojisi);
            Console.WriteLine("Ekran Boyutu: {0}", televizyon.EkranBoyutu);
            Console.WriteLine("Ses Seviyesi: {0}", televizyon.SesSeviyesi);
            Console.WriteLine("============================================");
            Console.WriteLine("Bilgisayarın; Gpu: {0} ", bilgisayar.Cpu);
            Console.WriteLine("Ram Kapasitesi: {0} ", bilgisayar.RamBellekKapasitesi);
            Console.WriteLine("Hd Kapasitesi: {0} ", bilgisayar.HdKapasitesi);
            Console.WriteLine("============================================");
            televizyon.GucuAc();
            televizyon.KanalDegistir();
            televizyon.SesSeviyesiGoster();
            televizyon.GucuKapat();
        }
    }
    public class Televizyon
    {
        public uint SesSeviyesi { get; set; }
        public uint EkranBoyutu { get; set; }
        public string GoruntuTeknolojisi { get; set; }
        public void GucuAc()
        {
            Console.WriteLine("Televizyon Açıldı");
        }
        public void GucuKapat()
        {
            Console.WriteLine("Televizyon Kapatıldı");
        }
        public void KanalDegistir()
        {
            Console.WriteLine("Televizyonun Kanalı Degiştirildi");
        }
        public void SesSeviyesiGoster()
        {
            Console.WriteLine("Televizyonun Ses Seviyesi Gösterildi");
        }

    }
    public class Bilgisayar
    {
        public ushort RamBellekKapasitesi { get; set; }
        public string Cpu { get; set; }
        public uint HdKapasitesi { get; set; }
    }
}
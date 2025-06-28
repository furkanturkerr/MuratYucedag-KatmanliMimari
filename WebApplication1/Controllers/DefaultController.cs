using Microsoft.AspNetCore.Mvc;
using WebApplication1.Ornekler;

namespace WebApplication1.Controllers;

public class DefaultController : Controller
{
    void Mesajlar()
    {
        ViewBag.Mesaj = "Merhaba";
    }

    void MesajListesi(string p)
    {
        ViewBag.v = p;
    }

    void Kullanıcı(string kullanici)
    {
        ViewBag.kullanici = kullanici;
    }

    int topla()
    {
        int s1 = 10;
        int s2 = 20;
        int sonuc = s1 + s2;
        return sonuc;
    }
    public IActionResult Index()
    {
        Mesajlar();
        MesajListesi("Merhaba");
        Kullanıcı("Murat123");
        return View();
    }

    public IActionResult Urunler()
    {
        ViewBag.urun = topla();
        Kullanıcı("Ahmet123");
        return View();
    }
    
    public IActionResult Deneme()
    {
        Sehirler sehirler = new Sehirler();
        
        sehirler.Ad = "Ankara";
        sehirler.Id = "1";
        sehirler.Nufus = 1000000;
        sehirler.Ulke = "Türkiye";
        sehirler.Renk1 = "Mavi";
        sehirler.Renk2 = "Sarı";
        
        ViewBag.v3 = sehirler.Ad;
        ViewBag.v1 = sehirler.Id;
        ViewBag.v4 = sehirler.Nufus;
        ViewBag.v2 = sehirler.Ulke;
        ViewBag.v5 = sehirler.Renk1;
        ViewBag.v6 = sehirler.Renk2;
        ViewBag.v7 = sehirler.Renk3;    
        
        sehirler.Ad = "İstanbul";
        sehirler.Id = "2";
        sehirler.Nufus = 20000000;
        sehirler.Ulke = "Türkiye";
        sehirler.Renk1 = "Kırmızı";
        sehirler.Renk2 = "Sarı";
        
        ViewBag.z3 = sehirler.Ad;
        ViewBag.z1 = sehirler.Id;
        ViewBag.z4 = sehirler.Nufus;
        ViewBag.z2 = sehirler.Ulke;
        ViewBag.z5 = sehirler.Renk1;
        ViewBag.z6 = sehirler.Renk2;
        
        
        return View();
    }
}
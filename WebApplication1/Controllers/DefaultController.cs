using Microsoft.AspNetCore.Mvc;

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
}
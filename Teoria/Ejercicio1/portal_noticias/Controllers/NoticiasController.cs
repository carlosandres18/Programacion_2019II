using Microsoft.AspNetCore.Mvc;

namespace portal_noticias.Controllers
{
    public class NoticiasController : Controller
    {
        public IActionResult UltimasNoticias(){
            return View();
        }
        public IActionResult NoticiasPorCategoria(){
            return View();
        }
    }
}
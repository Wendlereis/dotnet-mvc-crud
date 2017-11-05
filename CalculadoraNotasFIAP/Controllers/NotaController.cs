using CalculadoraNotasFIAP.Models;
using CalculadoraNotasFIAP.Repository;
using System.Web.Mvc;

namespace CalculadoraNotasFIAP.Controllers
{
    public class NotaController : Controller
    {
        public ActionResult Index()
        {
            return View(NotaRepository.Listar());
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Nota nota)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            nota.Media = (nota.Nac * 2 + nota.Am * 3 + nota.Ps * 5) / 10;

            NotaRepository.Inserir(nota);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(string rm)
        {
            return View(NotaRepository.ListarPorRm(rm));
        }

        [HttpPost]
        public ActionResult Editar(Nota nota)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            nota.Media = (nota.Nac * 2 + nota.Am * 3 + nota.Ps * 5) / 10;

            NotaRepository.Editar(nota);

            return RedirectToAction("Index");
        }

        public ActionResult Deletar(string rm)
        {
            NotaRepository.Deletar(rm);

            return RedirectToAction("Index");
        }
    }
}
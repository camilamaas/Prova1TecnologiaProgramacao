//Camila Maas
using Prova1.Models;
using System.Linq;
using System.Web.Mvc;

namespace Prova1.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {
        private ApplicationDbContext _context;

        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: TipoDeAssociacao
        public ActionResult Index()
        {
            var tiposDeassociacao = _context.TiposDeAssociacao.ToList();
            return View(tiposDeassociacao);
        }

        public ActionResult Details(int id)
        {
            var tipoDeAssociacao = _context.TiposDeAssociacao.SingleOrDefault(t => t.Id == id);
            if (tipoDeAssociacao == null)
            {
                return HttpNotFound();
            }

            return View(tipoDeAssociacao);
        }


    }
}
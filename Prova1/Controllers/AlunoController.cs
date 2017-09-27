//Camila Maas
using Prova1.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Prova1.Controllers
{
    public class AlunoController : Controller
    {

        private ApplicationDbContext _context;

        public AlunoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Aluno
        public ActionResult Index()
        {
            var alunos = _context.Alunos.Include(f => f.Faixa).Include(t => t.TipoDeAssociacao).ToList();
            return View(alunos);
        }

        public ActionResult Details(int id)
        {
            var aluno = _context.Alunos.Include(f => f.Faixa).Include(t => t.TipoDeAssociacao).SingleOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }
    }
}
using LoginAccessSystem.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAccessSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //We need to access the DB via EF Core, so add:-

        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        //Create Signup Actions :-
        // GET: Signup form :-

        public IActionResult Signup()
        {
            return View();
        }

        // POST: Handle Signup :-
        [HttpPost]
        public async Task<IActionResult> Signup(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            return View(user);
        }

        //Create Login Actions :-


        // GET: Login form :-
        public IActionResult Login()
        {
            return View();
        }

        // POST: Handle Login :-
        [HttpPost]
        public IActionResult Login(User user)
        {
            var checkUser = _context.Users

        }
    }
}

using InternRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternRegistration.Controllers
{
    public class PageController : Controller
    {
        private readonly registrationsDbContext _dbContext;

        public PageController(registrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Intern Application)
        {

            if (ModelState.IsValid)
            {
                _dbContext.Interns.Add(Application);       
                _dbContext.SaveChanges();      
                return RedirectToAction("List");
            }
            else
            {

                return View(Application);
            }
        }



        [HttpGet]
        public IActionResult List()
        {
            var interns = _dbContext.Interns.ToList(); 
            return View(interns);
        }
        [HttpPost]


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var intern = _dbContext.Interns.Find(id);

            if (intern == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Intern updatedIntern)
        {
            if (ModelState.IsValid)
            {
                var existingIntern = _dbContext.Interns.Find(updatedIntern.Id);

                if (existingIntern == null)
                {
                    return NotFound();
                }

                existingIntern.Name = updatedIntern.Name;
                existingIntern.Email = updatedIntern.Email;
                existingIntern.Phone = updatedIntern.Phone;
                existingIntern.Address = updatedIntern.Address;


                _dbContext.SaveChanges();

                return RedirectToAction("List");
            }

            return View(updatedIntern);
        }




        [HttpGet]
        public IActionResult Delete(int id)
        {
            var intern = _dbContext.Interns.Find(id);

            if (intern == null)
            {
                return NotFound(); // Return a 404 error if the intern is not found
            }
            return View(intern);
        }

        [HttpPost]
        public IActionResult Deleted(int id)
        {
            var intern = _dbContext.Interns.Find(id);

            if (intern == null)
            {
                return NotFound();
            }

            _dbContext.Interns.Remove(intern);
            _dbContext.SaveChanges();

            return RedirectToAction("List");
        }

    }
}

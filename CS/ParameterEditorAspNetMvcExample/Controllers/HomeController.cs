using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParameterEditorAspNetMvcExample.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Designer() {
            Models.ReportDesignerModel model = new Models.ReportDesignerModel();
            return View(model);
        }

        public ActionResult Viewer() {
            return View();
        }
        // Create an Employee list and serialize it to JSON.
        public ActionResult ListEmployees()
        {
            var employees = new System.Collections.Generic.List<Employee>();
            employees.Add(new Employee()
            {
                id = 2,
                parentId = 0,
                name = "Andrew Fuller",
                title = "Vice President"
            });
            employees.Add(new Employee()
            {
                id = 1,
                parentId = 5,
                name = "Nancy Davolio",
                title = "Sales Representative"
            });
            employees.Add(new Employee()
            {
                id = 3,
                parentId = 5,
                name = "Janet Leverling",
                title = "Sales Representative"
            });
            employees.Add(new Employee()
            {
                id = 4,
                parentId = 5,
                name = "Margaret Peacock",
                title = "Sales Representative"
            });
            employees.Add(new Employee()
            {
                id = 5,
                parentId = 2,
                name = "Steven Buchanan",
                title = "Sales Manager"
            });
            return Json(employees, JsonRequestBehavior.AllowGet);
        }
    }
}

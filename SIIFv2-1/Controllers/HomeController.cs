using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIIFv2Model;
using System.Data.Entity;
using System.Runtime.Serialization;

namespace SIIFv2_1.Controllers
{
    public class HomeController : Controller
    {
        private Banco banco = new Banco();

        public ActionResult Index()
        {
            string usr = User.Identity.Name.ToString();
            ViewBag.NombreUsuario = usr.Substring((usr.IndexOf('\\') + 1), (usr.Length - (usr.IndexOf('\\') + 1)));

            //List<Banco> bancos = banco.Listar();// = new List<Banco>();

            //bancos = banco.Listar();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DepositosNoIdentificados()
        {

            var flavorItems = new List<SelectListItem>() {
            new SelectListItem() { Value = "1", Text = "Chocolate" },
            new SelectListItem() { Value = "2", Text = "Double Chocolate" },
            new SelectListItem() { Value = "3", Text = "Chocolate Chip" },
            new SelectListItem() { Value = "4", Text = "Peanut Butter & Chocolate" },
        };

            ViewBag.FlavorItems = flavorItems;

            //using(var ctx = new SIIFv2Model.SPEIEntities)
            //{
                
            //}


            return View();
        }
    }
}
using Model.Entity;
using Model.Neg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrjSistemaFinanceiro.Controllers
{
    public class VendedorController : Controller
    {
        VendedorNeg objVendedorNeg;
        
        public VendedorController()
        {
            objVendedorNeg = new VendedorNeg(); 
        }

        public ActionResult Index()
        {
            List<Vendedor> lista = objVendedorNeg.findAll();
            return View(lista);
        }
    }
}
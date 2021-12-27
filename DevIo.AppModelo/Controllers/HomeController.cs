using DevIO.UI.Site.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IPedidoRepository _pedido;


        //public HomeController(IPedidoRepository pedido)
        //{
        //    _pedido = pedido;
        //}

       

        public IActionResult Index([FromServices] IPedidoRepository _pedido)
        {
           
            return View();
        }
    }
}

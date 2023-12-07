using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PrimeiroMVC.Controllers
{
    public class OlaMundoController : Controller
    {
        public IActionResult Index()
        //as rotas do MVC indicam que este index é chamado automaticamente quando eu acessar a URL/OlaMundo
        //public string Index()
        {
            return View();
            //return "Oi mundo!";
        }

        public string Welcome(int id, string nome)
//as rotas do MVC indicam que este index é chamado automaticamente quando eu acessar a URL/OlaMundo/Welcome
        {
            return HtmlEncoder.Default.Encode("OI " + nome+" ID: "+id);
           // return "Estou no método welcome";
        }


        public IActionResult MostrarMensagem(string nome, int qtd)
        {
            ViewData["Nome"] = nome;
            ViewData["Qtd"] = qtd;

            return View();
        }
    }
}

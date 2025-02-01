using Microsoft.AspNetCore.Mvc;  // Importa o namespace necessário para trabalhar com o MVC no ASP.NET Core

namespace MeuSite.Controllers  // Define o namespace para o controlador
{
    public class HomeController : Controller  // Define o controlador "HomeController" que herda de "Controller"
    {
        public IActionResult Index()  // Ação para a página inicial
        {
            return View();  // Retorna a view (página) correspondente a esta ação
        }

        public IActionResult Projetos()  // Ação para a página de projetos
        {
            return View();  // Retorna a view (página) correspondente a esta ação
        }

        public IActionResult Sobre()  // Ação para a página "Sobre"
        {
            return View();  // Retorna a view (página) correspondente a esta ação
        }

        public IActionResult Contato()  // Ação para a página de contato
        {
            return View();  // Retorna a view (página) correspondente a esta ação
        }
    }
}

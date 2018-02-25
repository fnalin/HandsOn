using Fansoft.Store.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fansoft.Store.UI.Controllers
{
    public class ProdutosController:Controller
    {
        public IActionResult Index()
        {

            var produtos = new List<Produto>() {
                new Produto { Id= 1, Nome = "Picanha", Valor=80.99M, TipoProduto="Alimento"},
                new Produto { Id= 2, Nome = "Iogurte", Valor=10.99M, TipoProduto="Alimento"},
                new Produto { Id= 3, Nome = "Tênis", Valor=180.99M, TipoProduto="Vestuário"},
                new Produto { Id= 4, Nome = "Camisa", Valor=50.99M, TipoProduto="Vestuário"},
                new Produto { Id= 5, Nome = "Escova de dente", Valor=20.99M, TipoProduto="Higiene"},
                new Produto { Id= 6, Nome = "Pasta de dente", Valor=10.99M, TipoProduto="Higiene"},
            };
            

            return View(produtos);
        }
    }
}

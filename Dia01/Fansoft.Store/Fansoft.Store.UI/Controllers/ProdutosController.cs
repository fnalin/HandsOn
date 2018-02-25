using Fansoft.Store.UI.Data;
using Fansoft.Store.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fansoft.Store.UI.Controllers
{
    public class ProdutosController : Controller
    {
        private FanSoftStoreDataContext _ctx = new FanSoftStoreDataContext();

        public IActionResult Index()
        {
            var produtos =
                _ctx.Produtos
                    .Include(t => t.TipoProduto)
                .ToList();

            return View(produtos);
        }

        public IActionResult AddEdit(int? id)
        {
            var tipos = _ctx.TipoProdutos.ToList().Select(t => new SelectListItem { Text = t.Nome, Value = t.Id.ToString() });
            ViewBag.Tipos = tipos;

            Produto produto;
            if (id != null)
            {
                produto = _ctx.Produtos.Find(id);
            }
            else
            {
                produto = new Produto();
            }

            return View(produto);
        }

        [HttpPost]
        public IActionResult AddEdit(Produto produto)
        {
            if (ModelState.IsValid)
            {
                if (produto.Id == 0)
                {
                    _ctx.Produtos.Add(produto);
                }
                else
                {
                    _ctx.Update(produto);
                }
                _ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(produto);
        }


        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }

    }
}

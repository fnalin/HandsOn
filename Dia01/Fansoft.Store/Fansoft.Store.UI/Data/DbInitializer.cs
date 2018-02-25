using Fansoft.Store.UI.Models;
using System.Collections.Generic;
using System.Linq;

namespace Fansoft.Store.UI.Data
{
    public class DbInitializer
    {

        public static void Init(FanSoftStoreDataContext ctx)
        {
            ctx.Database.EnsureCreated();

            if (!ctx.Produtos.Any())
            {
                var alimento = new TipoProduto {Nome= "Alimento" };
                var higiene = new TipoProduto {Nome= "Higiene" };
                var vestuario = new TipoProduto {Nome= "Vestuario" };


                ctx.Produtos.AddRange(
                    new List<Produto>() {
                        new Produto { Nome = "Picanha", Valor=80.99M, TipoProduto=alimento},
                        new Produto { Nome = "Iogurte", Valor=10.99M, TipoProduto=alimento},
                        new Produto { Nome = "Tênis", Valor=180.99M, TipoProduto=vestuario},
                        new Produto { Nome = "Camisa", Valor=50.99M, TipoProduto=vestuario},
                        new Produto { Nome = "Escova de dente", Valor=20.99M, TipoProduto=higiene},
                        new Produto { Nome = "Pasta de dente", Valor=10.99M, TipoProduto=higiene},
                    }
                );

                ctx.SaveChanges();


            }

        }


    }
}

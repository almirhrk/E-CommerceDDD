using Domain.Interfaces.InterfaceProduct;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    class RepositoryProduct : RepositoryGenerics<Produto>, IProduct
    {
        public Task<List<Produto>> ListarProdutos(Expression<Func<Produto, bool>> exProduto)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> ListarProdutosCarrinhoUsuario(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> ListarProdutosUsuario(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> ListarProdutosVendidos(string userId, string filtro)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> ObterProdutoCarrinho(int idProdutoCarrinho)
        {
            throw new NotImplementedException();
        }
    }
}

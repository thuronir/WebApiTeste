using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiWaProject.Data;
using WebApiWaProject.Models;

namespace WebApiWaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoPedidosController : ControllerBase
    {
        private readonly WaApiContext _context;

        public ProdutoPedidosController(WaApiContext context)
        {
            _context = context;
        }


        // GET: api/ProdutoPedidos/5
        [HttpGet("{Token}")]
        public async Task<IEnumerable<ProdutoPedido>> GetProdutoPedido(string Token)
        {
            if (Token == "6(qk~Tvapyof}y)M0%HXeoGSkx%v@F=g&en6<|We0jB2X.3@=avKUEW;*qIX*;1DB673CAFF6C3B635A14ADF98439E")
            {
                var produtoPedido = await  _context.ProdutoPedidos.Include(p => p.Pedido).Include(p => p.Pedido.Equipe).Include(p => p.Produto).OrderBy(m => m.Pedido.DataCriacao).ToListAsync();
                if (produtoPedido == null)
                {
                    return null;
                }
                return produtoPedido;
            }
            else
            {
                return null;
            }

        }
    }
}

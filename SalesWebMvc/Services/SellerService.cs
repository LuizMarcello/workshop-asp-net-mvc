using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //Injeção de dependências desta classe/serviço com a classe SalesWebMvcContext
        //Quando um 'SellerService' for criado, automaticamente ele vai receber uma
        //instância do Context também.
        private readonly SalesWebMvcContext _context;

        //Construtor:
        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}



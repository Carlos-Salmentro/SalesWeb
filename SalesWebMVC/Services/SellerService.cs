using SalesWebMVC.Data;
using System.Linq;
using System.Collections.Generic;
using SalesWebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }
                

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller s1)
        {
            _context.Seller.Add(s1);
            _context.SaveChanges();
        }

    }
}

using System;
using SalesWebMVC.Model;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enuns;
using System.Linq;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departament.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Departament d1 = new Departament(1, "Electronics");
            Departament d2 = new Departament(2, "Fashion");
            Departament d3 = new Departament(3, "Books");

            Seller s1 = new Seller(1, "Robert Brown", "robertb@gmail.com", new DateTime(1998, 06, 15), 1000.00, d1);
            Seller s2 = new Seller(2, "Alex Green", "alexg@gmail.com", new DateTime(1995, 02, 25), 2500.00, d2);
            Seller s3 = new Seller(3, "Joana White", "joanaw@gmail.com", new DateTime(1997, 12, 20), 2700.00, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2022, 06, 29), 22000.00, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2022, 06, 28), 2500.00, SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 06, 27), 3000.00, SaleStatus.Canceled, s3);

            _context.Departament.AddRange(d1, d2, d3);
            _context.Seller.AddRange(s1, s2, s3);
            _context.SalesRecord.AddRange(r1, r2, r3);

            _context.SaveChanges();
        }
    }
}

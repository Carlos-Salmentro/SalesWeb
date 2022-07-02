using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public int DepartamentId { get; set; }
        ICollection<SalesRecord> Salles = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller (int id, string name, string email, DateTime birthdate, double baseSallary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthdate;
            BaseSalary = baseSallary;
            Departament = departament;
        }

        public void AddSeles(SalesRecord sr)
        {
            Salles.Add(sr);
        }
       
        public void RemoveSeles(SalesRecord sr)
        {
            Salles.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Salles.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}

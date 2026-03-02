using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Classes.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(150)]
        public string FullName { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Phone]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        // Relație One-to-Many: Un client poate avea mai multe vânzări
        public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
        public List<Customer> GetAllCustomers()
        {
            using (var db = new SmartStockContext())
            {
                return db.Customers
                    .AsNoTracking() // Îmbunătățește performanța la citire
                    .OrderBy(c => c.FullName)
                    .ToList();
            }
        }
        public void AddCustomer(Customer customer)
        {
            using (var db = new SmartStockContext())
            {
                db.Customers.Add(customer);
                db.SaveChanges(); // Conexiunea se închide automat după finalizarea tranzacției
            }
        }
        public List<Customer> SearchCustomers(string searchTerm)
        {
            using (var db = new SmartStockContext())
            {
                return db.Customers
                    .AsNoTracking()
                    .Where(c => c.FullName.Contains(searchTerm) ||
                                c.City.Contains(searchTerm) ||
                                c.Email.Contains(searchTerm))
                    .ToList();
            }
        }
    }
}

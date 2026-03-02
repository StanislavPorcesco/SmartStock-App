using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using SmartStock.Classes.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Classes.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public int ProductId { get; set; }

        // ENTITY_ID poate fi SupplierId sau CustomerId, depinde de context
        public int? EntityId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; } // "In", "Out", "Adjustment"

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        // Proprietăți de navigare
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public void RegisterTransaction(Transaction transaction)
        {
            using (var db = new SmartStockContext())
            {
                // 1. Salvăm tranzacția
                db.Transactions.Add(transaction);

                // 2. Căutăm produsul pentru a-i actualiza stocul
                var product = db.Products.Find(transaction.ProductId);
                if (product != null)
                {
                    if (transaction.Type == "In")
                        product.CurrentStock += transaction.Quantity;
                    else if (transaction.Type == "Out" || transaction.Type == "Adjustment")
                        product.CurrentStock -= transaction.Quantity;
                }

                db.SaveChanges(); // Ambele operațiuni sunt salvate într-o singură tranzacție DB
            }
        }
        public List<Transaction> GetProductHistory(int productId)
        {
            using (var db = new SmartStockContext())
            {
                return db.Transactions
                    .AsNoTracking()
                    .Include(t => t.User)
                    .Where(t => t.ProductId == productId)
                    .OrderByDescending(t => t.Date)
                    .ToList();
            }
        }
        public List<Transaction> GetAdjustmentReport()
        {
            using (var db = new SmartStockContext())
            {
                return db.Transactions
                    .AsNoTracking()
                    .Include(t => t.Product)
                    .Include(t => t.User)
                    .Where(t => t.Type == "Adjustment")
                    .ToList();
            }
        }
    }
}

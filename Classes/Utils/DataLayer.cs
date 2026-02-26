using SmartStock.Forms.AddForms;
using SmartStock.Forms.User_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Classes.Utils
{
    public class DataLayer
    {
        public static void PopulateSelector(ComboBox selector)
        {
            if (selector != null)
            {
                selector.Items.Clear();
                selector.Items.AddRange(new string[] { "Product", "Category", "Supplier", "Transaction", "Customer", "Sale", "ExternalFactor" });
            }
        }
    }
}

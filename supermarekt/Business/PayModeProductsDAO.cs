using Supermarker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker.Business
{
    internal class PayModeProductsDAO
    {
        private readonly Dictionary<int, PayModelProducts> PayModelProductsList;
        private static int payModelProductsSecuencial;

        public PayModeProductsDAO()
        {
            PayModelProductsList = new Dictionary<int, PayModelProducts>();
            payModelProductsSecuencial = 0;
        }

        public bool AddPayModelProduct(PayModelProducts payModelProduct)
        {
            try
            {
                payModelProduct.Id = ++payModelProductsSecuencial;
                PayModelProductsList.Add((int)payModelProduct.Id, payModelProduct);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        public bool RemovePayModelProduct(int id)
        {
            bool idExists = PayModelProductsList.ContainsKey(id);
            if (idExists)
            {
                PayModelProductsList.Remove(id);
                return true;
            }
            return false;
        }

        public PayModelProducts? GetPayModelProduct(int id)
        {
            bool idExists = PayModelProductsList.ContainsKey(id);
            if (idExists)
            {
                PayModelProducts payModelProduct = PayModelProductsList[id];
                return payModelProduct;
            }
            return null;
        }

        public bool UpdatePayModelProduct(int id, PayModelProducts payModelProduct)
        {
            bool idExists = PayModelProductsList.ContainsKey(id);
            if (idExists)
            {
                try
                {
                    PayModelProductsList[id] = payModelProduct;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;
        }

        public Dictionary<int, PayModelProducts> GetPayModelProductList()
        {
            return PayModelProductsList;
        }

        
    }
}
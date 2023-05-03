using Supermarker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker.Business
{
    internal class PayModeProvaidersDAO
    {
        private readonly Dictionary<int, PayModelProvaiders> PayModelProvaidersList;
        private static int payModelProvaidersSecuencial;

        public PayModeProvaidersDAO()
        {
            PayModelProvaidersList = new Dictionary<int, PayModelProvaiders>();
            payModelProvaidersSecuencial = 0;
        }

        public bool AddPayModelProduct(PayModelProvaiders payModelProvaiders)
        {
            try
            {
                payModelProvaiders.Id = ++payModelProvaidersSecuencial;
                PayModelProvaidersList.Add((int)payModelProvaiders.Id, payModelProvaiders);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        public bool RemovePayModelProduct(int id)
        {
            bool idExists = PayModelProvaidersList.ContainsKey(id);
            if (idExists)
            {
                PayModelProvaidersList.Remove(id);
                return true;
            }
            return false;
        }

        public PayModelProvaiders? GetPayModelProduct(int id)
        {
            bool idExists = PayModelProvaidersList.ContainsKey(id);
            if (idExists)
            {
                PayModelProvaiders payModelCategories = PayModelProvaidersList[id];
                return payModelCategories;
            }
            return null;
        }

        public bool UpdatePayModelProduct(int id, PayModelProvaiders payModelCategories)
        {
            bool idExists = PayModelProvaidersList.ContainsKey(id);
            if (idExists)
            {
                try
                {
                    PayModelProvaidersList[id] = payModelCategories;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;
        }

        public Dictionary<int, PayModelProvaiders> GetPayModelProvaidersList()
        {
            return PayModelProvaidersList;
        }


    }
}






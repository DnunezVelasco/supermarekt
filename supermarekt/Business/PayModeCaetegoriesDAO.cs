
using Supermarker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker.Business
{
    internal class PayModeCaetegoriesDAO
    {

        private readonly Dictionary<int, PayModelCategories> PayModelCategoriesList;
        private static int payModelCategoriesSecuencial;

        public PayModeCaetegoriesDAO()
        {
            PayModelCategoriesList = new Dictionary<int, PayModelCategories>();
            payModelCategoriesSecuencial = 0;
        }

        public bool AddPayModelProduct(PayModelCategories payModelCategories)
        {
            try
            {
                payModelCategories.Id = ++payModelCategoriesSecuencial;
                PayModelCategoriesList.Add((int)payModelCategories.Id, payModelCategories);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        public bool RemovePayModelProduct(int id)
        {
            bool idExists = PayModelCategoriesList.ContainsKey(id);
            if (idExists)
            {
                PayModelCategoriesList.Remove(id);
                return true;
            }
            return false;
        }

        public PayModelCategories? GetPayModelProduct(int id)
        {
            bool idExists = PayModelCategoriesList.ContainsKey(id);
            if (idExists)
            {
                PayModelCategories payModelCategories = PayModelCategoriesList[id];
                return payModelCategories;
            }
            return null;
        }

        public bool UpdatePayModelProduct(int id, PayModelCategories payModelCategories)
        {
            bool idExists = PayModelCategoriesList.ContainsKey(id);
            if (idExists)
            {
                try
                {
                    PayModelCategoriesList[id] = payModelCategories;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;
        }

        public Dictionary<int, PayModelCategories> GetPayModelCategoriesList()
        {
            return PayModelCategoriesList;
        }


    }
}


    


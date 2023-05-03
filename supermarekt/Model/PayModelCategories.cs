using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Supermarker.Model
{
    internal class PayModelCategories
    {
      
            public int? Id { get; set; }
            public string Name { get; set; }

            public PayModelCategories(int? id, string name)
            {
                Id = id;
                Name = name;
        }

      

        public PayModelCategories(string name)
        {
            Name = name;
        }
    }
    }



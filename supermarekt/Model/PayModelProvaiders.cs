using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker.Model
{
    internal class PayModelProvaiders
    {
        public PayModelProvaiders(int? id, string name, string lastName, string address, int phone, string email)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public int? Id { get; set; }
        public string Name { get; set; }

        public string  LastName{ get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }


    }

}




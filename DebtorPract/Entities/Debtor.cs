using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DebtorPract.Entities
{
    public class Debtor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Debt { get; set; }

        public Debtor()
        {
            Id = 0;
            this.FullName = "";
            this.BirthDay = DateTime.Now;
            this.Phone = "";
            this.Email = "";
            this.Address = "";
            this.Debt = 0;
        }

        public Debtor(string fullname, DateTime birthDay, string phone, string email, string address, int debt)
        {
            
            this.FullName = fullname;
            this.BirthDay = birthDay;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.Debt = debt;
        }



        public override string ToString()
        {
            return $"{this.FullName} {this.BirthDay.ToShortDateString()} {this.Phone} {this.Email} {this.Address} {this.Debt}";
        }
    }
}

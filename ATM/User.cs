using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class User
    {
        public Card[] Cards { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Card [] card { get; set; }



        public User(string firstname, string lastname, Card [] card)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.card = card;

        }
    }
 }

    



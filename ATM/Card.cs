using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Card
    {

          public string CardNum { get; set; }
          public  int Pin { get; set; }
          public double Balance { get; set; }
          public string CardType { get; set; }
          public DateTime PublishedDate { get; set; }
          public DateTime EndDate { get; set; }


       

        public void Deposit()
        {
            Console.WriteLine("How much money do you whant to deposit? ");
            double newDeposit = double.Parse(Console.ReadLine());
            double newBalance = this.Balance + newDeposit;
            this.Balance = newBalance;
            Console.WriteLine("Thank you! Your new  balance  is " + " " + this.Balance);
        }

        Mashine limit = new Mashine();

        public void Withdraw()
        {
            Console.WriteLine("How much money do you whant to withdraw? ");
            double newWithdraw = double.Parse(Console.ReadLine());
            if (this.Balance < newWithdraw && limit.Limit < newWithdraw)
            {
                Console.WriteLine("There is not enough money...");
            }
            else
            {
                this.Balance = this.Balance - newWithdraw;
                Console.WriteLine("Thank you!");
            }

        }



        public void Balanced()
        {
            Console.WriteLine("Your current balance is" + " " + this.Balance);
        }
    }







}

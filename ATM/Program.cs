using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Program
    {

      

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my ATM!!!");
            Console.WriteLine("Please enter your depit card : ");


            void printOptions()
            {
                Console.WriteLine("Please select one of the options ...");
                Console.WriteLine("1.Deposite");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Show balance");
                Console.WriteLine("4.Exit");
            }


            Card  card = new Card();
            card.CardNum = "2453235544";
            card.Pin = 123;
            card.Balance = 578.51;

            Card card2 = new Card();
            card2.CardNum = "436414544";
            card2.Pin = 658;
            card2.Balance = 698.11;


            User user = new User("Anna", "Avagyan", new Card[]
            {
                card, card2
            });
            

            
            while (true)
            {
                try
                {
                    string debitCardNum = Console.ReadLine();
                    string type = "";
                    if(user != null) 
                    {
                        break;
                    }
                    else if(card.CardType == type)
                    {
                        Console.WriteLine("Card is not recognized. Please try again ...");
                    }
                    else
                    {
                        Console.WriteLine("Card is not recognized. Please try again ...");
                    }
                }
                catch { Console.WriteLine("Card is not recognized. Please try again ..."); }
            }


            Console.WriteLine("Enter your pin please...");

            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if(card.Pin == userPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect pin.Try again...");
                    }
                   
                }
                catch
                {
                    Console.WriteLine("Incorrect pin.Try again...");
                }

            }


            Console.WriteLine("Welcome " + user.Firstname);

            int option = 0;

            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {

                }
                if (option == 1) { card.Deposit(); }
                else if (option == 2) { card.Withdraw(); }
                else if (option == 3) { card.Balanced(); }
                else if (option == 4) { break; }
                else { option = 0; }
            }
            while (option != 4);

            Console.WriteLine("Thank you! ");

     

            

            



            //// db for testing
            //List<user> users = new List<user>();
            //users.Add(new user("456982124", 123, "Zhora", "Harutyunyan", 578.51));
            //users.Add(new user("256984324", 234, "Argishti", "Bejanyan", 394.63));
            //users.Add(new user("656182124", 345, "Vladimir", "Melkumyan", 820.15));
            //users.Add(new user("156982124", 456, "Rafael", "Dallaqyan", 365.11)); 
            //users.Add(new user("656582114", 567, "Lily", "Saruxanyan", 1250.51));
            //users.Add(new user("856982125", 678, "Irina", "Safaryan", 478.28));
            //users.Add(new user("756982127", 789, "Lilit", "Qocharyan", 678.21));
            //users.Add(new user("366982124", 987, "Armen", "Melqonyan", 550.51)); 
            //users.Add(new user("116982124", 874, "Vahe", "Azizyan", 320.81));


            
            //String debitCardNum = "";
            //user currentUsers;



        }
 
    }
}

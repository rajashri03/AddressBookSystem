using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressbookEntry
    {
        List<Contacts> add = new List<Contacts>();
        /// <summary>
        /// Method to add Contacts in address book
        /// </summary>
        /// <param name="con"></param>
        public void AddContact(Contacts con)
        {
            add.Add(con);
        }
        /// <summary>
        /// method to show contact in list
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Enter Firstname");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zipcode");
            string zipcode = Console.ReadLine();
            Console.WriteLine("Enter Pincode");
            string pincode = Console.ReadLine();
            add.Add(new Contacts()
            {
                Firstname = fname,Lastname = lname, Address=address, City=city,
                State=state,Zipcode=zipcode,Pincode=pincode
            });

            foreach (var con in add)
            {
                Console.WriteLine("****************Peoples In address book********************");
                Console.WriteLine("First Name:" + con.Firstname);
                Console.WriteLine("Last Name:" + con.Lastname);
                Console.WriteLine("Address:" + con.Address);
                Console.WriteLine("City:" + con.City);
                Console.WriteLine("State:" + con.State);
                Console.WriteLine("Zipcode:" + con.Zipcode);
                Console.WriteLine("Pincode:" + con.Pincode);
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
        /// <summary>
        /// Method to check for duplicate Entry of the same person
        /// </summary>
        public void UniqueContact()
        {
            Console.Write("Enter Count-How Many contact You want to add?");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Press 1 If you want to add a new Contact to the Address Book");
                switch (Console.ReadLine())
                {
                    case "1":
                        for (int k = 0; k < number; k++)
                        {
                            Console.Write("Enter the First Name: ");
                            string fname = Console.ReadLine();
                            Console.WriteLine($"'{fname}' is not exists in our list so you can add {fname}");
                            if (add.Exists(e => e.Firstname == fname))//used Lambda Expression to check for duplicate entry
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Yes, A person having name  '{fname}' exists in our list");
                                Console.ResetColor();
                                Console.ReadKey();
                                Show();
                            }
                            else
                            {
                                Show();
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("The choice is not valid.");
                        break;
                }
            }
        }

        /// <summary>
        /// Method to search entry from address book -City and state wise
        /// </summary>
        public void SearchByCityState()
        {
            Console.WriteLine("********Search*******");
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            add.Add(new Contacts()
            {
                City = city,
                State = state
            });
            var lists = add.FindAll(x =>( x.City == city && x.State==state));

            Console.WriteLine($"****************Peoples In {city}********************");
            foreach (Contacts conn in lists)
            {
                Console.WriteLine("First Name:" + conn.Firstname);
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
    }
}

// See https://aka.ms/new-console-template for more information
using AddressBook;
bool status = true;
AddressbookEntry add = new AddressbookEntry();
while (status)
{
    Console.WriteLine("Select:\n1)Add New Entry\n2)Search\n3)Count");
    int op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
        case 1:
            add.Show();
            add.UniqueContact();
            break;
        case 2:
            add.Show();
            add.UniqueContact();
            add.SearchByCityState();
            break;
        case 3:
            add.Show();
            add.UniqueContact();
            add.Countperson();
            break;
    }
}
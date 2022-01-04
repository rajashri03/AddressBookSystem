// See https://aka.ms/new-console-template for more information
using AddressBook;
using System.IO;
bool status = true;
AddressbookEntry add = new AddressbookEntry();
while (status)
{
    Console.WriteLine("Select:\n1)Add New Entry\n2)Search\n3)Count\n4)Read and Write file\n5)Write using csv\n6)Write using Json");
    int op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
        case 1:
            add.Show();
            //add.UniqueContact();
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
        case 4:
            AddressbookEntry.WriteData();
            break;
        case 5:
            string Filepath = @"D:\Bridgelab\AddressBookSystem\AddressBook\AddressBook\Contacts.csv";
            AddressbookEntry.WriteDataUsingCSV(Filepath);
            AddressbookEntry.ReadDataUsingCSV(Filepath);
            break;
        case 6:
            string fileName = @"D:\Bridgelab\AddressBookSystem\AddressBook\AddressBook\Contacts.json";
            AddressbookEntry.WriteDataUsingJSON(fileName);
            AddressbookEntry.ReadJson(fileName);
            break;
    }
}
using PetShop.core.entity;
using PetShop.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
   


    public class Printer : IPrinter
    {

        readonly IPetService _petService;
        public Printer(IPetService petService)
        {
            _petService = petService;
        }


        public void StartUI()
        {
            MainMenu();
        }

        public void MainMenu()
        {
            Console.Write("main menu \n\n 1- Create new \n 2- update pet \n 3- delete pet \n 4- search pets \n 5- exit \n\n ");
            int id;
                
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    addPet();
                    break;
                case "2":
                    Console.WriteLine("Choose animal by id");
                    while (!int.TryParse(Console.ReadLine(), out id))
                    {
                        Console.WriteLine("enter pets id !NUMBER!");
                    }
                    UpdatePet(id);
                    break;
                case "3":
                    Console.WriteLine("Choose animal by id");
                    while (!int.TryParse(Console.ReadLine(), out id))
                    {
                        Console.WriteLine("enter pets id !NUMBER!");
                    }
                    DeletePet(id);
                    break;
                case "4":
                    Console.Clear();
                    SearchPet();
                    break;
                case "5":
                    break;


            }
        }

        public void SearchPet()
        {
            Console.Write("Search Menu \n\n 1- Show all Pets \n 2- Search pets by type \n 3- search pets by price \n 4- list the 5 cheapest pets \n");

            int n;
            

            switch (Console.ReadLine())
            {
                case "1":
                    showList (_petService.getAllPets()); 
                    break;
                case "2":
                    Console.WriteLine("enter animal you want");
                    try
                    {
                        showList(_petService.getAllPetsByType(Console.ReadLine()));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("We don't have any of those. Sorry.");
                        MainMenu();
                    }
                    break;
                case "3":
                    showList(_petService.getAllPetsByPrice());
                    break;
                case "4":
                    showList(_petService.getCheapestPets());
                    break;

            }

        }
        
        private void showList(List<pet> pets)
        {
            Console.Clear();
            foreach (var pet in pets)
            {
                Console.WriteLine($"Id: {pet.id}");
                Console.WriteLine($"Name: {pet.name}");
                Console.WriteLine($"Type: {pet.type}");
                Console.WriteLine($"Colour: {pet.colour}");
                Console.WriteLine($"Price: {pet.price}");
                Console.WriteLine($"Birthdate: {pet.birthDate.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Previous Owner: {pet.previousOwner}");
                Console.WriteLine($"Sold on: {pet.soldDate.ToString("dd/MM/yyyy")}\n\n");
            }
            Console.Write("press enter to continue");
            Console.Read();
            Console.Clear();
            MainMenu();
        }

        public void addPet()
        {
            Console.Write("Enter name of Pet:");
            var name = Console.ReadLine();

            Console.Write("type of Pet:");
            var type = Console.ReadLine();

            Console.Write("colour of pet:");
            var colour = Console.ReadLine();

            Console.Write("previous owner of Pet:");
            var previousOwner = Console.ReadLine();

            Console.Write("price of Pet:");
            double price;
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("price is a number.");
            }

            Console.Write("birthdate of pet:");
            DateTime birthDate;
            while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                Console.WriteLine("not valid. Use dd/mm/yyyy");
            }

            _petService.CreatePet(name, type, colour, previousOwner, price, birthDate);

            Console.Clear();
            Console.WriteLine($"{name} was added, Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            MainMenu();
        }

        private void DeletePet(int id)
        {
            _petService.DeletePet(id);
            Console.Clear();
            Console.WriteLine("Pet has been deleted.  Press enter to continue");
            Console.Read();
            MainMenu();
        }

        private void UpdatePet(int id)
        {
            Console.Write("update name of Pet: ");
            var Name = Console.ReadLine();

            Console.Write("update type of Pet: ");
            var Type = Console.ReadLine();

            Console.Write("update colour of pet: ");
            var Colour = Console.ReadLine();

            Console.Write("update previous owner of Pet: ");
            var PreviousOwner = Console.ReadLine();

            Console.Write("update price of Pet: ");
            double Price;
            while (!double.TryParse(Console.ReadLine(), out Price))
            {
                Console.WriteLine("price is a number.");
            }

            Console.Write("update birthdate of pet: ");
            DateTime Birthdate;
            while (!DateTime.TryParse(Console.ReadLine(), out Birthdate))
            {
                Console.WriteLine("not valid. Use dd/mm/yyyy");
            }

            _petService.UpdatePet(id, Name, Type, Colour, PreviousOwner, Price, Birthdate);
            Console.Clear();
            Console.WriteLine($"{Name} has been updated. press enter to continue ");
            Console.Read();
            Console.Clear();

            MainMenu();
        }
    }
}

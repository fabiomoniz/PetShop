using PetShop.core.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.core.Service
{
    public interface IPetService
    {
        void CreatePet(string name, string type, string colour, string previousOwner, double price, DateTime birthdate);
        void DeletePet(int id);
        void UpdatePet(int id, string name, string type, string colour, string previousOwner, double price, DateTime birthdate);
        List<pet> getAllPetsByType(string type);
        List<pet> getAllPets();
        List<pet> getAllPetsByPrice();
        List<pet> getCheapestPets();
    }
}

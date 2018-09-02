using PetShop.core.Domain;
using PetShop.core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.core.Service.Implementation
{
    public class PetService : IPetService
    {
        readonly IPetRep _petRepository;

        public PetService(IPetRep petRepository)
        {
            _petRepository = petRepository;
        }
        public void CreatePet(string name, string type, string colour, string previousOwner, double price, DateTime birthdate)
        {

            pet pet = new pet()
            {
               name = name,
               type = type,
               previousOwner = previousOwner,
               colour = colour,
               birthDate = birthdate,
               price = price,
               soldDate = DateTime.Now
            };
            Save(pet);
        }

        public void DeletePet(int id)
        {
            pet pet = ReturnPetId(id);
            _petRepository.DeletePet(pet);
        }

        public List<pet> getAllPets()
        {
            return _petRepository.returnPetList().ToList();
        }


        
        public pet ReturnPetId(int id)
        {
            foreach (var pet in _petRepository.returnPetList().ToList())
            {
                if (pet.id == id)
                {
                    return pet;
                }
            }
            return null;
            //method of returning a pet , by searching the list in database to find pet with selected id
        }

        public void Save(pet pet)
        {
             _petRepository.AddPet(pet);
        }

        public void UpdatePet(int id, string name, string type, string colour, string previousOwner, double price, DateTime birthdate)
        {
            var pet = new pet();
            pet.id = id;
            pet.name = name;
            pet.type = type;
            pet.colour = colour;
            pet.previousOwner = previousOwner;
            pet.price = price;
            pet.birthDate = birthdate;

            _petRepository.UpdatePet(pet);
        }

        List<pet> IPetService.getAllPetsByPrice()
        {
            var list = _petRepository.returnPetList();
            var query = list.OrderBy(pet => pet.price);
            return query.ToList();
        }

        List<pet> IPetService.getAllPetsByType(string type)
        {
            var list = _petRepository.returnPetList();
            var query = list.Where(pet => pet.type.ToLower() == type.ToLower());
            if (query.ToList().Count > 0)
            {
                return query.ToList();
            }
            return null;
        }

        List<pet> IPetService.getCheapestPets()
        {
            var list = _petRepository.returnPetList();
            var query = list.OrderBy(pet => pet.price);
            return query.Take(5).ToList();
        }
    }
}

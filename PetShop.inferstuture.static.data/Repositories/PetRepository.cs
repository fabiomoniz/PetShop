using PetShop.core.Domain;
using PetShop.core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.inferstuture.Static.data.Repositories
{
    public class PetRepository : IPetRep
    {
        public void AddPet(pet pet)
        {
            var list = database.Pets;
            pet.id = list.ElementAt( list.Count() - 1 ).id + 1;
            var petList = list.ToList();
            petList.Add(pet);

            database.Pets = petList;
        }

        public void DeletePet(pet pet)
        {
            var list = database.Pets.ToList();
            list.Remove(pet);
            database.Pets = list;
        }

        public void UpdatePet(pet updatePet)
        {
            var list = database.Pets.ToArray(); ;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].id == updatePet.id)
                {
                    list[i] = updatePet;
                }
            }
            database.Pets = list;
        }

        public IEnumerable<pet> returnPetList()
        {
            return database.Pets;
        }
    }
}

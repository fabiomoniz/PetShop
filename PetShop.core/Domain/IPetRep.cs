using System;
using System.Collections.Generic;
using System.Text;
using PetShop.core.entity;

namespace PetShop.core.Domain
{
    public interface IPetRep
    {
        void AddPet(pet pet);
        void DeletePet(pet pet);
        void UpdatePet(pet updatePet);
        IEnumerable<pet> returnPetList();
    }
}

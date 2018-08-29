using PetShop.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{

    public class Printer : IPrinter
    {
        readonly IPetService _petService;
        Printer(IPetService petService)
        {
            _petService = petService;
        }


        public void StartUI()
        {
            
        }
    }
}

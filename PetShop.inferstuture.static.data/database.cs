using PetShop.core.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.inferstuture.Static.data
{
    public class database
    {
        public static IEnumerable<pet> Pets;

        public static void DataStart()
        {
            pet pet1 = new pet()
            {
                id = 0,
                name = "fabio",
                birthDate = DateTime.Parse("10/10/1993"),
                colour = "latino",
                previousOwner = "my mum",
                price = 1234,
                soldDate = DateTime.Parse("20/02/2008"),
                type = "dog"
            };
            pet pet2 = new pet()
            {
                id = 1,
                name = "thgff",
                birthDate = DateTime.Parse("7/2/1970"),
                colour = "dfgdfgd",
                previousOwner = "tsr sfd",
                price = 11151,
                soldDate = DateTime.Parse("11/11/1911"),
                type = "cat"
            };
            pet pet3 = new pet()
            {
                id = 2,
                name = "gitte",
                type = "dog",
                colour = "yellow",
                previousOwner = "someone",
                birthDate = DateTime.Parse("07/02/1999"),
                price = 5010,
                soldDate = DateTime.Parse("20/6/2005")
            };
            pet pet4 = new pet()
            {
                id = 3,
                name = "Willow",
                type = "Popcorn",
                colour = "White",
                previousOwner = "Me",
                birthDate = DateTime.Parse("31/10/2016"),
                price = 7080,
                soldDate = DateTime.Parse("11/8/2017")
            };
            pet pet5 = new pet()
            {
                id = 4,
                name = "dog",
                type = "dog",
                colour = "green",
                previousOwner = "tequila",
                birthDate = DateTime.Parse("2/2/2015"),
                price = 4500,
                soldDate = DateTime.Parse("2/2/2016")
            };
     
            Pets = new List<pet> { pet1, pet2, pet3, pet4, pet5 };
        }
    }
}

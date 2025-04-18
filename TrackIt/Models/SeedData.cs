using System;
using System.Linq;
using TrackIt.Data;
using TrackIt.Models;

namespace TrackIt
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.Products.Any())
            {
                return;
            }

            context.Products.AddRange(

            // Economy Packs
                new Product
                {
                    Name = "Original Loose",
                    Code = "OL8040",
                    UnitWeight = "250g",
                    UnitCount = 20,
                    Group = "Economy Packs",
                    ImageUrl = "url_to_image"
                },

               new Product
                {
                    Name = "Original Loose",
                    Code = "OL8030",
                    UnitWeight = "500g",
                    UnitCount = 10,
                    Group = "Economy Packs",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Original Loose",
                    Code = "OL8480",
                    UnitWeight = "2Kg",
                    UnitCount = 3,
                    Group = "Economy Packs",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Chocolate Loose",
                    Code = "CL8594",
                    UnitWeight = "250g",
                    UnitCount = 20,
                    Group = "Economy Packs",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Chocolate Loose",
                    Code = "CL8593",
                    UnitWeight = "500g",
                    UnitCount = 10,
                    Group = "Economy Packs",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Chocolate Loose",
                    Code = "CL8595",
                    UnitWeight = "2Kg",
                    UnitCount = 3,
                    Group = "Economy Packs",
                    ImageUrl = "url_to_image"
                },

                // Cream Biscuits
                new Product
                {
                    Name = "Lemon Creams",
                    Code = "LC8155",
                    UnitWeight = "200g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Creamy Choc",
                    Code = "CC8135",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Double Creamy",
                    Code = "DC8325",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Lemon Creams",
                    Code = "LC8152",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "vanilla Creams",
                    Code = "VC8165",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Custard Creams",
                    Code = "CC8148",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Bermuda Creams",
                    Code = "8175",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Strawberry Creams",
                    Code = "SC8435",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Vanilla Kreamies",
                    Code = "Vk8575",
                    UnitWeight = "110g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Lemon Kreamies",
                    Code = "LC8580",
                    UnitWeight = "110g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Chocolate kreamies",
                    Code = "LK8580",
                    UnitWeight = "110g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                },
                new Product
                {
                    Name = "Blueberry Kreamies",
                    Code = "BK8590",
                    UnitWeight = "110g",
                    UnitCount = 12,
                    Group = "Cream Biscuits",
                    ImageUrl = "url_to_image"
                } ,

                //Chocolate Biscuits
                new Product
                {
                    Name = "Choco Chunks",
                    Code = "CC8200",
                    UnitWeight = "200g",
                    UnitCount = 12,
                    Group = "Chocolate Biscuits",
                    ImageUrl = "url_to_image"
                },

                new Product
                {
                    Name = "Choco Shortcake",
                    Code = "CS8535",
                    UnitWeight = "160g",
                    UnitCount = 12,
                    Group = "Chocolate Biscuits",
                    ImageUrl = "url_to_image"
                },

                //Assorted Biscuits

                new Product
                {
                    Name = "Choice Assorted",
                    Code = "CA8215",
                    UnitWeight = "200g",
                    UnitCount = 12,
                    Group = "Chocolate Biscuits",
                    ImageUrl = "url_to_image"
                },

                //Plain Biscuits
                new Product
                {
                    Name = "Choc Chip",
                    Code = "CC8515",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Plain Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Oat Crunch",
                    Code = "OC8545",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Plain Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Chunky Choc Dip",
                    Code = "CCD8525",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Plain Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Lemon 'n' Orange",
                    Code = "LO8592",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Plain Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Cinamon 'n' Raisin",
                    Code = "CR8591",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Plain Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Ginger Nut",
                    Code = "GN8265",
                    UnitWeight = "200g",
                    UnitCount = 12,
                    Group = "Plain Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Ginger Bite",
                    Code = "GB8570",
                    UnitWeight = "135g",
                    UnitCount = 12,
                    Group = "Plain Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Marie",
                    Code = "M8290",
                    UnitWeight = "200g",
                    UnitCount = 12,
                    Group = "Plain Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Marie",
                    Code = "M8285",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Plain Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Tea Time",
                    Code = "TT8565",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Plain Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Shortbread",
                    Code = "SB8572",
                    UnitWeight = "200g",
                    UnitCount = 12,
                    Group = "Plain Biscuits",
                    ImageUrl = "url_to_image"
                },
                
             //Savoury Biscuits
                new Product
                {
                    Name = "Cream Crakers",
                    Code = "CC8345",
                    UnitWeight = "200g",
                    UnitCount = 12,
                    Group = "Savoury Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Snax Crackers",
                    Code = "SC8365",
                    UnitWeight = "125g",
                    UnitCount = 12,
                    Group = "Savoury Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Water",
                    Code = "W8375",
                    UnitWeight = "150g",
                    UnitCount = 12,
                    Group = "Savoury Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Cheddars",
                    Code = "C8386",
                    UnitWeight = "165g",
                    UnitCount = 12,
                    Group = "Savoury Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Belvita",
                    Code = "B8335",
                    UnitWeight = "200g",
                    UnitCount = 12,
                    Group = "Savoury Biscuits",
                    ImageUrl = "url_to_image"
                }
                
              //Miscellaneous

                ,new Product
                {
                    Name = "Wuff Dog",
                    Code = "WD8390",
                    UnitWeight = "1Kg",
                    UnitCount = 6,
                    Group = "Miscellaneous Biscuits",
                    ImageUrl = "url_to_image"
                },
                
                //SWEETS
                //Economy Packs
                new Product
                {
                    Name = "Apricots",
                    Code = "A6000",
                    UnitWeight = "10g",
                    UnitCount = 200,
                    Group = "Economy Packs",
                    ImageUrl = "url_to_image"
                },
                
                //Soft Candies
                new Product
                {
                    Name = "Assorted Toffees",
                    Code = "AT6032",
                    UnitWeight = "5g",
                    UnitCount = 3000,
                    Group = "Soft Candies",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Cheweys",
                    Code = "C6105",
                    UnitWeight = "5g",
                    UnitCount = 3000,
                    Group = "Soft Candies",
                    ImageUrl = "url_to_image"
                },
                
                //Hard Candies
                new Product
                {
                    Name = "Fizzy Fruit Sherbet",
                    Code = "FFS6035",
                    UnitWeight = "5g",
                    UnitCount = 3000,
                    Group = "Hard Candies",
                    ImageUrl = "url_to_image"
                },
                
                new Product
                {
                    Name = "Original Mint",
                    Code = "OM6115",
                    UnitWeight = "5g",
                    UnitCount = 3000,
                    Group = "Hard Candies",
                    ImageUrl = "url_to_image"
                }
                
            );

            context.SaveChanges();
        }
    }
}

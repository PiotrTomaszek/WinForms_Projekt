using System;
using System.Linq;

namespace P4_Projekt
{
    /// <summary>
    /// Symulacja dodania paru elementów do bazy danych. Tylko do jednokrotnego użytku na początku tworzenia bazy danych.
    /// </summary>
    public static class ExampleDataBaseInitializer
    {
        public static void DatabaseInitializer()
        {
            using (var context = new myShopContext())
            {
                //Kategorie
                context.Categories.Add(new Model.Category
                {
                    Name = "Procesor",
                    Description = "CPU do komputerów stacjonarnych."
                });
                context.Categories.Add(new Model.Category
                {
                    Name = "Karta Graficzna",
                    Description = "GPU do komputerów stacjonarnych."
                });
                context.Categories.Add(new Model.Category
                {
                    Name = "Laptop",
                    Description = "Przenośne urządzenia do pracy i rozrywki."
                });
                context.Categories.Add(new Model.Category
                {
                    Name = "RAM",
                    Description = "Pamięć komputera przeznaczona do wykorzystania w chwili pracy."
                });
                context.Categories.Add(new Model.Category
                {
                    Name = "Dysk Twardy",
                    Description = "Pamięć masowa przeznaczona do gromadzenia danych i zapisywania."
                });
                context.SaveChanges();

                // Produkty
                context.Products.Add(new Model.Product
                {
                    Name = "Nitro 5",
                    Discontinued = false,
                    Manufacturer = "Acer",
                    UnitsInStock = 12,
                    UnitPrice = 3200,
                    UnitsOrdered = 5,
                    UnitsSold = 512,
                    IdCategory = context.Categories.Where(cat => cat.Name.Equals("Laptop")).FirstOrDefault().IdCategory,
                    ImageUrl = "https://i.ebayimg.com/images/g/xZYAAOSwzcpdijv8/s-l1600.jpg"
                });
                context.Products.Add(new Model.Product
                {
                    Name = "MacBook",
                    Discontinued = false,
                    Manufacturer = "Apple",
                    UnitsInStock = 5,
                    UnitPrice = 4000,
                    UnitsOrdered = 2,
                    UnitsSold = 100,
                    IdCategory = context.Categories.Where(cat => cat.Name.Equals("Laptop")).FirstOrDefault().IdCategory,
                    ImageUrl = "https://image.ceneostatic.pl/data/products/66886711/i-apple-macbook-pro-15-4-i7-16gb-512gb-macos-silver-mr972ze-a.jpg"
                });
                context.Products.Add(new Model.Product
                {
                    Name = "i5-8300H",
                    Discontinued = false,
                    Manufacturer = "Intel",
                    UnitsInStock = 10,
                    UnitPrice = 600,
                    UnitsOrdered = 20,
                    UnitsSold = 600,
                    IdCategory = context.Categories.Where(cat => cat.Name.Equals("Procesor")).FirstOrDefault().IdCategory,
                    ImageUrl = "https://www.notebookcheck.pl/fileadmin/_processed_/a/e/csm_8th_Gen_Intel_Core_i5_Badge_ee07502dbf.jpg"
                });
                context.Products.Add(new Model.Product
                {
                    Name = "GTX 1050",
                    Discontinued = false,
                    Manufacturer = "Nvidia",
                    UnitsInStock = 50,
                    UnitPrice = 800,
                    UnitsOrdered = 90,
                    UnitsSold = 1500,
                    IdCategory = context.Categories.Where(cat => cat.Name.Equals("Karta Graficzna")).FirstOrDefault().IdCategory,
                    ImageUrl = "https://images.morele.net/i1064/975580_0_i1064.jpg"
                });
                context.Products.Add(new Model.Product
                {
                    Name = "Predator RGB 8GB DDR4",
                    Discontinued = false,
                    Manufacturer = "HyperX",
                    UnitsInStock = 14,
                    UnitPrice = 1000,
                    UnitsOrdered = 20,
                    UnitsSold = 200,
                    IdCategory = context.Categories.Where(cat => cat.Name.Equals("RAM")).FirstOrDefault().IdCategory,
                    ImageUrl = "https://image.ceneostatic.pl/data/products/62977095/i-hyperx-predator-rgb-8gb-ddr4-2933mhz-cl15-hx429c15pb3a8.jpg"
                });
                context.Products.Add(new Model.Product
                {
                    Name = "Dysk CX 400",
                    Discontinued = false,
                    Manufacturer = "GOODRAM",
                    UnitsInStock = 29,
                    UnitPrice = 500,
                    UnitsOrdered = 3,
                    UnitsSold = 18,
                    IdCategory = context.Categories.Where(cat => cat.Name.Equals("Dysk Twardy")).FirstOrDefault().IdCategory,
                    ImageUrl = "https://www.mediaexpert.pl/media/cache/gallery/product/1/198/252/686/bqwt8jfi/images/13/1389913/Dysk-GOODRAM-CX400-512GB-skos.jpg"
                });
                context.SaveChanges();

                // Klient
                context.Clients.Add(new Model.Client
                {
                    Login = "user",
                    City = "Katowice",
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "123-456-789",
                    Mail = "John.Doe@mail.com",
                    ZIP = "43-000",
                    Street = "Villowa",
                    HouseNumber = "12B/2",
                    Points = 150,
                    MoneySpent = 3200,
                    Voivodeship = "Śląsk",
                });
                context.Clients.Add(new Model.Client
                {
                    Login = "admin",
                    City = "Łodygowice",
                    FirstName = "Piotr",
                    LastName = "Tom",
                    Phone = "111-222-333",
                    Mail = "Piotr.Tom@mail.com",
                    ZIP = "43-300",
                    Street = "Villowa",
                    HouseNumber = "1232E/13",
                    Points = 2000,
                    MoneySpent = 5000,
                    Voivodeship = "Śląsk",
                });
                context.SaveChanges();

                //Zamówienie #1
                context.Orders.Add(new Model.Order
                {
                    IdClient = context.Clients.Where(a => a.Login.Equals("user")).FirstOrDefault().IdClient,
                    OrderDate = DateTime.Now.AddDays(-50),
                    OrderName = "Zamówienie user #1",
                    OrderStreet = "Villowa",
                    OrderHouseNumber = "12B/2",
                    OrderCity = "Katowice",
                    OrderVoivodeship = "Śląsk",
                    OrderZIP = "43-000",
                    TotalPrice = 3575,
                });
                context.SaveChanges();

                // Koszyk #1
                context.Charts.Add(new Model.Chart
                {
                    IdOrder = context.Orders.Where(z => z.IdOrder == 1).FirstOrDefault().IdOrder,
                    IdProduct = context.Products.Where(x => x.Name.Equals("Nitro 5")).FirstOrDefault().IdProduct,
                    Units = 1,
                    Price = 3200,
                    Discount = 0.0F,
                });
                context.Charts.Add(new Model.Chart
                {
                    IdOrder = context.Orders.Where(z => z.IdOrder == 1).FirstOrDefault().IdOrder,
                    IdProduct = context.Products.Where(x => x.Name.Equals("Dysk CX 400")).FirstOrDefault().IdProduct,
                    Units = 1,
                    Price = 375,
                    Discount = 0.25F,
                });
                context.SaveChanges();

                //Zamówienie #2
                context.Orders.Add(new Model.Order
                {
                    IdClient = context.Clients.Where(a => a.Login.Equals("user")).FirstOrDefault().IdClient,
                    OrderDate = DateTime.Now.AddDays(-10),
                    OrderName = "Zamówienie user #2",
                    OrderStreet = "Villowa",
                    OrderHouseNumber = "12B/2",
                    OrderCity = "Katowice",
                    OrderVoivodeship = "Śląsk",
                    OrderZIP = "43-000",
                    TotalPrice = 8000,
                });
                context.SaveChanges();

                // Koszyk #2 
                context.Charts.Add(new Model.Chart
                {
                    IdOrder = context.Orders.Where(z => z.IdOrder == 2).FirstOrDefault().IdOrder,
                    IdProduct = context.Products.Where(x => x.Name.Equals("MacBook")).FirstOrDefault().IdProduct,
                    Units = 2,
                    Price = 8000,
                    Discount = 0.0F,
                });
                context.SaveChanges();

            }
        }
    }
}

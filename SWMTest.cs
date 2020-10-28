using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SixWolfMedia.DB.Models;

namespace SixWolfMedia.DB
{
    public static class SWMTests
    {
        public static async Task Run()
        {
            using (var context = new SWMContext())
            {
                // deletes existing db
                await context.Database.EnsureDeletedAsync();
                // creates db from objects
                await context.Database.EnsureCreatedAsync();

                context.Merchants.Add(new Merchant
                {
                    Id = 5,
                    PartitionKey = "5",
                    IsCompany = "false",
                    CompanyName = "Six Wolf Media LTD.",
                    Prefix = "",
                    FirstName = "Phanat3",
                    MiddleInitial = "",
                    FullName = "Phanat Chan",
                    Suffix = "",
                    EmailAddress = "pchan@sixwolfmedia.com",
                    Address = "",
                    CountryCode = "CA",
                    MobilePhone = "",
                    Phone = "",
                    Url = "https://sixwolfmedia.com",
                    Fax = "",
                    SendEmail = "true",
                    EmailCategory = "",
                    PrefLanguage = "English",
                    Type = "",
                    Status = "",
                    BillAddrName = "",
                    PayTerms = "",
                    Inactive = "",
                    InactiveDate = "",
                    EnrollDate = "",
                    CustomerShip = "",
                    TrackEquipment = "",
                    TrackHistory = "",
                    CreatedOn = "",
                    CreatedBy = "",
                    ModifiedOn = "",
                    ModifiedBy = "",
                    Facilities = new List<Facility>() {
                        new Facility() {Id = 1, FacilityName="Facility1", PartitionKey = "1"},
                        new Facility() {Id = 2, FacilityName="Facility2", PartitionKey = "2"}
                    }
                });
                
                await context.SaveChangesAsync();

                var merchant = (from m in context.Merchants where m.FirstName == "Phanat3" select m).FirstOrDefault<Merchant>();

                if(merchant != null)
                {
                    Console.WriteLine("Retrieved record: {0}", merchant.ToString());

                    Console.WriteLine("First Facility: {0}", (from f in merchant.Facilities select f).First<Facility>().FacilityName);
                }
            }
        }
    }
}
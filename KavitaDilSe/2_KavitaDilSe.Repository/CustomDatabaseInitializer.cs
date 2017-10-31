using _1_KavitaDilSe.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace _2_KavitaDilSe.Repository
{
    /// <summary>
    /// Class is responsible for intial values to be inserted in db tables
    /// </summary>
    public class CustomDatabaseInitializer : DropCreateDatabaseIfModelChanges<KavitaDilSeDbContext>
    {
        protected override void Seed(KavitaDilSeDbContext context)
        {
            var dataUserMaster = new List<UserMasterModel>
            {
                new UserMasterModel
                {
                    Id =1,
                    UserName ="svashishth",
                    Password="123Password",
                    EmailId ="vashishth.sachin89@gmail.com",
                    FirstName ="Sachin",
                    LastName ="Vashishth",
                    IsActiveUser =true,
                    UserStamp ="admin",
                    TimeStamp =DateTime.Now
                },
            };

            context.Set<UserMasterModel>().AddRange(dataUserMaster);

            var dataCreationTypeMaster = new List<CreationTypeMasterModel>
            {
                new CreationTypeMasterModel
                {
                    Id=1,
                    TypeName="Friends",
                    UserStamp="Sachin",
                    TimeStamp=DateTime.Now
                }
            };

            context.Set<CreationTypeMasterModel>().AddRange(dataCreationTypeMaster);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}

using Business.Abstract;
using Business.Adapters;
using Business.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Application
            ISupplierService supplierService = new PttManager(new MernisServiceAdapter());
            supplierService.GiveMask(
                new Citizen 
                { FirstName = "a", LastName = "b", BirthDate = new DateTime(), NationalityId = "0" }
           );

            IPerson person1 = new Citizen();
            person1.FirstName = "a";             // your name
            person1.LastName = "b";              // your surname
            person1.NationalityId = "0";         // your id number
            person1.BirthDate = new DateTime(); // your birthdate

            supplierService.GiveMask(person1);

            // Application request from user
            IApplicantService applicantService = new CitizenManager(new MernisServiceAdapter());
            applicantService.ApplyForMask(new Citizen { FirstName = "a", LastName = "b", BirthDate = new DateTime(), NationalityId = "0" });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Business.Abstract;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " Maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " Maske Verilemedi.");
            }
        }

        public void GiveMask()
        {
            throw new NotImplementedException();
        }
    }
}

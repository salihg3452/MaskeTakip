using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}

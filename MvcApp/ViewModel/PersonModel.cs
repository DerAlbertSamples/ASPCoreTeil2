using System.ComponentModel;

namespace MvcApp.ViewModel
{
    public class PersonModel
    {
        public PersonModel(Salutation salutation, string firstName, string lastName)
        {
            Salutation = salutation;
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Salutation Salutation { get; set; }
    }
}
using KsiążkaKontaktowa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiążkaKontaktowa.Services
{
    class MockDataService: IContactDataService
    {
        private IEnumerable<Contact> _constacts;
        public MockDataService()
        {
            new Contact
            {
                Name = "Józef Kowalski",
                PhoneNumber = new string[]
                {
                    "555-111-3333", "444-555-8888"
                },
                Email = new string[]
                {
                    "kowalski@gmail.com", "jozek.kowalski@gmail.com"
                },
                Location = new string[]
                {
                    "Fake Avenue 15b", "Cwiarki 3/4"
                }
            };

            new Contact
            {
                Name = "Maria Kowalska",
                PhoneNumber = new string[]
                {
                    "555-111-3333", "444-555-8888"
                },
                Email = new string[]
                {
                    "kowalska@gmail.com", "miaria.kowalska@gmail.com"
                },
                Location = new string[]
                {
                    "Fake Avenue 15b", "Cwiarki 3/4"
                }
            };
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _constacts;
        }

        public void Save(IEnumerable<Contact> contacts)
        {
            _constacts = contacts;
        }
    }
}

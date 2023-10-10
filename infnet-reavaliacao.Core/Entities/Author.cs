using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infnet_reavaliacao.Core.Entities
{
    public class Author
    {
        public Author(string fullName, DateTime birthDate, string country)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Country = country;
            
            Books = new List<Book>();
        }

        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Country { get; private set; }
        public List<Book> Books { get; private set; }
    }
}

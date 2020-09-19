using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class AuthorModel
    {
        public string FirstName { get; set; }
        public string SeccondName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public List<BookModel> Books { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        [DisplayName("Tytuł")]
        public string Title { get; set; }
        [DisplayName("Autor")]
        public string Author { get; set; }
        //public List<AuthorModel> Authors { get; set; }
        [DisplayName("Ilość stron")]
        public int NumberOfPages { get; set; }
        [DisplayName("ISBN")]
        public string Isbn { get; set; }
        [DisplayName("Wydawnictwo")]
        public string Publisher { get; set; }
        [DisplayName("Rok wydania")]
        public int YearOfPublishment { get; set; } //czy da się zrobić DateTime jedynie z rokiem (bez miesiąca i dnia)?
        [DisplayName("Dostępność")]
        public bool IsAvaliable { get; set; } 
        
    }
}

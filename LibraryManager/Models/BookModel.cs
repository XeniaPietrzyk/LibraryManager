using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    [Table("Books")]
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }
        [DisplayName("Tytuł")]
        [Required(ErrorMessage = "Wprowadź tytuł.")]
        public string Title { get; set; }
        [DisplayName("Autor")]
        public string Author { get; set; }
        //public List<AuthorModel> Authors { get; set; }
        [DisplayName("Ilość stron")]
        public int NumberOfPages { get; set; }
        [DisplayName("ISBN")]
        public string Isbn { get; set; }
        [DisplayName("Wydawnictwo")]
        [MaxLength(13)]
        public string Publisher { get; set; }
        [DisplayName("Rok wydania")]
        public int YearOfPublishment { get; set; } //czy da się zrobić DateTime jedynie z rokiem (bez miesiąca i dnia)?
        [DisplayName("Status")]
        public bool IsAvaliable { get; set; } //to trzeba inaczej rozwiązać - dwie opcje: dostępna/wypożyczona - do wyboru przyciski do zaznaczenia statusu 
        
    }
}

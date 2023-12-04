using LINQtoQuery.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoQuery.Models.Concrate
{
    public class Book : BaseItem<int>
    {
        public override int Id { get ; set ; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Range(0.0,100000.0)]
        public double Price { get; set; }

        //Bire Çok İlişkinin çok kısmına bunu ekliyoruz
        public string GenreId { get; set; }
        public Genre Genre { get; set; }
        // Bire Çok İlişkinin diğer bilgilerini de burada tutuyoruz.

        public List<BookAuthor> BookAuthors { get; set; }
    }
}

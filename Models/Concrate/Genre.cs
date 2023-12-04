using LINQtoQuery.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoQuery.Models.Concrate
{
    public class Genre : BaseItem<string>
    {
        [Required]
        [MaxLength(10)]
        public override string Id { get ; set ; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        //Bire Çok İlişkinin birinde de burayı tutuyoruz.
        public List<Book> Books { get; set; }
        // Bir kısmına Liste Ekliyoruz. Kolaylık Olsun Diye Ekliyoruz.


    }
}

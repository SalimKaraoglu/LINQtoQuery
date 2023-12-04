using LINQtoQuery.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoQuery.Models.Concrate
{
    public class Author : BaseItem<int>
    {
        public override int Id { get ; set ; }

        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }

        public string FullName => $"{FirstName}{LastName}";

        public List<BookAuthor> BookAuthors { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string AuthorFullName => string.Concat(AuthorName, " ", AuthorSurname);
        public DateTime AuthorDateOfBirth { get; set; }
        public bool IsDeleted { get; set; }
    }
}
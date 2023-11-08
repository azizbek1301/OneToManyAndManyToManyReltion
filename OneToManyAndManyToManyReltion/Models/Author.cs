using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyAndManyToManyReltion.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email {  get; set; }

        [ForeignKey("BookId")]
        public ICollection<Book> Books { get; set; }
    }
}

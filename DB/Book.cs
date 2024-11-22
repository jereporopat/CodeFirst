using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId {get; set;}
        public string Title {get; set;}
        public int BrandId {get; set;}
        [ForeignKey("BrandId")]
        public virtual Brands Brand {get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace BookLending.Models
{
    public class Author:FullAuditedEntity
    {
        public Author()
        {
            Books=new HashSet<Book>();
        }


        [Display(Name = "Display Name")]
        [StringLength(64, ErrorMessage = "maximum allowable length is 64")]
        public string DisplayName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}

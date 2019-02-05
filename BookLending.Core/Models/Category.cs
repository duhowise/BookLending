using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace BookLending.Models
{
    public class Category:AuditedEntity<int>
    {
        public Category()
        {
            Books=new HashSet<Book>();
        }

        [Display(Name = "Display Name")]
        [StringLength(64, ErrorMessage = "maximum allowable length is 64")]
        public string DisplayName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

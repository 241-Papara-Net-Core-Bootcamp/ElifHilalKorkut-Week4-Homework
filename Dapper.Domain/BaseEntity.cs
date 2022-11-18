using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Dapper.Domain
{
    
    public abstract class BaseEntity
    {

        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public string LastUpdateBy { get; set; }
    }
}

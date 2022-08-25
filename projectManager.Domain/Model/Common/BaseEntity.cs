using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Domain.Model.Common
{
    public class BaseEntity : AuditableModel
    {
        public int ID { get; set; }
    }
}

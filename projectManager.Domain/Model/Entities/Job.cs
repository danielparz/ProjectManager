using ProjectManager.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Domain.Model.Entities
{
    public class Job : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Owner { get; set; }
        public int CategoryId { get; set; }
        public bool IsFinished { get; set; }

        public Project AssignedProject { get; set; }
        public Category Category { get; set; }
    }
}

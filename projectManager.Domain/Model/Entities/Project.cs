using ProjectManager.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Domain.Model.Entities
{
    public class Project : BaseEntity
    {
        public string ProjectName { get; set; }
        public string? Description { get; set; }
        public int TeamLeaderId { get; set; }

        public ICollection<User> Members { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public User TeamLeader { get; set; }
    }
}

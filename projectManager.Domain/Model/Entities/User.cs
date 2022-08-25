using ProjectManager.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Domain.Model.Entities
{
    public class User : BaseEntity
    {
        public string Nickname { get; set; }
        public string? FiDrstname { get; set; }
        public string? Lastname { get; set; }
        public string? EmailAdress { get; set; }
        public string? LinkedInAdress { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public ICollection<Project>? ProjectsAsTeamLeader { get; set; }
        public ICollection<Project>? ProjectsAsMember { get; set; }
    }
}

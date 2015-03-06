using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFMT_AgentSkillAssignmentComparer.Models
{
    class SkillAssignmentsDataFile
    {
        public string FilePath { get; set; }
        public IEnumerable<AgentSkillAssignmentsData> AssignmentsData { get; set; }
    }
}

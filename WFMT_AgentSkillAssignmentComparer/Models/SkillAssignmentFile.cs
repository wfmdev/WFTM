using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFMT_AgentSkillAssignmentComparer.Models
{
    class SkillAssignmentFile
    {
        public string FilePath { get; set; }
        public IEnumerable<AgentSkillAssignment> Assignments { get; set; }
    }
}

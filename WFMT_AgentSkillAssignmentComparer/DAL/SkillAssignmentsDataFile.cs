using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFMT.ASAC.DAL;
using WFMT.ASAC.Models;

namespace WFMT.ASAC.DAL
{
    class SkillAssignmentsDataFile
    {
        public string FilePath { get; set; }
        public IEnumerable<AgentSkillAssignmentsData> AssignmentsData { get; set; }
    }
}

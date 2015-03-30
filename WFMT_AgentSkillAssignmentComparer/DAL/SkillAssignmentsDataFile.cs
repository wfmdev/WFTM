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
        public List<AgentSkillMapping> AsRelational() 
        {
            List<AgentSkillMapping> temp = new List<AgentSkillMapping>();
            foreach (var entry in AssignmentsData)
            {
                foreach (var assignment in entry.AssignedSkills())
                {
                    temp.Add(new AgentSkillMapping() { AgentID = entry.Login_ID, AgentName = entry.Name, SkillID = assignment.Skill_ID, Priority = assignment.Priority });
                }
            }

            return temp;
        }
    }
}

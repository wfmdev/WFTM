using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace WFMT_AgentSkillAssignmentComparer.Models
{
    class AgentSkillAssignment
    {
        [CsvColumn(Name = "Login ID", FieldIndex = 1)]
        public int Login_ID { get; set; }

        [CsvColumn(Name = "Name", FieldIndex = 2)]
        public string Name { get; set; }

        [CsvColumn(Name = "Skill ID", FieldIndex = 3)]
        public int Skill_ID { get; set; }

        [CsvColumn(Name = "Priority", FieldIndex = 4)]
        public string Priortiy { get; set; }
    }
}

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
        [CsvColumn(FieldIndex = 1)]
        public int AGENT_ID { get; set; }
        [CsvColumn(FieldIndex = 2)]
        public string Extn { get; set; }
        [CsvColumn(FieldIndex = 3)]
        public string AGENT_NAME { get; set; }
        [CsvColumn(FieldIndex = 4)]
        public int COR { get; set; }
        [CsvColumn(FieldIndex = 5)]
        public int SKILL_ID { get; set; }
        [CsvColumn(FieldIndex = 6)]
        public string Priority { get; set; }
        [CsvColumn(FieldIndex = 7)]
        public string Skill_Grouping { get; set; }
        [CsvColumn(FieldIndex = 8)]
        public string UID { get; set; }
    }
}

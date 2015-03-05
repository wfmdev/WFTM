using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;



namespace WFMT_AgentSkillAssignmentComparer.Models
{
    class AgentSkillAssignmentComparison : AgentSkillAssignment
    {
        [CsvColumn(FieldIndex = 9)]
        public int SKILL_ID_B { get; set; }
        [CsvColumn(FieldIndex = 10)]
        public string Priority_B { get; set; }
        [CsvColumn(FieldIndex = 11)]
        public string Comparison { get; set; }
    }
}

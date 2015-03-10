using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace WFMT_AgentSkillAssignmentComparer.Models
{
    class SkillAssignmentComparison
    {
        [CsvColumn(Name = "Difference", FieldIndex = 1)]
        public string Difference { get; set; }

        [CsvColumn(Name = "Login ID", FieldIndex = 2)]
        public int Login_ID { get; set; }

        [CsvColumn(Name = "Name", FieldIndex = 3)]
        public string Name { get; set; }

        [CsvColumn(Name = "Skill ID", FieldIndex = 4)]
        public int Skill_ID { get; set; }

        [CsvColumn(Name = "Priority", FieldIndex = 5)]
        public string Priortiy { get; set; }

        [CsvColumn(Name = "Skill ID B", FieldIndex = 6)]
        public int Skill_ID_B { get; set; }

        [CsvColumn(Name = "Priority B", FieldIndex = 7)]
        public string Priortiy_B { get; set; }
    }
}

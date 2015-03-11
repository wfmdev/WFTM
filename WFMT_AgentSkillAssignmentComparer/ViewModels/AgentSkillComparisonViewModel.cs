using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;
using WFMT_AgentSkillAssignmentComparer.Models;

namespace WFMT_AgentSkillAssignmentComparer.ViewModels
{
    public class AgentSkillComparisonViewModel
    {
        [CsvColumn(Name = "Difference", FieldIndex = 1)]
        public string Difference { get; set; }

        [CsvColumn(Name = "Login ID", FieldIndex = 2)]
        public int Login_ID { get; set; }

        [CsvColumn(Name = "Name", FieldIndex = 3)]
        public string Name { get; set; }

        [CsvColumn(Name = "Original Skill", FieldIndex = 4)]
        public int OriginalSkill { get; set; }

        [CsvColumn(Name = "Original Priority", FieldIndex = 5)]
        public string OriginalPriority { get; set; }

        [CsvColumn(Name = "New Skill", FieldIndex = 6)]
        public int NewSkill { get; set; }

        [CsvColumn(Name = "New Priority", FieldIndex = 7)]
        public string NewPriority { get; set; }
    }
}

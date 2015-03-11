using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace WFMT_AgentSkillAssignmentComparer.Models
{
    public class SkillAssignmentDataComparison
    {
        [CsvColumn(Name = "Difference", FieldIndex = 1)]
        public string Difference { get; set; }

        [CsvColumn(Name = "Login ID", FieldIndex = 2)]
        public int Login_ID { get; set; }

        [CsvColumn(Name = "Name", FieldIndex = 3)]
        public string Name { get; set; }

        [CsvColumn(Name = "Assignments", FieldIndex = 4)]
        public string Assignments { get; set; }

        [CsvColumn(Name = "Assignments B", FieldIndex = 5)]
        public string Assignments_B { get; set; }

        public string UID { get { return Login_ID.ToString() + " - " + Assignments + Assignments_B; } }
    }
}

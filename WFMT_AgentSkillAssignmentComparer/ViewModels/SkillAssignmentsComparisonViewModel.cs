using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;
using WFMT_AgentSkillAssignmentComparer.Models;

namespace WFMT_AgentSkillAssignmentComparer.ViewModels
{
    public class SkillAssignmentsComparisonViewModel
    {
        [CsvColumn(Name = "Difference", FieldIndex = 1)]
        public string Difference { get; set; }

        [CsvColumn(Name = "Login ID", FieldIndex = 2)]
        public int Login_ID { get; set; }

        [CsvColumn(Name = "Name", FieldIndex = 3)]
        public string Name { get; set; }

        [CsvColumn(Name = "Original Assignments", FieldIndex = 4)]
        public string OriginalAssignments { get; set; }

        [CsvColumn(Name = "New Assignments", FieldIndex = 5)]
        public string NewAssignments { get; set; }

        public SkillAssignmentsComparisonViewModel()
        {
        }

        public SkillAssignmentsComparisonViewModel(SkillAssignmentDataComparison sadc)
        {
            Difference = sadc.Difference;
            Login_ID = sadc.Login_ID;
            Name = sadc.Name;
            OriginalAssignments = sadc.Assignments;
            NewAssignments = sadc.Assignments_B;
        }
    }
}

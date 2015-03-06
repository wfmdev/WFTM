using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;
using WFMT_AgentSkillAssignmentComparer.Models;

namespace WFMT_AgentSkillAssignmentComparer.ViewModels
{
    class AgentSkillAssignmentViewModel
    {
        [CsvColumn(Name = "Comparison Note", FieldIndex = 1)]
        public string ComparisonNote { get; set; }
        [CsvColumn(Name = "Login ID", FieldIndex = 2)]
        public int Login_ID { get; set; }
        [CsvColumn(Name = "Extn", FieldIndex = 3)]
        public string Extn { get; set; }
        [CsvColumn(Name = "Name", FieldIndex = 4)]
        public string Name { get; set; }
        [CsvColumn(Name = "Assigned Skills", FieldIndex = 5)]
        public SkillPriority[] AssignedSkills { get; set; }
        [CsvColumn(Name = "Assigned Skills String", FieldIndex = 6)]
        public string AssignedSkillsString { get; set; }

        public AgentSkillAssignmentViewModel() 
        {
        }

        public AgentSkillAssignmentViewModel(AgentSkillAssignmentsData asa)
        {
            Login_ID = asa.Login_ID;
            Extn = asa.Extn;
            Name = asa.Name;
            AssignedSkills = asa.AssignedSkills();
            AssignedSkillsString = asa.AssignedSkillsString();
        }
    }
}

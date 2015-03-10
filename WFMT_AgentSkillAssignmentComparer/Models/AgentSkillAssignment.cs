﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace WFMT_AgentSkillAssignmentComparer.Models
{
    class AgentSkillAssignment
    {
        [CsvColumn(Name = "Composite ID", FieldIndex = 1)]
        public string Composite_ID { get { return Login_ID.ToString() + Skill_ID.ToString() + Priortiy; } }

        [CsvColumn(Name = "Login ID", FieldIndex = 2)]
        public int Login_ID { get; set; }

        [CsvColumn(Name = "Name", FieldIndex = 3)]
        public string Name { get; set; }

        [CsvColumn(Name = "Skill ID", FieldIndex = 4)]
        public int Skill_ID { get; set; }

        [CsvColumn(Name = "Priority", FieldIndex = 5)]
        public string Priortiy { get; set; }
    }
}

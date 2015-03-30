using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace WFMT.ASAC.Models
{
    class AgentSkillMapping
    {
        [CsvColumn(Name = "Version", FieldIndex = 1)]
        public string Version { get; set; }

        [CsvColumn(Name = "AgentID", FieldIndex = 2)]
        public int AgentID { get; set; }

        [CsvColumn(Name = "AgentName", FieldIndex = 3)]
        public string AgentName { get; set; }

        [CsvColumn(Name = "SkillID", FieldIndex = 4)]
        public int SkillID { get; set; }

        [CsvColumn(Name = "SkillName", FieldIndex = 5)]
        public string SkillName { get; set; }

        [CsvColumn(Name = "Priority", FieldIndex = 6)]
        public string Priority { get; set; }

        [CsvColumn(Name = "CompositeID", FieldIndex = 7)]
        public string CompositeID { get { return AgentID.ToString() + SkillID.ToString() + Priority; } }
    }
}

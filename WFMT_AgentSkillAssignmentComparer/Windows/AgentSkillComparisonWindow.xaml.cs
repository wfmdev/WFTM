using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WFMT.ASAC.ViewModels;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using WFMT.ASAC.DAL;
using WFMT.ASAC.Models;

namespace WFMT.ASAC
{
    /// <summary>
    /// Interaction logic for AgentSkillComparisonWindow.xaml
    /// </summary>
    public partial class AgentSkillComparisonWindow : Window
    {
        //public SkillAssignmentsComparisonViewModel AgentSkillComparisonData { get; set; }
        //public ObservableCollection<AgentSkillComparisonViewModel> AgentSkillComparisonDisplayList { get; set; }

        //public AgentSkillComparisonWindow(SkillAssignmentsComparisonViewModel sacvm)
        //{
        //    InitializeComponent();
        //    AgentSkillComparisonData = sacvm;
        //    AgentSkillComparisonDisplayList = new ObservableCollection<AgentSkillComparisonViewModel>();
        //    Dtg_AgentSkillComparisonDisplay.ItemsSource = AgentSkillComparisonDisplayList;
        //    Dictionary<int, string> OriginalAssignments = new Dictionary<int, string>();
        //    Dictionary<int, string> NewAssignments = new Dictionary<int, string>();

        //    //Push assignments to dictionary
        //    if (AgentSkillComparisonData.OriginalAssignments != null)
        //    {
        //        string[] temp1 = AgentSkillComparisonData.OriginalAssignments.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        //        OriginalAssignments = temp1.Select(
        //            item => item.Split(':')).ToDictionary(
        //            s => int.Parse(s[0]),
        //            s => s[1]);
        //    }
        //    if (AgentSkillComparisonData.NewAssignments != null)
        //    {
        //        string[] temp2 = AgentSkillComparisonData.NewAssignments.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        //        NewAssignments = temp2.Select(
        //            item => item.Split(':')).ToDictionary(
        //            s => int.Parse(s[0]),
        //            s => s[1]);
        //    }

        //    OriginalAssignments.ToList().ForEach(
        //        x => AgentSkillComparisonDisplayList.Add(new AgentSkillComparisonViewModel() 
        //        {
        //            Difference = "Removed", //Assume removed and correct in subsequent passes
        //            Login_ID = sacvm.Login_ID,
        //            Name = sacvm.Name,
        //            OriginalSkill = x.Key,
        //            OriginalPriority = x.Value
        //        }));

        //    foreach (var item in AgentSkillComparisonDisplayList)
        //    {
        //        if (NewAssignments.ToList().Exists(x => (x.Key == item.OriginalSkill) && (x.Value == item.OriginalPriority)))
        //        {
        //            item.Difference = "None"; //Correct "removed" from earlier pass
        //            item.NewSkill = item.OriginalSkill;
        //            item.NewPriority = item.OriginalPriority;
        //        }
        //        else if (NewAssignments.ToList().Exists(x => (x.Key == item.OriginalSkill) && (x.Value != item.OriginalPriority)))
        //        {
        //            item.Difference = "New Priority";
        //            item.NewSkill = item.OriginalSkill;
        //            item.NewPriority = NewAssignments.Where(x => (x.Key == item.OriginalSkill) && (x.Value != item.OriginalPriority)).First().Value;
        //        }
        //    }

        //    foreach (var item in NewAssignments)
        //    {
        //        if (!AgentSkillComparisonDisplayList.ToList().Exists(x => (x.OriginalSkill == item.Key)))
        //        {
        //            AgentSkillComparisonDisplayList.Add(new AgentSkillComparisonViewModel()
        //            {
        //                Difference = "New Skill",
        //                Login_ID = sacvm.Login_ID,
        //                Name = sacvm.Name,
        //                NewSkill = item.Key,
        //                NewPriority = item.Value
        //            });
        //        }
        //    }
        //}
    }
}

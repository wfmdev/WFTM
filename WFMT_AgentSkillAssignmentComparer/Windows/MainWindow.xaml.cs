using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using LINQtoCSV;
using WFMT_AgentSkillAssignmentComparer.Models;
using WFMT_AgentSkillAssignmentComparer.ViewModels;
using WFMT_AgentSkillAssignmentComparer;
using Microsoft.Win32;
using System.Collections.ObjectModel;


namespace WFMT_AgentSkillAssignmentComparer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<SkillAssignmentsDataFile> LoadedFiles;
        ObservableCollection<string> LoadedFileNames;
        SkillAssignmentsDataFile SelectedFile_A;
        SkillAssignmentsDataFile SelectedFile_B;
        ObservableCollection<SkillAssignmentDataComparison> DataComparisonList;
        ObservableCollection<SkillAssignmentsComparisonViewModel> ComparisonDisplayList;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            LoadedFiles = new List<SkillAssignmentsDataFile>();
            LoadedFileNames = new ObservableCollection<string>();
            Lbx_LoadedFiles.ItemsSource = LoadedFileNames;
            Cbo_PickFile_A.ItemsSource = LoadedFileNames;
            Cbo_PickFile_B.ItemsSource = LoadedFileNames;
            DataComparisonList = new ObservableCollection<SkillAssignmentDataComparison>();
            ComparisonDisplayList = new ObservableCollection<SkillAssignmentsComparisonViewModel>();
            Dtg_ComparisonResult.ItemsSource = ComparisonDisplayList;
        }


        private void Btn_PickFile_Click(object sender, RoutedEventArgs e)
        {
            string fp = "";

            //Open dialog, pick the file....
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.DefaultExt = ".csv";
            ofd.Filter = "CSV Files (*.csv)|*.csv";

            Nullable<bool> result = ofd.ShowDialog();

            if (result == true)
            {
                fp = ofd.FileName;
            };

            if (fp.Length > 1)
            {
                //Read file and store contents
                CsvFileDescription inputFileDescription = new CsvFileDescription
                {
                    SeparatorChar = ',',
                    FirstLineHasColumnNames = true,
                    EnforceCsvColumnAttribute = true
                };

                CsvContext cc = new CsvContext();
                IEnumerable<AgentSkillAssignmentsData> AgentSkillAssignments =
                    cc.Read<AgentSkillAssignmentsData>(fp, inputFileDescription);

                SkillAssignmentsDataFile saf = new SkillAssignmentsDataFile();
                saf.FilePath = fp;
                saf.AssignmentsData = AgentSkillAssignments;

                LoadedFiles.Add(saf);
                LoadedFileNames.Add(saf.FilePath);
            }
        }


        private void Btn_CompareAvsB_Click(object sender, RoutedEventArgs e)
        {
            //Set file A & B based on combobox selecion
            if (LoadedFileNames.Contains(Cbo_PickFile_A.SelectedItem) && LoadedFileNames.Contains(Cbo_PickFile_B.SelectedItem))
            {
                foreach (var saf in LoadedFiles)
                {
                    if (saf.FilePath == Cbo_PickFile_A.SelectedItem)
                    {
                        SelectedFile_A = saf;
                    }
                    else if (saf.FilePath == Cbo_PickFile_B.SelectedItem)
                    {
                        SelectedFile_B = saf;
                    }
                }

                //Start fresh...
                ComparisonDisplayList.Clear();
                DataComparisonList.Clear();
                List<SkillAssignmentDataComparison> AssignmentData_A = new List<SkillAssignmentDataComparison>();
                List<SkillAssignmentDataComparison> AssignmentData_B = new List<SkillAssignmentDataComparison>();

                //Collect data from each file
                SelectedFile_A.AssignmentsData.ToList().ForEach(
                    x => AssignmentData_A.Add(new SkillAssignmentDataComparison() 
                    {
                        Login_ID = x.Login_ID,
                        Name = x.Name,
                        Assignments = x.AssignedSkillsString()
                    }));
                SelectedFile_B.AssignmentsData.ToList().ForEach(
                    x => AssignmentData_B.Add(new SkillAssignmentDataComparison()
                    {
                        Login_ID = x.Login_ID,
                        Name = x.Name,
                        Assignments = x.AssignedSkillsString()
                    }));

                //Compare and push to seperate lists
                List<SkillAssignmentDataComparison> Unchanged = AssignmentData_A.Where(x => AssignmentData_B.Any(y => (y.UID == x.UID))).ToList();
                List<SkillAssignmentDataComparison> RemovedOrChanged = AssignmentData_A.Where(x => !AssignmentData_B.Any(y => (y.UID == x.UID))).ToList();
                List<SkillAssignmentDataComparison> New = AssignmentData_B.Where(x => !AssignmentData_A.Any(y => (y.UID == x.UID))).ToList();

                //Merge lists to one comparison
                Unchanged.ForEach(x => DataComparisonList.Add(new SkillAssignmentDataComparison 
                {
                    Difference = "None",
                    Login_ID = x.Login_ID,
                    Name = x.Name,
                    Assignments = x.Assignments,
                    Assignments_B = x.Assignments
                }));

                RemovedOrChanged.ForEach(x => DataComparisonList.Add(new SkillAssignmentDataComparison
                {
                    Difference = "Removed or Changed",
                    Login_ID = x.Login_ID,
                    Name = x.Name,
                    Assignments = x.Assignments,
                }));

                New.ForEach(x => DataComparisonList.Add(new SkillAssignmentDataComparison
                {
                    Difference = "Added or Changed",
                    Login_ID = x.Login_ID,
                    Name = x.Name,
                    Assignments_B = x.Assignments
                }));

                //Push comparison to view list
                DataComparisonList.ToList().ForEach(x => ComparisonDisplayList.Add(new SkillAssignmentsComparisonViewModel(x)));

                #region Unperformant code 2
                

                ////Start fresh...
                //ComparisonDisplayList.Clear();
                //DataComparison = new List<SkillAssignmentComparison>();
                //Assignments_A = new List<AgentSkillAssignment>();
                //Assignments_B = new List<AgentSkillAssignment>();


                ////Collect assignments

                ////Old file
                //Debug.WriteLine("Reading in old file... " + DateTime.Now.ToString("h:mm:ss tt"));
                //SelectedFile_A.AssignmentsData.ToList().ForEach(
                //    x => x.AssignedSkills().ToList().ForEach(
                //        y => Assignments_A.Add(new AgentSkillAssignment() {
                //            Login_ID = x.Login_ID,
                //            Name = x.Name,
                //            Skill_ID = y.Skill_ID,
                //            Priortiy = y.Priority
                //        })));
                //Debug.WriteLine("Old file done... " + DateTime.Now.ToString("h:mm:ss tt"));
                ////New file
                //Debug.WriteLine("Reading in new file... " + DateTime.Now.ToString("h:mm:ss tt"));
                //SelectedFile_B.AssignmentsData.ToList().ForEach(
                //    x => x.AssignedSkills().ToList().ForEach(
                //        y => Assignments_B.Add(new AgentSkillAssignment() {
                //            Login_ID = x.Login_ID,
                //            Name = x.Name,
                //            Skill_ID = y.Skill_ID,
                //            Priortiy = y.Priority
                //        })));
                //Debug.WriteLine("New file done... " + DateTime.Now.ToString("h:mm:ss tt"));



                ////Comparison
                //List<AgentSkillAssignment> NotChanged = new List<AgentSkillAssignment>();
                //List<AgentSkillAssignment> PriorityChanged = new List<AgentSkillAssignment>();
                //List<AgentSkillAssignment> Removed = new List<AgentSkillAssignment>();
                //List<AgentSkillAssignment> New = new List<AgentSkillAssignment>();

                //Debug.WriteLine("Getting comparison lists... " + DateTime.Now.ToString("h:mm:ss tt"));
                ////Collect all entries existing unchanged in both lists
                //NotChanged = Assignments_A.Where(
                //    x => Assignments_B.Any(
                //        y => (y.Login_ID == x.Login_ID) 
                //            && (y.Skill_ID == x.Skill_ID) 
                //            && (y.Priortiy == x.Priortiy))).ToList();
                ////Collect all entries that exist in both lists with the priority changed
                //PriorityChanged = Assignments_A.Where(
                //    x => Assignments_B.Any(
                //        y => (y.Login_ID == x.Login_ID) 
                //            && (y.Skill_ID == x.Skill_ID) 
                //            && (y.Priortiy != x.Priortiy))).ToList();
                ////Collect all entries that appear in old file but not in th new file
                //Removed = Assignments_A.Where(
                //    x => !Assignments_B.Any(y => (y.Composite_ID == x.Composite_ID))).ToList();
                ////Collect all entries that appear in the new file but not in the old file
                //New = Assignments_B.Where(
                //    x => !Assignments_A.Any(y => (y.Composite_ID == x.Composite_ID))).ToList();
                //Debug.WriteLine("Comparison lists done " + DateTime.Now.ToString("h:mm:ss tt"));

                ////Push all entries to the comparison list for display
                //Debug.WriteLine("Pushing to display list... " + DateTime.Now.ToString("h:mm:ss tt"));
                //NotChanged.ToList().ForEach(
                //    x => ComparisonDisplayList.Add(new SkillAssignmentComparison() 
                //    { 
                //        Difference = "None",
                //        Login_ID = x.Login_ID,
                //        Name = x.Name,
                //        Skill_ID = x.Login_ID,
                //        Skill_ID_B = x.Skill_ID,
                //        Priortiy = x.Priortiy,
                //        Priortiy_B = x.Priortiy
                //    }));

                //PriorityChanged.ToList().ForEach(
                //    x => ComparisonDisplayList.Add(new SkillAssignmentComparison() 
                //    {
                //        Difference = "New Priority",
                //        Login_ID = x.Login_ID,
                //        Name = x.Name,
                //        Skill_ID_B = x.Skill_ID,
                //        Priortiy_B = x.Priortiy 
                //    }));

                //Removed.ToList().ForEach(
                //    x => ComparisonDisplayList.Add(new SkillAssignmentComparison()
                //    {
                //        Difference = "Removed",
                //        Login_ID = x.Login_ID,
                //        Name = x.Name,
                //        Skill_ID = x.Login_ID,
                //        Priortiy = x.Priortiy
                //    }));

                //New.ToList().ForEach(
                //    x => ComparisonDisplayList.Add(new SkillAssignmentComparison()
                //    {
                //        Difference = "Removed",
                //        Login_ID = x.Login_ID,
                //        Name = x.Name,
                //        Skill_ID_B = x.Skill_ID,
                //        Priortiy_B = x.Priortiy
                //    }));
                //Debug.WriteLine("Display list complete " + DateTime.Now.ToString("h:mm:ss tt"));
                #endregion
                #region Unperformant old comparison generation code


                ////Generate comparison
                ////First push everything from the original file into the comparison
                //Assignments_A.ForEach(
                //    x => DataComparison.Add(new SkillAssignmentComparison()
                //    {
                //        Login_ID = x.Login_ID,
                //        Name = x.Name,
                //        Skill_ID = x.Skill_ID,
                //        Priortiy = x.Priortiy,
                //        Skill_ID_B = 0,
                //        Priortiy_B = "",
                //        //Set presumed removed and correct when comparing to new file
                //        Difference = "Removed"
                //    }));

                ////Then push everything from the new file into the comparison
                ////And either: 
                ////Update the _B values if they already exist and where changed update difference to "changed"
                ////Update difference to "none" if there was no change
                ////Add the entry under _B values and set original values to 0 and "" and difference to "new" if the value is new
                //foreach (var item in DataComparison)
                //{
                //    SkillAssignmentComparison sac = new SkillAssignmentComparison();

                //    //If unchanged from old file, set difference to "None" and udpate _B attributes
                //    var NotChanged = Assignments_B.Where(
                //        x => (x.Login_ID == item.Login_ID) && (x.Skill_ID == item.Skill_ID) && (x.Priortiy == item.Priortiy));
                //    if (NotChanged.Count() > 0)
                //    {
                //        item.Difference = "None";
                //        item.Skill_ID_B = item.Skill_ID;
                //        item.Priortiy_B = item.Priortiy;
                //    }
                //    else
                //    {
                //        //If the priority changed, set differenc to "New Priority" and udpate _B attributes
                //        var PriorityChanged = Assignments_B.Where(
                //            x => (x.Login_ID == item.Login_ID) && (x.Skill_ID == item.Skill_ID) && (x.Priortiy != item.Priortiy));
                //        if (PriorityChanged.Count() > 0)
                //        {
                //            item.Difference = "Priority Changed";
                //            item.Skill_ID_B = PriorityChanged.First().Skill_ID;
                //            item.Priortiy_B = PriorityChanged.First().Priortiy;
                //        }
                //    }
                //}


                ////Now add all the items from the new file that do not appear in the old file.
                //foreach (var item in Assignments_B)
                //{
                //    var IsNew = DataComparison.Where(
                //        x => (x.Login_ID == item.Login_ID) && (x.Skill_ID == item.Skill_ID) && (x.Priortiy == item.Priortiy));
                //    if (IsNew.Count() == 0)
                //    {
                //        DataComparison.Add(new SkillAssignmentComparison()
                //        {
                //            Difference = "New Assignment",
                //            Login_ID = item.Login_ID,
                //            Name = item.Name,
                //            Skill_ID_B = item.Skill_ID,
                //            Priortiy_B = item.Priortiy
                //        });
                //    }
                //}


                //ComparisonDisplayList = (ObservableCollection<SkillAssignmentComparison>)DataComparison.AsEnumerable();


                #endregion
            }
        }


        private void Btn_ExportAvsB_Click(object sender, RoutedEventArgs e)
        {
            if (DataComparisonList.Count > 0)
            {
                string fp = "";

                //Open dialog, pick file export location
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = ".csv";
                sfd.Filter = "CSV Files (*.csv)|*.csv";

                

                try
                {
                    Nullable<bool> result = sfd.ShowDialog();
                    if (result == true)
                    {
                        fp = sfd.FileName;
                    }
                }
                catch (Exception)
                {
                    throw;
                }


                if (fp != "")
                {
                    //Export file
                    CsvFileDescription outputFileDescription = new CsvFileDescription
                    {
                        SeparatorChar = ',',
                        FirstLineHasColumnNames = true,
                        EnforceCsvColumnAttribute = true,
                        FileCultureName = "en-GB"
                    };

                    CsvContext cc = new CsvContext();
                    cc.Write(
                        ComparisonDisplayList.ToList(),
                        fp,
                        outputFileDescription);
                }

            }


        }


        private void Dtg_ComparisonResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SkillAssignmentsComparisonViewModel sacvm = (SkillAssignmentsComparisonViewModel)Dtg_ComparisonResult.SelectedItem;

            AgentSkillComparisonWindow ascw = new AgentSkillComparisonWindow(sacvm);
            ascw.Show();
        }


    }
}

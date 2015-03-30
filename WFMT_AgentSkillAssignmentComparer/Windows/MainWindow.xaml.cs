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
using WFMT.ASAC.Models;
using WFMT.ASAC.DAL;
using WFMT.ASAC;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using WFMT.ASAC.ViewModels;


namespace WFMT.ASAC
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
        SkillAssignmentsDataFile SelectedFileToView;
        HashSet<AgentSkillMapping> SkillMap_A;
        HashSet<AgentSkillMapping> SkillMap_B;
        ObservableCollection<AgentSkillMapping> ComparisonSkillMap;
        ObservableCollection<SkillAssignmentComparisonViewModel> ComparisonDisplayList;
        ObservableCollection<AgentSkillMapping> RelationalAssignments;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            LoadedFiles = new List<SkillAssignmentsDataFile>();
            LoadedFileNames = new ObservableCollection<string>();
            Lbx_LoadedFiles.ItemsSource = LoadedFileNames;
            Cbo_PickFile_A.ItemsSource = LoadedFileNames;
            Cbo_PickFile_B.ItemsSource = LoadedFileNames;
            Cbo_PickFileToView.ItemsSource = LoadedFileNames;
            SkillMap_A = new HashSet<AgentSkillMapping>();
            SkillMap_B = new HashSet<AgentSkillMapping>();
            ComparisonSkillMap = new ObservableCollection<AgentSkillMapping>();
            ComparisonDisplayList = new ObservableCollection<SkillAssignmentComparisonViewModel>();
            Dtg_ComparisonResult.ItemsSource = ComparisonDisplayList;
            RelationalAssignments = new ObservableCollection<AgentSkillMapping>();
            Dtg_FileView.ItemsSource = RelationalAssignments;
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
                ComparisonSkillMap.Clear();

                //Consolidate assignments
                foreach (var agent in SelectedFile_A.AssignmentsData)
                {
                    foreach (var assignment in agent.AssignedSkills())
                    {
                        ComparisonSkillMap.Add(new AgentSkillMapping() 
                        { 
                            Version = SelectedFile_A.FilePath,
                            AgentID = agent.Login_ID,
                            AgentName = agent.Name,
                            SkillID = assignment.Skill_ID,
                            Priority = assignment.Priority
                        });
                    }
                }
                foreach (var agent in SelectedFile_B.AssignmentsData)
                {
                    foreach (var assignment in agent.AssignedSkills())
                    {
                        ComparisonSkillMap.Add(new AgentSkillMapping()
                        {
                            Version = SelectedFile_A.FilePath,
                            AgentID = agent.Login_ID,
                            AgentName = agent.Name,
                            SkillID = assignment.Skill_ID,
                            Priority = assignment.Priority
                        });
                    }
                }

                //
            }
        }


        private void Btn_ExportAvsB_Click(object sender, RoutedEventArgs e)
        {
            if (ComparisonSkillMap.Count > 0)
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
            //SkillAssignmentsComparisonViewModel sacvm = (SkillAssignmentsComparisonViewModel)Dtg_ComparisonResult.SelectedItem;

            //AgentSkillComparisonWindow ascw = new AgentSkillComparisonWindow(sacvm);
            //ascw.Show();
        }

        private void Btn_ViewFile_Click(object sender, RoutedEventArgs e)
        {
            if (Cbo_PickFileToView.SelectedItem != null && LoadedFileNames.Contains(Cbo_PickFileToView.SelectedItem))
            {
                //Start Fresh
                RelationalAssignments.Clear();
                

                foreach (var file in LoadedFiles)
                {
                    if (file.FilePath == Cbo_PickFileToView.SelectedItem)
                    {
                        SelectedFileToView = file;
                    }
                }

                SelectedFileToView.AsRelational().ForEach(x => RelationalAssignments.Add(x));
                Dtg_FileView.Items.Refresh();
            }
        }

        private void Btn_ExportFile_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Dtg_FileView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}

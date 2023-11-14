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

namespace Yakira_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    private void DisplayStudents()
    {

        rtbDisplay.Text = ""; // Clear the Rich Text Box

        // Loop through List
        for (int i = 0; i < studentNames.Count; i++)
        {
            // Append Index, name, and new line to rtbDisplay
            rtbDisplay.Text += $"{i} - {studentNames[i]}\n";
        }

        // Display current student count
        lblCurrentCount.Content = $"Student Count: {studentNames.Count}";
    }
    public partial class MainWindow : Window
    {
        List<string> studentNames = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            studentNames.Add("Will");
            studentNames.Add("Dylan");
            studentNames.Add("Hannah");
            studentNames.Add("Kristyn");
            studentNames.Add("Samantha");

            DisplayStudents();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            studentNames.Add(txtStudentName.Text);
            DisplayStudents();
        }
    }
}

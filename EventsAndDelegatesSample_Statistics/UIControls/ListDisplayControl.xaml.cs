using System;
using System.Windows;
using System.Windows.Controls;
using EventsAndDelegatesSample_Statistics.Classes;

namespace EventsAndDelegatesSample_Statistics.UIControls
{
    /// <summary>
    /// Interaction logic for ListDisplayControl.xaml
    /// </summary>
    public partial class ListDisplayControl : UserControl
    {
        public RegistrationList RegistrationList { get; set; }

        public ListDisplayControl()
        {
            InitializeComponent();
        }

        public void RegistrationList_ChangedEventHandler(RegistrationList list)
        {
            this.listViewRegistrationList.ItemsSource = list.AllStudents;
        }

        private void BtnAddNew_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                AddStudentDialog dlg = new AddStudentDialog();
                dlg.Owner = (App.Current as App).MainWindow;
                dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                if (dlg.ShowDialog() == true)
                {
                    RegistrationList.RegisterStudent(dlg.Name, dlg.Gender.Value, dlg.Mark.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteSelected_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var selectedStudent = listViewRegistrationList.SelectedItem as Student;
            if (selectedStudent != null)
            {
                RegistrationList.DeleteStudent(selectedStudent);
            }
        }
    }
}

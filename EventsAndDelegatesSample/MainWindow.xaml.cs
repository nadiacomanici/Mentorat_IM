using System.Windows;
using EventsAndDelegatesSample_StudentName.Classes;

namespace EventsAndDelegatesSample_StudentName
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student student;

        public MainWindow()
        {
            InitializeComponent();
            student = new Student("Popescu");
            labelName.Content = student.Name;

            // subscriberul se ataseaza/inregistreaza/subscrie/abonare la eveniment
            student.OnNameChanged += Student_OnNameChanged;
        }

        // event handler la nivel de subscriber
        private void Student_OnNameChanged(string oldName, string newName)
        {
            labelName.Content = newName;
        }

        private void Student_OnNameChanged_WithMessageBox(string oldName, string newName)
        {
            MessageBox.Show(newName);            
        }

        private void btnAppendName_Click(object sender, RoutedEventArgs e)
        {
            student.Name += " Ion";
        }

        private void BtnAbonareCuMessageBox_Click(object sender, RoutedEventArgs e)
        {
            // te poti inregistra de mai multe ori la un eveniment => se va apela de mai mutle ori event handler-ul
            student.OnNameChanged += Student_OnNameChanged_WithMessageBox;
        }

        private void BtnDezbonareCuMessageBox_Click(object sender, RoutedEventArgs e)
        {
            student.OnNameChanged -= Student_OnNameChanged_WithMessageBox;
        }
    }
}

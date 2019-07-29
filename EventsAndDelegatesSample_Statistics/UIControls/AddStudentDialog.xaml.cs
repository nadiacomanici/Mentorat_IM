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
using System.Windows.Shapes;
using EventsAndDelegatesSample_Statistics.Classes;

namespace EventsAndDelegatesSample_Statistics.UIControls
{
    /// <summary>
    /// Interaction logic for AddStudentDialog.xaml
    /// </summary>
    public partial class AddStudentDialog : Window
    {
        public string Name { get; private set; }
        public double? Mark { get; private set; }
        public Gender? Gender { get; private set; }

        public AddStudentDialog()
        {
            InitializeComponent();
            Name = null;
            Mark = null;
            Gender = null;
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    throw new ArgumentException("You should specify the name");
                }
                Name = txtName.Text;
                Mark = double.Parse(txtAdmissionMark.Text);
                Gender = (radioMan.IsChecked == true) ? Classes.Gender.Man : Classes.Gender.Woman;
                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

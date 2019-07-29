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
using EventsAndDelegatesSample_Statistics.Classes;

namespace EventsAndDelegatesSample_Statistics.UIControls
{
    /// <summary>
    /// Interaction logic for GenderStatisticsControl.xaml
    /// </summary>
    public partial class GenderStatisticsControl : UserControl
    {
        public GenderStatisticsControl()
        {
            InitializeComponent();
        }

        public void RegistrationList_ChangedEventHandler(RegistrationList list)
        {
            this.textBlockMen.Text = list.AllStudents.Where(s => s.Gender == Gender.Man).Count().ToString();
            this.textBlockWomen.Text = list.AllStudents.Where(s => s.Gender == Gender.Woman).Count().ToString();
        }
    }
}

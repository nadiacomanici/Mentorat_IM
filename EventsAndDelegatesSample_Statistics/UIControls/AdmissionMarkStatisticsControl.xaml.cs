using System.Windows.Controls;
using EventsAndDelegatesSample_Statistics.Classes;

namespace EventsAndDelegatesSample_Statistics.UIControls
{
    /// <summary>
    /// Interaction logic for AdmissionMarkStatisticsControl.xaml
    /// </summary>
    public partial class AdmissionMarkStatisticsControl : UserControl
    {
        public AdmissionMarkStatisticsControl()
        {
            InitializeComponent();
        }

        public void RegistrationList_ChangedEventHandler(RegistrationList list)
        {
            this.textBlockAverage.Text = list.AverageAdmissionMark.ToString("N2");
        }
    }
}

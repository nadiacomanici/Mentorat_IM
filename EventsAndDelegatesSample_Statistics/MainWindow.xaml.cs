using System.Windows;
using EventsAndDelegatesSample_Statistics.Classes;

namespace EventsAndDelegatesSample_Statistics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RegistrationList _registrationList;

        public MainWindow()
        {
            InitializeComponent();
            _registrationList = new RegistrationList();

            ctrlDisplayList.RegistrationList = _registrationList;
            _registrationList.RegistrationListChangeEvent += ctrlDisplayList.RegistrationList_ChangedEventHandler;
            _registrationList.RegistrationListChangeEvent += ctrlAdmissionStatistics.RegistrationList_ChangedEventHandler;
            _registrationList.RegistrationListChangeEvent += ctrlGenderStatistics.RegistrationList_ChangedEventHandler;

            _registrationList.RegisterStudent("Nadia Comanici", Gender.Woman, 10);
            _registrationList.RegisterStudent("Maria Popescu", Gender.Woman, 9.5);
            _registrationList.RegisterStudent("Andrei Ionescu", Gender.Man, 8);
            _registrationList.RegisterStudent("Valentin Pop", Gender.Man, 8.6);
        }
    }
}

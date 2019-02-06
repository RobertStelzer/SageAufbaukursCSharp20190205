using SageAufbaukursCSharp.Services;
using SageAufbaukursCSharp.ServiceImplementations;
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
using System.ComponentModel;
using SageAufbaukursCSharp.ViewModels;
namespace SageAufbaukursCSharp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window//, INotifyPropertyChanged
    {
        //#region INotifyPropertyChanged
        //public event PropertyChangedEventHandler PropertyChanged;
        //# endregion INotifyPropertyChanged

        //#region services
        //private readonly IPartnerUtil _partnerUtilService = new PartnerUtilDummy();
        //#endregion services

        //public bool? DreiZustände = null;

        //#region public properties
        //public bool IsConnected { get; set; } //für Binding getter und setter public
        //#endregion public properties

        #region fields

        #endregion fields

        //public void NotifyPropertyChanged(string nameProp)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProp));
        //}

        public MainWindow()
        {
            DataContext = new MainWindowViewModel(); //this;
            InitializeComponent();
        }

        //private void TestInterface(object sender, RoutedEventArgs e)
        //{
        //    //if (_partnerUtilService.IsConnected)
        //    //{
        //    //    tb.Text = "\"Alles super\""; //Escape Sequence auch mit @ am Anfang
        //    //}
        //    //else
        //    //{
        //    //    tb.Text = "\"Nicht super\"";
        //    //}
        //    //refactoring
        //    //IsConnected = _partnerUtilService.IsConnected;

        //    e.Handled = true;
        //}

        //private bool _toogle;



        //private void ToggleArgument(object sender, RoutedEventArgs e)
        //{
        //    //var impl = (PartnerUtilDummy)_partnerUtilService;
        //    //impl.TestState = _toogle;
        //    //IsConnected = _partnerUtilService.IsConnected;
        //    //NotifyPropertyChanged(nameof(IsConnected));
        //    _toogle = !_toogle;
        //    e.Handled = true;
        //}
    }
}

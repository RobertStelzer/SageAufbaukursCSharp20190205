using SageAufbaukursCSharp.ServiceImplementations;
using SageAufbaukursCSharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SageAufbaukursCSharp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region public properties
        private bool _isConnected;
        public bool IsConnected
        {
            get { return _isConnected; }
            set
            {
                _isConnected = value;
                NotifyPropertyChanged();  //nameof(IsConnected) brauch ich hier nicht, nimmt er von oben
            } //für Binding getter und setter public
        }
        #endregion public properties}

        #region services
        private readonly IPartnerUtil _partnerUtilService = new PartnerUtilDummy();
        #endregion services

        #region commands
        public ActionCommand ToggleArgumentCommand { get; set; }
        public ActionCommand IrgendwasCommand { get; }
        #endregion commands

        #region constructors
        public MainWindowViewModel()
        {
            ToggleArgumentCommand = new ActionCommand
                (
                    x => true, 
                    (x) => 
                    {
                        ;
                    }
                );

            IrgendwasCommand = new ActionCommand
                (
                    x => true,
                    (x) =>
                    {
                        ;
                    }
                );
        }


        #endregion constructors
    }
}

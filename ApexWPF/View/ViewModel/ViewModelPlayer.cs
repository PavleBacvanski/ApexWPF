using ApexWPF.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexWPF.View.ViewModel
{
    public class ViewModelPlayer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyProperyChange(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        private string platform;
        public string Platform
        {
            get { return platform; }
            set { platform = value; Constants.Platform = value; NotifyProperyChange("Platform"); }
        }

        private string playerName;
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; NotifyProperyChange("PlayerName"); }
        }
    }
}

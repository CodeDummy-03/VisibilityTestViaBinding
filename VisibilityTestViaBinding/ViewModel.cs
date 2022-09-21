using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VisibilityTestViaBinding
{
    public class ViewModel:INotifyPropertyChanged
    {
        Visibility textblockVisibility;
        public Visibility TextblockVisibility
        {
            get { return textblockVisibility; }
            set {
                textblockVisibility = value;
                NotifyPropertyChanged("TextblockVisibility");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}

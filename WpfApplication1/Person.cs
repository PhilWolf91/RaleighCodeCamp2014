using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace WpfApplication1
{
    class Person : INotifyPropertyChanged
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string _personName;
        private int _magicNumber;
        private int _numsAdded;
        private int _numsMultiplied;

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int NumsAdded 
        {
            get { return _numsAdded; }
            set
            {
                _numsAdded = value;
                OnPropertyChanged();
            }
        }
        public int NumsMultiplied 
        {
            get { return _numsMultiplied; }
            set
            {
                _numsMultiplied = value;
                OnPropertyChanged();
            }
        }

        public string PersonName
        {
            get { return _personName; }
            set
            {
                _personName = value;
                OnPropertyChanged();
            }
        }
        
        public int MagicNumber
        {
            get { return _magicNumber; }
            set
            {
                _magicNumber = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }

            logger.Info("New data entered");
        }
    }



}

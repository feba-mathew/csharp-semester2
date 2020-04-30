using System.ComponentModel;

namespace FinalProject.Models
{
    class User : IDataErrorInfo, INotifyPropertyChanged
    {
        private int houseId;
        private int houseNo;
        private string idError;

        public string IdError
        {
            get
            {
                return idError;
            }
            set
            {
                if (idError != value)
                {
                    idError = value;
                    OnPropertyChanged("IdError");
                }
            }
        }

        public int HouseId
        {
            get
            {
                return houseId;
            }
            set
            {
                if (houseId != value)
                {
                    houseId = value;
                    OnPropertyChanged("HouseId");
                }
            }
        }

        public int HouseNo
        {
            get
            {
                return houseNo;
            }
            set
            {
                if (houseNo != value)
                {
                    houseNo = value;
                    OnPropertyChanged("HouseNo");
                }
            }
        }

        // IDataErrorInfo interface
        public string Error
        {
            get
            {
                return idError;
            }
        }

        // IDataErrorInfo interface
        // Called when ValidatesOnDataErrors=True
        public string this[string columnName]
        {
            get
            {
                idError = "";
                switch (columnName)
                {
                    case "HouseId":
                        {
                            if (HouseId == 0)
                            {
                                idError = "House Id cannot be 0.";
                            }

                            break;
                        }
                }
                return Error;
            }
        }

        // INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
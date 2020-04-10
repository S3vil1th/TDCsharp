using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Model
{
    
    public class Depense : INotifyPropertyChanged
    {
        private string typeDepense;

        public int DepenseID { get; set; }
        public int Montant { get; set; }
        public string TypeDepense
        {
            get
            {
                return typeDepense;
            }

            set
            {
                typeDepense = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }
        public virtual Personne Personne { get; set; }
    }
}

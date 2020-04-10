using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Model
{
    
    public class Personne : INotifyPropertyChanged
    {
        private string prenom;
        private string nom;

        public int PersonneID { get; set; }
        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
                NotifyPropertyChanged();
            }
        }
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
                NotifyPropertyChanged();
            }
        }

        public virtual ICollection<Depense> Depenses { get; set; }
        public object[] DepenseID { get; internal set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }

       
    }
}

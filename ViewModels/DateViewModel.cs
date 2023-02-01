using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion4.ViewModels
{
    public class DateViewModel : INotifyPropertyChanged
    {
        DateTime _dateTime;
        Timer _timer;
        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime DateTime
        {
            get => _dateTime;
            set
            {
                //if(connectivity.NetworkAccess != NetworkAccess.Internet)
                //{
                //    //await Shell.Current.DisplayAlert("Problemas de conexion", $"Revisa tu conexion e intentalo nuevamente!", "");
                //    return;
                //}
                //else
                //{
                    if (_dateTime != value)
                    {
                        _dateTime = value;
                        OnPropertyChanged();
                    }
                //}

            }
        }

        public DateViewModel()
        {
            this.DateTime = DateTime.Now;
            _timer = new Timer(new TimerCallback((s) => this.DateTime = DateTime.Now), null, TimeSpan.Zero, TimeSpan.FromSeconds(1));


        }

        ~DateViewModel() => _timer.Dispose();

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion4.ViewModels
{

    public class ProductoViewModel : BaseViewModel
    {
        IConnectivity connectivity;
        IGeolocation geolocation;
        public ProductoViewModel(IConnectivity connectivity, IGeolocation   geolocation) {
            Title = "TODOS LOS PRODUCTOS";
            this.connectivity = connectivity;
            this.geolocation = geolocation;
        }

    }
}

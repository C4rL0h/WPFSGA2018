using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using ProyectoFinal.Model.View;

namespace ProyectoFinal.Model.ModelView
{
    class MainViewModel : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MainViewModel Instancia { get; set; }

        public MainViewModel()
        {
            this.Instancia = this;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if (parametro.Equals("Puestos")){
                PuestoView ventana = new PuestoView();
                ventana.ShowDialog();
            }
        }
    }
}

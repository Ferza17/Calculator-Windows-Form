using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorMVC.Models;
using CalculatorMVC.Views;
using CalculatorMVC.Controllers;

namespace CalculatorMVC {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Calculator model = new Calculator();
            CalculatorView view = new CalculatorView();
            CalculatorController ctrl = new CalculatorController( model,  view);
            ctrl.CreateView();

        }
    }
}

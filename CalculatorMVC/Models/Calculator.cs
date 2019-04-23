using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMVC.Controllers;
using CalculatorMVC.Views;

namespace CalculatorMVC.Models {
    class Calculator {
        private double _number1;
        private double _number2;


        public Calculator() { }
        public double getNumber1()
        {
            return _number1;
        }

        public void setNumber1(double number1)
        {
            this._number1 = number1;
        }

        public double getNumber2()
        {
            return this._number2;
        }

        public void setNumber2(double number2)
        {
            this._number2 = number2;
        }

        public double getValueOperatePerkalian()
        {
            return _number1 * _number2;
        }

        public double getValueOperateTambah()
        {
            return _number1 + _number2;
        }

        public double getValueOperateKurang()
        {
            return _number1 - _number2;
        }
        public double getValueOperateBagi()
        {
            return _number1 / _number2;
        }
    }
}

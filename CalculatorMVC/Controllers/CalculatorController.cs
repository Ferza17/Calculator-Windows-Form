using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMVC.Models;
using CalculatorMVC.Views;
using System.Windows.Forms;

namespace CalculatorMVC.Controllers {
    class CalculatorController {
        private  Calculator _model;
        private  CalculatorView _view;
        public bool _flag;
        public CalculatorController(Calculator model,CalculatorView view)
        {
            this._model = model;
            this._view = view;
        }

        public CalculatorController() {
            _flag = false;
            _model = new Calculator();
        }

        public void setNomor1(string nomor1)
        {
            _model.setNumber1(double.Parse(nomor1));
        }

        public double getNomor1() { return _model.getNumber1(); }

        public void setNomor2(string nomor2)
        {
            _model.setNumber2(double.Parse(nomor2));
        }

        public double getNomor2() { return _model.getNumber2(); }

        public double getValueOperatePerkalian(){ return _model.getValueOperatePerkalian(); }

        public double getValueOperateTambah(){ return _model.getValueOperateTambah(); }

        public double getValueOperateKurang() { return _model.getValueOperateKurang(); }

        public double getValueOperateBagi(){ return _model.getValueOperateBagi(); }


        public void CreateView()
        {
            Application.EnableVisualStyles();
            Application.Run(new CalculatorView());

        }

        public void CheckData(string number1 , string number2)
        {
            if(number1 == "")
            {
                _flag = false;
            }else if(number2 == "")
            {
                _flag = false;
            }
            else
            {
                _flag = true;
            }
        }
    }
}

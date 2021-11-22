using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCalculator
{
    class Cell:DataGridViewTextBoxCell
    {
        public double val;
        public string exp;
        bool is_empty = true;
        public Cell() 
        {
            val = 0;
            exp = "0";
        }
        public double Val
        {
            get { return val; }
            set { val = value; }
        }
        public string Exp
        {
            get { return exp; }
            set { exp = value; is_empty = false; }
        }
        public bool Is_empty
        {
            get { return is_empty; }
        }
         
        public void Recalculate()
        {
            var res = Calculator.Evaluate(exp);
            val = res;
        }
    }
}

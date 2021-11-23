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
        List<int> dependsFromMeRows = new List<int>();
        List<int> dependsFromMeColumns = new List<int>();
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
        public List<int> DependsFromMeRows
        {
            get {  return dependsFromMeRows; }
        }

        public List<int> DependsFromMeColumns
        {
            get { return dependsFromMeColumns; }
        }
        public void AddDependCell(int rowInd,int ColInd)
        {
            dependsFromMeRows.Add(rowInd);
            dependsFromMeColumns.Add(ColInd);
        }
        public void ClearDepends()
        {
            dependsFromMeRows.Clear();
            dependsFromMeColumns.Clear();
        }
         
        public void Recalculate()
        {
            var res = Calculator.Evaluate(exp);
            val = res;
        }
    }
}

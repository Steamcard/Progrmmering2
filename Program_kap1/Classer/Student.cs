using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classer
{
    class Student
    {
        //Variabler
        public string namn;



        //konstruktor
        public Student(string n)
        {
            this.namn = n;
        }


        public void printInfo()
        {
            MessageBox.Show("eleven heter" + this.namn);
        }


        public string getNamn()
        {
            return this.namn;
        }


        public string Namn
        {
            get
            {
                return this.namn;
            }
        }
    }
}

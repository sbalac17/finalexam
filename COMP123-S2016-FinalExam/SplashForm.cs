using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Shivya Balachandran
300 884 989 
Final Exam 
/*

namespace COMP123_S2016_FinalExam
{
  {
    /**
    * <summary>
    * This class contains the splash form
    * </summary>
    * 
    * @class SplashForm
    */
    public partial class SplashForm : Form
    {
        /**
        * <summary>
        * This constructor builds the splash form
        * </summary>
        * 
        * @constructor
        */
        public SplashForm()
        {
            InitializeComponent();

            // loads all the names
            Console.WriteLine(Name.Length);

         public Namess()
    {


    }
}
   

        /**
        * <summary>
        * This event handler will show the selection form 
        * </summary>
        * 
        * @method Timer_Tick
        * @param {object} sender
        * @param {EventArgs} e
        */
        private void Timer_Tick(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Show();

            this.Close();
        }
    }
}

}

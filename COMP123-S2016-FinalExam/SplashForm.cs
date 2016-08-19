using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public partial class SplashForm : GenerateNameForm
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
            GenerateNameForm form = new GenerateNameForm();
            form.Show();

            this.Close();
        }
    }
}

}

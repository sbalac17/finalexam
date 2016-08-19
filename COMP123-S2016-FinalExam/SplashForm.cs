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

      
    private void SplashForm_Load(object sender, EventArgs e)
    {

    }

    private void SplashForm_Load_1(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {

    }
}
// this is for the properties for the splashform
public void CreateMyBorderlessWindow()
{
    this.FormBorderStyle = FormBorderStyle.None;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    // Remove the control box so the form will only display area.
    this.ControlBox = false;
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
    Form form = new Form;
    form.Show();
    this.Close();

    SplashForm splashScreen = new SplashForm;
    splashScreen.Show();

    this.Close();
}
/**
* <summary>
* This event handler will show the splash form for 3 seconds  
* </summary>
* 
* @method Application_Launching
* @param {object} sender
* @param {EventArgs} e
*/

    //this will allow for the splash screen to display for 3000
private void Application_Launching(object sender, EventArgs e)
{
    System.Threading.Thread.Close(DateTime.Now.TimeOfDay.Seconds + 3000);
}
    }
}



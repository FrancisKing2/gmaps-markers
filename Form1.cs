using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GoogleDistance
{
    [ComVisible(true)]
    public partial class Form1 : Form
    {
        String JavaScriptURL = @"file:///C:/Users/fking/Desktop/JavascriptGoogleMaps.html";

        public Form1()
        {
            InitializeComponent();

            // Set up the browser
            webBrowser1.Navigate(JavaScriptURL);
            webBrowser1.ObjectForScripting = this;
        }

        public void Test(Single Latitude, Single Longitude)
        {
            MessageBox.Show("Latitude: " + Latitude + " , Longitude: " + Longitude);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the markers
            webBrowser1.Document.InvokeScript("clearMarkers");
        }
    }
}

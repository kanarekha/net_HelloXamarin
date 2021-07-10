using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorldXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;

        void ClickCounter(object sender, System.EventArgs e)

        {

            count++;

            ((Button)sender).Text = $"You clicked {count} times.";

        }
    }
}

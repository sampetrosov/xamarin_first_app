using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApplication
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, EventArgs e)
        {
            ResultLabel.Text = ResultInput.Text;
            (sender as Button).Text = ResultInput.Text;
        }
    }
}

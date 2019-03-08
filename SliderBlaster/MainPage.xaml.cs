using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SliderBlaster
{
    public partial class MainPage : ContentPage
    {
        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {

            label_roda.Rotation = slider_roda.Value;

            int labelValor = Convert.ToInt32(slider_roda.Value);

            label_valorDoSlider.Text = labelValor.ToString();

        }


        public MainPage()
        {
            InitializeComponent();
        }
    }
}

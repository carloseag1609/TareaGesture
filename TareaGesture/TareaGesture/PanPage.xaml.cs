using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaGesture
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PanPage : ContentPage
    {
        public PanPage(string imageUrl)
        {
            InitializeComponent();
            image.Source = imageUrl;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
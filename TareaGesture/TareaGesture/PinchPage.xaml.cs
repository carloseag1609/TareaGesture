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
    public partial class PinchPage : ContentPage
    {
        public PinchPage(string imageUrl)
        {
            InitializeComponent();
            image.Source = imageUrl;
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}
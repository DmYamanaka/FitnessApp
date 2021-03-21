using System.ComponentModel;
using Xamarin.Forms;
using App2.ViewModels;
using System;

namespace App2.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            double time = Convert.ToDouble(_lblTime.Text);
            timer(time);
        }
        private void timer(double time)
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () => {
                time -= 1;
                _lblTime.Text = String.Format("{0}", time);
                if (time == 0.00)
                {
                    DisplayAlert("Поздравляю!", "Вы стали на шаг ближе к своей цели!", "Ok");
                    return false;
                }

                return true;
            });
        }
    }
}
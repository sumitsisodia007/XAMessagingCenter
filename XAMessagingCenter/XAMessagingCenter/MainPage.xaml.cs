using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMessagingCenter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<TriggerMessage>(this, "Trigger", message =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    label.Text = message.Message;
                });
            });
        }

        private void start_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(new Start(), "Start");
        }
    }
}

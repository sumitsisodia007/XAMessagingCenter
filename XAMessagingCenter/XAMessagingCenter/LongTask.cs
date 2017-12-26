using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMessagingCenter
{
    public class Start { }
    public class TriggerMessage
    {
        public string Message { get; set; }
    }
    public class LongTask
    {
        public async Task RunCounter()
        {
            await Task.Run(async () =>
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    var message = new TriggerMessage()
                    {
                        Message = i.ToString()
                    };

                    // TODO:
                    // Delete Device.BeginInvokeOnMainThread();
                    //Device.BeginInvokeOnMainThread(() =>
                    //{
                    //    MessagingCenter.Send(message, "TrickedMessage");
                    //});                    
                    MessagingCenter.Send(message, "Trigger");

                    await Task.Delay(TimeSpan.FromSeconds(1));
                }
            });
        }
    }
}

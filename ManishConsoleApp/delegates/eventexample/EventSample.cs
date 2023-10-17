using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ManishConsoleApp.event_delegates.eventexample.VideoEncoder;

namespace ManishConsoleApp.event_delegates.eventexample
{
    public class EventSample
    {

        public static void Main()
        {
            var video = new Video() { Title = "Video 1"};
            var videoEncoder = new VideoEncoder();//publisher
            var mailService = new MailService();// subcriber
            var messageService = new MessageService();// subcriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}

namespace ManishConsoleApp.event_delegates.eventexample
{
   
        public class VideoEncoder
        {


        // 1- Define a delegate 
        // 2- Define an event based on that delegate
        // 3- raise an event


         public delegate void VideoEncodedEventHandler(object source,Video ars);

         public event VideoEncodedEventHandler VideoEncodedOld;

        public event EventHandler<Video> VideoEncoded; // current is shortcut of above

            public void Encode(Video video) 
            {
                Console.WriteLine("Encoding Video");
                Thread.Sleep(1000);
                if (VideoEncoded != null)
                    VideoEncoded(this, video);
        }
        }
    }


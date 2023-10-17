namespace ManishConsoleApp.event_delegates.eventexample
{
    public class MailService
    {
        public void OnVideoEncoded(object source, Video args)
        {
            Console.WriteLine("Mail Service: Sending a EMAIL "+ args.Title);
        }

    }
}

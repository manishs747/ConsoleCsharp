namespace ManishConsoleApp.event_delegates.eventexample
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, Video args)
        {
            Console.WriteLine("Message Service: Sending a text messge "+ args.Title);
        }

    }
}

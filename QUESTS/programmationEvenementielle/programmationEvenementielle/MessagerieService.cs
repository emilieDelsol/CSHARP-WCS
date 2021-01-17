using System;

namespace programmationEvenementielle
{
	partial class Program

    {
		public class MessagerieService
		{
            public void OnVideoEncoded(object source, VideoEventArgs args)
			{
				System.Console.WriteLine("MessageService: Sending  a text message.."+args.Video.Title);
			}
		}
    }


}

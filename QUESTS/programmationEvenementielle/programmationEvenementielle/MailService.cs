using System;

namespace programmationEvenementielle
{
	partial class Program

    {
		public class MailService
		{
            public void OnVideoencoded(object source, VideoEventArgs e)
			{
                Console.WriteLine("MailService: sending an email... "+e.Video.Title);
			}
		}
    }


}

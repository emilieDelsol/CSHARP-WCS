using System.Collections.Generic;
using System.Threading;

namespace programmationEvenementielle
{
	partial class Program

    {

        static void Main(string[] args)
        {
            var video = new Video() { Title = "video 1" };
            var videoEncoder = new Videoencoder();
            var mailService = new MailService();
            var messageService = new MessagerieService();
            videoEncoder.VideoEncoded += mailService.OnVideoencoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);

        }
    }


}

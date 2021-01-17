using System;
using System.Threading;

namespace programmationEvenementielle
{
	public class VideoEventArgs : EventArgs
	{
		public Video Video { get; set; }
	}
	internal class Videoencoder
	{
		public delegate void VideoEncodeEventHandler(object source, VideoEventArgs args);
		public event VideoEncodeEventHandler VideoEncoded;
		public void Encode(Video video)
		{
			Console.WriteLine("encoding video...");
			Thread.Sleep(3000);

			OnVideoEncoded(video);
		}
		protected virtual void OnVideoEncoded(Video video)
		{
			if (VideoEncoded!=null)
			{
				VideoEncoded(this, new VideoEventArgs() { Video = video });
			}
		}
	}
}
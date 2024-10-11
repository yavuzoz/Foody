using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.EntityLayer.Concrete
{
	public class SocialMedia
	{
		// Compare this snippet from Foody.EntityLayer/Concrete/SocialMedia.cs:
		public int SocialMediaId { get; set; }
		public string Title { get; set; }
		public string Url { get; set; }
		public string Icon { get; set; }
	}
}

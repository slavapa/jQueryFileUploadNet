using System.IO;
using System.Web;

namespace jQueryUploadTest {
	public class Thumbnail : IHttpHandler {

		public void ProcessRequest (HttpContext context)
		{
		    string fullName = Path.Combine(context.Request.PhysicalApplicationPath, "images/default_thumb.jpg");
			context.Response.ContentType = "image/jpg";

            context.Response.WriteFile(fullName);
		}

		public bool IsReusable { get { return false; } }
	}
}

using System.Text;
using System.Web;

namespace DTcms.Web.tools
{
    /// <summary>
    /// CascadeSelect 的摘要说明
    /// </summary>
    public class CascadeSelect : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("[");
            stringBuilder.Append("{\"selectId\":\"1\",\"selectName\":\"选项1\"},");
            stringBuilder.Append("{\"selectId\":\"2\",\"selectName\":\"选项2\"},");
            stringBuilder.Append("{\"selectId\":\"3\",\"selectName\":\"选项3\"},");
            stringBuilder.Append("{\"selectId\":\"4\",\"selectName\":\"选项4\"}");
            stringBuilder.Append("]");
            context.Response.Write(stringBuilder.ToString());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
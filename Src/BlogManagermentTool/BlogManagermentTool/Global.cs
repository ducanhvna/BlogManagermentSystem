using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogManagermentTool.BlogManagermentServiceReference;
namespace BlogManagermentTool
{
    static class Global
    {
        public static BlogAdminMangermentServiceClient ModelClient { get; internal set; } 
            = new BlogAdminMangermentServiceClient();
    }
}

using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace CodingWithCalvin.CouchbaseStudio
{
    [Guid("d7fbfae3-4b71-4507-86b0-0534e77d0292")]
    public class CouchbaseStudioWindow : ToolWindowPane
    {
        public CouchbaseStudioWindow()
            : base(null)
        {
            this.Caption = "Couchbase Studio";
            this.Content = new CouchbaseStudioWindowControl();
        }
    }
}

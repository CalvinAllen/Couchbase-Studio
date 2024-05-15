using System.Windows.Controls;

namespace CodingWithCalvin.CouchbaseStudio
{
    public partial class CouchbaseStudioWindowControl : UserControl
    {
        public CouchbaseStudioWindowControl()
        {
            this.InitializeComponent();
        }

        //private void addServerButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ServersTreeView.Items.Clear();

        //    var cluster = new Cluster(
        //        new ClientConfiguration
        //        {
        //            Servers = new List<Uri> { new Uri("http://localhost:8091") }
        //        }
        //    );
        //    cluster.Authenticate("Administrator", "password");
        //    var clusterMan = cluster.CreateManager("Administrator", "password");

        //    var rootNode = new TreeViewItem { Header = "localhost" };
        //    var queryNode = new TreeViewItem { Header = "Query" };
        //    rootNode.Items.Add(queryNode);

        //    var bucketsNode = new TreeViewItem { Header = "Buckets" };
        //    var buckets = clusterMan.ListBuckets().Value;
        //    foreach (var bucket in buckets)
        //    {
        //        var bucketNode = new TreeViewItem { Header = bucket.Name };
        //        bucketsNode.Items.Add(bucketNode);
        //    }
        //    rootNode.Items.Add(bucketsNode);

        //    ServersTreeView.Items.Add(rootNode);
        //}

        //private void QueryAll_OnClick(object sender, RoutedEventArgs e)
        //{
        //    var contextMenuItem = (MenuItem)sender;
        //    var selectedMenuItem = (TreeViewItem)ServersTreeView.SelectedItem;
        //    var bucketName = selectedMenuItem.Header.ToString();

        //    var cluster = new Cluster(
        //        new ClientConfiguration
        //        {
        //            Servers = new List<Uri> { new Uri("http://localhost:8091") }
        //        }
        //    );
        //    cluster.Authenticate("Administrator", "password");
        //    var clusterMan = cluster.CreateManager("Administrator", "password");

        //    var bucket = cluster.OpenBucket(bucketName);
        //    var query = QueryRequest.Create($"select META(tb).id, * from `{bucketName}` tb");

        //    var results = bucket.Query<dynamic>(query);

        //    foreach (var row in results.Rows)
        //    {
        //        MessageBox.Show(
        //            string.Format(
        //                System.Globalization.CultureInfo.CurrentUICulture,
        //                "Document:  '{0}'",
        //                row.ToString()
        //            ),
        //            "CouchbaseExplorerWindow"
        //        );
        //    }
        //}
    }
}

using System;
using System.Collections.Generic;
using Couchbase;
using Couchbase.Configuration.Client;

namespace CalvinAllen.CouchbaseVS.Vsix
{
	using System.Diagnostics.CodeAnalysis;
	using System.Windows;
	using System.Windows.Controls;

	/// <summary>
	/// Interaction logic for CouchbaseExplorerWindowControl.
	/// </summary>
	public partial class CouchbaseExplorerWindowControl : UserControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CouchbaseExplorerWindowControl"/> class.
		/// </summary>
		public CouchbaseExplorerWindowControl()
		{
			this.InitializeComponent();
		}

		/// <summary>
		/// Handles click on the button by displaying a message box.
		/// </summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event args.</param>
		[SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
		[SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
		private void button1_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(
				string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
				"CouchbaseExplorerWindow");
		}

        private void addServerButton_Click(object sender, RoutedEventArgs e)
        {
            ServersTreeView.Items.Clear();

            var cluster = new Cluster(new ClientConfiguration
            {
                Servers = new List<Uri> {new Uri("http://localhost:8091")}
            });
            cluster.Authenticate("Administrator", "password");
            var clusterMan = cluster.CreateManager("Administrator", "password");

            var rootNode = new TreeViewItem
            {
                Header = "localhost"
            };
            var queryNode = new TreeViewItem { Header = "Query"};
            rootNode.Items.Add(queryNode);

            var bucketsNode = new TreeViewItem { Header = "Buckets" };
            var buckets = clusterMan.ListBuckets().Value;
            foreach (var bucket in buckets)
            {
                var bucketNode = new TreeViewItem {Header = bucket.Name};
                bucketsNode.Items.Add(bucketNode);
            }
            rootNode.Items.Add(bucketsNode);

            ServersTreeView.Items.Add(rootNode);
        }
    }
}
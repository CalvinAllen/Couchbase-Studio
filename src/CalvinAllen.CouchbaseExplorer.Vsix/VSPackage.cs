using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace CalvinAllen.CouchbaseVS.Vsix
{
	[PackageRegistration(UseManagedResourcesOnly = true)]
	[InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
	[Guid(PackageGuidString)]
	[ProvideMenuResource("Menus.ctmenu", 1)]
	[ProvideToolWindow(typeof(CouchbaseExplorerWindow))]
	public sealed class VsPackage : Package
	{
		public const string PackageGuidString = "ef261503-b2ae-4b90-8c86-0becd83348cc";

		protected override void Initialize()
		{
            base.Initialize();
		    CouchbaseExplorerWindowCommand.Initialize(this);
		}
	}
}

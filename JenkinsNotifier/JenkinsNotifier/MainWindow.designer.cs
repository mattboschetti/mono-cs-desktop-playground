// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace JenkinsNotifier
{
	[Register ("MainWindow")]
	partial class MainWindow
	{
		[Outlet]
		MonoMac.AppKit.NSButton outletQualquer { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (outletQualquer != null) {
				outletQualquer.Dispose ();
				outletQualquer = null;
			}
		}
	}

	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSButton allJobsBtn { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton brokenJobsBtn { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField jenkinsLocation { get; set; }

		[Outlet]
		MonoMac.AppKit.NSScrollView jenkinsOutput { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton loadDataBtn { get; set; }

		[Outlet]
		MonoMac.AppKit.NSProgressIndicator progressIndicator { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (allJobsBtn != null) {
				allJobsBtn.Dispose ();
				allJobsBtn = null;
			}

			if (brokenJobsBtn != null) {
				brokenJobsBtn.Dispose ();
				brokenJobsBtn = null;
			}

			if (jenkinsLocation != null) {
				jenkinsLocation.Dispose ();
				jenkinsLocation = null;
			}

			if (jenkinsOutput != null) {
				jenkinsOutput.Dispose ();
				jenkinsOutput = null;
			}

			if (loadDataBtn != null) {
				loadDataBtn.Dispose ();
				loadDataBtn = null;
			}

			if (progressIndicator != null) {
				progressIndicator.Dispose ();
				progressIndicator = null;
			}
		}
	}
}

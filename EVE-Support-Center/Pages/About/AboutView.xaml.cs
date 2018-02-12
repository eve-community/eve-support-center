using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace EVE_Support_Center.Pages.About
{
	public sealed partial class AboutView : UserControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AboutView"/> class.
		/// </summary>
		public AboutView()
		{
			this.InitializeComponent();
			this.DataContext = new AboutViewModel();
		}
	}
}

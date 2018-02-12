using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace EVE_Support_Center.Pages.Support
{
	public sealed partial class SupportView : UserControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SupportView"/> class.
		/// </summary>
		public SupportView()
		{
			this.InitializeComponent();
			this.DataContext = new SupportViewModel();
		}
	}
}

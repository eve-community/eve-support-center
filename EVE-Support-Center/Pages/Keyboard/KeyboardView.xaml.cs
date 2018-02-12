using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace EVE_Support_Center.Pages.Keyboard
{
	public sealed partial class KeyboardView : UserControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="KeyboardView"/> class.
		/// </summary>
		public KeyboardView()
		{
			this.InitializeComponent();
			this.DataContext = new KeyboardViewModel();
		}
	}
}

using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace EVE_Support_Center.Pages.MyV
{
	public sealed partial class MyVView : UserControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MyVView"/> class.
		/// </summary>
		public MyVView()
		{
			this.InitializeComponent();
			this.DataContext = new MyVViewModel();
		}
	}
}

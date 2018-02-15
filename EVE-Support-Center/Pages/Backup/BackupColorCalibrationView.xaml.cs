using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace EVE_Support_Center.Pages.Backup
{
	public sealed partial class BackupColorCalibrationView : UserControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BackupColorCalibrationView"/> class.
		/// </summary>
		public BackupColorCalibrationView()
		{
			this.InitializeComponent();
			this.DataContext = new BackupColorCalibrationViewModel();
		}
	}
}

using EVE_Support_Center.Helper;

namespace EVE_Support_Center.Pages.MyV
{
	class MyVViewModel : ViewModelBase
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="MyVViewModel"/> class.
		/// </summary>
		public MyVViewModel()
		{

		}
		#endregion Contstructor

		#region Methods

		#endregion Methods

		#region Events

		#endregion Events

		#region Properties
		/// <summary>
		/// Gets or sets the device information.
		/// </summary>
		/// <value>
		/// The device information.
		/// </value>
		public string DeviceInfo
		{
			get { return m_deviceInfo; }
			set
			{
				if (m_deviceInfo != value)
				{
					m_deviceInfo = value;
					OnPropertyChanged("DeviceInfo");
				}
			}
		}

		#endregion Properties

		#region
		private string m_deviceInfo;

		#endregion
	}
}

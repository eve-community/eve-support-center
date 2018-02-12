using System.ComponentModel;

namespace EVE_Support_Center.Helper
{
	/// <summary>
	/// Base implementation for INotifyPropertyChanged Member for ViewModels / DataBinding
	/// </summary>
	/// <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
	class ViewModelBase : INotifyPropertyChanged
	{

		#region INotifyPropertyChanged
		/// <summary>
		/// Occurs when a property value changes.
		/// </summary>
		/// <returns></returns>
		public event PropertyChangedEventHandler PropertyChanged;
		/// <summary>
		/// Called when [property changed].
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				var e = new PropertyChangedEventArgs(propertyName);
				this.PropertyChanged(this, e);
			}
		}
		#endregion
	}
}

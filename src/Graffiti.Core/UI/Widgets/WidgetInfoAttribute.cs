using System;

namespace Graffiti.Core
{
	/// <summary>
	///     WidgetInfo specifies information needed to build the Widget page without invoking instances of Widget
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class WidgetInfoAttribute : Attribute
	{
		private string _Id;
		private string _description;

		private string _name;

		public WidgetInfoAttribute(string id, string name, string desc)
		{
			_Id = id;
			_name = name;
			_description = desc;
		}

		/// <summary>
		///     Although this value is a string, it should be treated like a Guid. :)
		/// </summary>
		public string UniqueId
		{
			get { return _Id; }
		}

		/// <summary>
		///     The name displayed in the available widget drop down.
		/// </summary>
		public string Name
		{
			get { return _name; }
		}


		public string Description
		{
			get { return _description; }
		}
	}
}
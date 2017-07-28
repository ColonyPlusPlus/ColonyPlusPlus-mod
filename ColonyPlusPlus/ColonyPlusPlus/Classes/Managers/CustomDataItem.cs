using System;
namespace ColonyPlusPlus.Classes
{
	public class CustomDataItem
	{

		private enum dataType
		{
			typeString,
			typeInt,
			typeBool,
			typeFloat
		}

		private string DataName;
		private string DataValueS;
		private int DataValueI;
		private bool DataValueB;
		private float DataValueF;

		private dataType DataType;


		/// <summary>
		/// Constructor for string nodes ("name":"value")
		/// </summary>
		/// <param name="name">Node Name</param>
		/// <param name="val">Node Value (string)</param>
		public CustomDataItem(string name, string val)
		{
			this.DataName = name;
			this.DataValueS = val;
			this.DataType = dataType.typeString;
		}

		/// <summary>
		/// Constructor for integer nodes ("name":true)
		/// </summary>
		/// <param name="name">Node Name</param>
		/// <param name="val">Node Value (int)</param>
		public CustomDataItem(string name, int val)
		{
			this.DataName = name;
			this.DataValueI = val;
			this.DataType = dataType.typeInt;
		}

		/// <summary>
		/// Constructor for boolean nodes ("name":true)
		/// </summary>
		/// <param name="name">Node Name</param>
		/// <param name="val">Node Value (bool)</param>
		public CustomDataItem(string name, bool val)
		{
			this.DataName = name;
			this.DataValueB = val;
			this.DataType = dataType.typeBool;
		}

		/// <summary>
		/// Constructor for float nodes ("name":true)
		/// </summary>
		/// <param name="name">Node Name</param>
		/// <param name="val">Node Value (float)</param>
		public CustomDataItem(string name, float val)
		{
			this.DataName = name;
			this.DataValueF = val;
			this.DataType = dataType.typeFloat;
		}

		/// <summary>
		/// Gets the custom data.
		/// </summary>
		/// <returns>The custom data.</returns>
		public Pipliz.JSON.JSONNode getCustomData(Pipliz.JSON.JSONNode customDataNode)
		{
			switch (DataType)
			{
				case dataType.typeBool:
					customDataNode.SetAs(this.DataName, this.DataValueB);
					break;
				case dataType.typeFloat:
					customDataNode.SetAs(this.DataName, this.DataValueF);
					break;
				case dataType.typeInt:
					customDataNode.SetAs(this.DataName, this.DataValueI);
					break;
				case dataType.typeString:
					customDataNode.SetAs(this.DataName, this.DataValueS);
					break;
					
			}

			return customDataNode;
		}
	}
}

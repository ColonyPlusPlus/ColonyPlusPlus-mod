using System;
namespace ColonyPlusPlus.classes
{
	public class CustomDataItem
	{

		private Pipliz.JSON.JSONNode customDataNode = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);


		/// <summary>
		/// Constructor for string nodes ("name":"value")
		/// </summary>
		/// <param name="name">Node Name</param>
		/// <param name="val">Node Value (string)</param>
		public CustomDataItem(string name, string val)
		{
			this.customDataNode.SetAs(name, val);
		}

		/// <summary>
		/// Constructor for boolean nodes ("name":true)
		/// </summary>
		/// <param name="name">Node Name</param>
		/// <param name="val">Node Value (bool)</param>
		public CustomDataItem(string name, bool val)
		{
			this.customDataNode.SetAs(name, val);
		}

		/// <summary>
		/// Gets the custom data.
		/// </summary>
		/// <returns>The custom data.</returns>
		public Pipliz.JSON.JSONNode getCustomData()
		{
			return customDataNode;
		}
	}
}

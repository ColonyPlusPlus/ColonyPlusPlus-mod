using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
	public class CustomDataHelper
	{

		public Pipliz.JSON.JSONNode customDataNode = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

		/// <summary>
		/// Constructor for string nodes ("name":"value")
		/// </summary>
		/// <param name="name">Node Name</param>
		/// <param name="value">Node Value (string)</param>
		public CustomDataHelper(string name, string value)
		{
			customDataNode.SetAs(name, value);

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyPlusPlus.classes.CustomDataHelper"/> class with child nodes
		/// </summary>
		/// <param name="childnodes">Childnodes.</param>
		public CustomDataHelper(CustomDataItem[] childnodes)
		{
			foreach (CustomDataItem c in childnodes)
			{
				customDataNode.AddToArray(c.getCustomData());
			}
		}

		// blah = new CustomDataHelper("itemname", "someitem");
		// blah = new CustomDataHelper({ new CustomDataItem("childname", "childvalue"), new CustomDataItem("childname2", true) });

	}


}

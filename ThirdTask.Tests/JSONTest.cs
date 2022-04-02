using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ThirdTask.Models.Drinks;
using ThirdTask.Models.Services;

namespace ThirdTask.Tests
{
	[TestClass]
	public class JSONTest
	{
		[TestMethod]
		public void WritesDataToFile_WriteOrderDataToJSONFile_MethodCompletedWithoutExeption()
		{
			var listOrders = new ListOfOrders();
			listOrders.Add(new Order<IMeal>(new List<IMeal>() { new CaesarSalad(), new Juice() }, 1));
			var jsonWrite = new JSON();
			jsonWrite.JsonFile(listOrders);
		}
	}
}

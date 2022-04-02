using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ThirdTask.Models.Drinks;

namespace ThirdTask.Tests
{
	[TestClass]
	public class ListOrders
	{
		private ListOfOrders CollectionOrders()
		{
			var listOrders = new ListOfOrders();
			listOrders.Add(new Order<IMeal>(new List<IMeal>() { new CaesarSalad(), new Juice() }, 1));
			return listOrders;
		}

		[TestMethod]
		public void ViewingOrdersForTheSpecifiedPeriod_ViewOrdersForThePeriodSpecifiedByUs_MethodCompletedWithoutExeption()
		{
			var listOrders = CollectionOrders();
			listOrders.OrdersForSpecifiedPeriod(new DateTime(2022, 04, 01), new DateTime(2022, 04, 03));
		}
	}
}

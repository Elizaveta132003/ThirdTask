namespace ThirdTask
{
	internal class Manager
	{
		/// <summary>
		/// This method adds a new order to the list of orders
		/// </summary>
		/// <param name="order">The input parameter is the order that needs to be added</param>
		public static void PlaceAnOrder(Order<IMeal> order)
		{
			var list = new ListOfOrders();
			list.Add(order);
		}
	}
}

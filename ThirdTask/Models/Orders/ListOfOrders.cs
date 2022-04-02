using System.Collections;

namespace ThirdTask
{
	public class ListOfOrders : IEnumerable
	{
		private List<Order<IMeal>> orders;

		public ListOfOrders()
		{
			orders = new List<Order<IMeal>>();
		}

		/// <summary>
		/// This method adds a new order to the list of orders
		/// </summary>
		/// <param name="order">The input parameter is the order that needs to be added</param>
		public void Add(Order<IMeal> order)
		{
			if (orders != null)
			{
				orders.Add(order);
			}
		}

		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// This method finds an order for a given date range
		/// </summary>
		/// <param name="dateFirst">The first input parameter is the beginning of the range</param>
		/// <param name="dateSecond">The second input parameter is the end of the range</param>
		/// <returns></returns>
		public List<Order<IMeal>> OrdersForSpecifiedPeriod(DateTime dateFirst, DateTime dateSecond)
		{
			var ordersForSpecifiedPeriod = new List<Order<IMeal>>();

			foreach (var order in orders)
			{
				if (order.Date >= dateFirst && order.Date <= dateSecond)
				{
					ordersForSpecifiedPeriod.Add(order);
				}
			}

			return ordersForSpecifiedPeriod;
		}
	}
}

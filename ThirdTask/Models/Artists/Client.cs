namespace ThirdTask
{
	internal class Client
	{
		/// <summary>
		/// This method gives the order to the customer that he ordered
		/// </summary>
		/// <param name="order">The first parameter is the order that the customer made</param>
		/// <param name="creator">The second parameter is a class object Creator</param>
		/// <returns></returns>
		public Order<IMeal> MakeOrder(Order<IMeal> order, Creator creator)
		{
			return creator.CreatOrder(order);
		}
	}
}

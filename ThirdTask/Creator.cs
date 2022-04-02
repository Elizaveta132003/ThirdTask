namespace ThirdTask
{
	internal class Creator
	{
		public Manager Manager { get; set; }
		public Kitchener Kitchener { get; set; }
		public Thread Theard { get; set; }

		public Creator(ListOfIngredients listOfIngredients)
		{
			Manager = new Manager();
			Kitchener = new Kitchener(listOfIngredients);
		}

		/// <summary>
		/// This method creates an order
		/// </summary>
		/// <param name="order">Input parameter-order</param>
		/// <returns></returns>
		public Order<IMeal> CreatOrder(Order<IMeal> order)
		{
			Manager.PlaceAnOrder(order);
			Theard = new Thread(new ParameterizedThreadStart(Kitchener.CreatOrder));
			Theard.Start();
			return order;
		}
	}
}

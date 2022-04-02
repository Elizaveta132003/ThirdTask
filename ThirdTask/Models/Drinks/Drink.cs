namespace ThirdTask
{
	public abstract class Drink : IMeal
	{
		public string Name { get; }
		public decimal Price { get; }

		protected Drink(string name, decimal price)
		{
			Name = name;
			Price = price;
		}
	}
}

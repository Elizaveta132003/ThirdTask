namespace ThirdTask
{
	public abstract class Ingredient
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public ConditionType ConditionType { get; set; }

		protected Ingredient(string name, decimal price, ConditionType condition)
		{
			Name = name;
			Price = price;
		}
	}
}

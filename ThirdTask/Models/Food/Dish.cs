namespace ThirdTask
{
	public abstract class Dish : IMeal
	{
		public string Name { get; }
		public decimal Price { get; }
		public List<(Ingredient, int)> Ingredients { get; set; }
		public List<Preparation> Preparation { get; set; }

		protected Dish(string name)
		{
			Name = name;
			Ingredients = SetIngridients();
			Price = Ingredients.Sum(x => x.Item1.Price * x.Item2);
			Preparation = ToPreparation();
		}

		/// <summary>
		/// This method adds a list of necessary ingredients to the recipe
		/// </summary>
		/// <returns></returns>
		protected abstract List<(Ingredient, int)> SetIngridients();

		/// <summary>
		/// This method adds a list of actions
		/// </summary>
		/// <returns></returns>
		protected abstract List<Preparation> ToPreparation();
	}
}

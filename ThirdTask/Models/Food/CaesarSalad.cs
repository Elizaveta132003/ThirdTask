namespace ThirdTask
{
	public class CaesarSalad : Dish
	{
		public CaesarSalad() : base("Салат Цезарь")
		{
		}

		/// <summary>
		/// This method adds a list of necessary ingredients to the recipe
		/// </summary>
		/// <returns></returns>
		protected override List<(Ingredient, int)> SetIngridients()
		{
			var listOfIngredientForSalad = new List<(Ingredient, int)>();

			listOfIngredientForSalad.Add((new Cucumber(), 2));

			return listOfIngredientForSalad;
		}

		/// <summary>
		/// This method adds a list of actions
		/// </summary>
		/// <returns></returns>
		protected override List<Preparation> ToPreparation()
		{
			var preparation = new List<Preparation>();
			preparation.Add(new Cuttig(new Cucumber()));
			preparation.Add(new Cuttig(new Cucumber()));
			preparation.Add(new Roasting(new Cucumber()));
			return preparation;
		}
	}
}

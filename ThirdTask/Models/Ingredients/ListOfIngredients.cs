namespace ThirdTask
{
	public class ListOfIngredients
	{
		private List<(Ingredient, int)> ingredients;

		public ListOfIngredients()
		{
			ingredients = new List<(Ingredient, int)>();
		}

		/// <summary>
		/// This method adds a new ingredient to the list of ingredients
		/// </summary>
		/// <param name="ingredient">The first input parameter is the ingredients to be added</param>
		/// <param name="count">The second input parameter is the number of ingredients</param>
		public void Add(Ingredient ingredient, int count)
		{
			if (ingredient != null)
			{
				ingredients.Add((ingredient, count));
			}
		}

		/// <summary>
		/// This method looks at which ingredients are available
		/// </summary>
		/// <returns></returns>
		public List<Ingredient> IngridientsInStock()
		{
			var ingridientsInStock = new List<Ingredient>();

			foreach (var ingredient in ingredients)
			{
				if (ingredient.Item2 > 0)
				{
					Ingredient ingredientTrue = ingredient.Item1 as Ingredient;
					ingridientsInStock.Add(ingredientTrue);
				}
			}

			return ingridientsInStock;
		}

		/// <summary>
		/// This method finds ingredients by storage method
		/// </summary>
		/// <param name="conditionType">The input parameter is the storage method by which we will search</param>
		/// <returns></returns>
		public List<Ingredient> IngridientsAccordingStorageCondition(ConditionType conditionType)
		{
			var ingridientsAccordingStorageCondition = new List<Ingredient>();

			foreach (var ingredient in ingredients)
			{
				if (ingredient.Item1.ConditionType == conditionType)
				{
					Ingredient ingredientTrue = ingredient.Item1 as Ingredient;
					ingridientsAccordingStorageCondition.Add(ingredientTrue);
				}
			}

			return ingridientsAccordingStorageCondition;
		}

		public override bool Equals(object? obj)
		{
			return obj is ListOfIngredients ingredients &&
				   EqualityComparer<List<(Ingredient, int)>>.Default.Equals(this.ingredients, ingredients.ingredients);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(ingredients);
		}
	}
}

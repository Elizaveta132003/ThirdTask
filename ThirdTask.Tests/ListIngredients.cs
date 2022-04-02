using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdTask.Models.Ingredients;

namespace ThirdTask.Tests
{
	[TestClass]
	public class ListIngredients
	{

		private ListOfIngredients CollectionIngredient()
		{
			var ingredients = new ListOfIngredients();
			ingredients.Add(new Cucumber(), 5);
			ingredients.Add(new Meat(), 9);
			ingredients.Add(new Potato(), 30);

			return ingredients;
		}

		[TestMethod]
		public void ViewAvailableIngredients_FindOutWhatIngredientsAreAvailable_MethodCompletedWithoutExeption()
		{
			var listOfIngredients = CollectionIngredient();
			listOfIngredients.IngridientsInStock();
		}

		[TestMethod]
		public void SearchForIngredientsByStorageMethod_FindIngredientsByTheirStorageMethod_MethodCompletedWithoutExeption()
		{
			var listOfIngredients = CollectionIngredient();
			listOfIngredients.IngridientsAccordingStorageCondition(ConditionType.Fridge);
		}

	}
}
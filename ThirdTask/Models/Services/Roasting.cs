namespace ThirdTask
{
	internal class Roasting : Preparation
	{
		public Roasting(Ingredient ingredient) : base(ingredient)
		{
		}
		static Roasting()
		{
			_semaphore = new Semaphore(1, 9);
		}

		protected override void Processing(Ingredient ingredient, int count = 1)
		{
		}
	}
}

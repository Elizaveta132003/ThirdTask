namespace ThirdTask
{
	internal class Cuttig : Preparation
	{
		public Cuttig(Ingredient ingredient) : base(ingredient)
		{
		}

		static Cuttig()
		{
			_semaphore = new Semaphore(1, 4);
		}

		protected override void Processing(Ingredient ingredient, int count = 1)
		{

		}
	}
}

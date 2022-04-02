namespace ThirdTask
{
	public abstract class Preparation
	{
		protected static Semaphore _semaphore;

		protected Preparation(Ingredient ingredient)
		{
		}

		public void Queue(Ingredient ingredient, int count = 1)
		{
			_semaphore.WaitOne();
			Processing(ingredient, count);
			_semaphore.Release();
		}

		protected abstract void Processing(Ingredient ingredient, int count = 1);
	}
}

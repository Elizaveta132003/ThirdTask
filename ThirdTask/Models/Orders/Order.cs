namespace ThirdTask
{
	public class Order<T> where T : IMeal
	{
		public List<T> Meals { get; set; }
		public int IdCustomer { get; set; }
		public DateTime Date { get; set; }

		public Order(List<T> meals, int idCustomer)
		{
			Meals = meals;
			IdCustomer = idCustomer;
			Date = DateTime.Now;
		}
	}
}

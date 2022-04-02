using System.Text.Json;

namespace ThirdTask.Models.Services
{
	public class JSON
	{
		public string _filaname { get; set; }

		public JSON()
		{
			_filaname = "test.xml";
		}

		/// <summary>
		/// This method writes orders to a JSON file
		/// </summary>
		/// <param name="listOfOrders">The input parameter is a list of orders</param>
		public async void JsonFile(ListOfOrders listOfOrders)
		{
			using (FileStream fs = new FileStream(_filaname, FileMode.OpenOrCreate))
			{
				foreach (var order in listOfOrders)
				{
					await JsonSerializer.SerializeAsync<Order<IMeal>>(fs, (Order<IMeal>)order);
				}
			}
		}
	}
}

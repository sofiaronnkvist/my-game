public class User
{
		public string Name { get; set; }
		public Bank Money { get; set; } 

		public User(string name, Bank money)
		{
			Name = name;
			Money = money;
		}
}

public class User
{
		public string Name { get; }
		public int Money { get; } // Ska det vara bank istället?

		public User(string name, int money)
		{
			Name = name;
			Money = money;
		}
}

namespace BethanysPieShop_DOTNET10.Models
{
    public class StaticContactData
    {
        private static readonly List<Contact> _items = new();

        private static int nextId=1;

        public static void AddContact(Contact item)
        {
            item.Id = nextId++;
            _items.Add(item);
        }

        public static IReadOnlyList<Contact> AllItems => _items;
    }
}

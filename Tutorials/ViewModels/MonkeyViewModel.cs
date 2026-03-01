namespace Tutorials.ViewModels
{
    public class MonkeyViewModel
    {
        private Business.Monkey Item;

        public string Name => Item.Name;

        public string ImageUrl => Item.ImageUrl;

        public string Location => Item.Location;

        public string Details => Item.Details;

        public MonkeyViewModel(Business.Monkey item)
        {
            Item = item;
        }
    }
}

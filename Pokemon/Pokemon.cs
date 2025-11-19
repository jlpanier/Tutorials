namespace Pokemon.Objets
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        
        public static async void Load()
        {
            //PokeApiClient pokeClient = new PokeApiClient();
            //PokeApiNet.Pokemon hoOh = await pokeClient.GetResourceAsync<PokeApiNet.Pokemon>("ho-oh");
            //Item clawFossil = await pokeClient.GetResourceAsync<Item>(100);
        }

    }
}

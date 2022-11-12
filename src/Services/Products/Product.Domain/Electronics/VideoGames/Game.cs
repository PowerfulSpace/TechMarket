using System;

namespace Product.Domain.Electronics.VideoGames
{
    public class Games
    {
        // Base Information
        public DateTime ReleaseDate { get; set; }
        public int PEGI { get; set; }
        public Platform ExclusiveOfThePlatform { get; set; }
        public string Description { get; set; }
        public string DeliveryForm { get; set; }
        public bool VRSupport { get; set; }
        public string Localisations { get; set; }
        // Genres
        public bool Action { get; set; }
        public bool Fighting { get; set; }
        public bool Adventure { get; set; }
        // Singleplayer & Multiplayer
        public bool Singleplayer { get; set; }
        public bool Multiplayer { get; set; }
        // Developers And Dealer
        public bool Addons { get; set; }
        public bool CollectionEdition { get; set; }
        public bool ExtendedEdition { get; set; }
        public string Developer { get; set; }
        public string Dealer { get; set; }
    }
}

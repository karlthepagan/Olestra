// Copyright (c) Karl Alex Pauls 2021. No rights reserved. CC0
// Special thanks to SultonMRP and The World Tree Eco server community
// This work is derived from the source code of Eco: Global Survival by Strange Loop Games
// Olestra and Wow! trademarks are DEAD prior to 2021 https://tmsearch.uspto.gov/

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;

    [Serialized]
    [LocDisplayName("Olestra")]
    [Weight(80)]
    [Fuel(8000)]
    [Tag("Fuel")]
    [Tag("Fat", 1)]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class OlestraItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Olestra");
        public override LocString DisplayDescription => Localizer.DoStr("A fat substitute that adds no calories to products. Olestra may cause abdominal cramping and loose stools.");

        public override float Calories => 0;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 0, Protein = 0, Vitamins = 0 };
    }
}

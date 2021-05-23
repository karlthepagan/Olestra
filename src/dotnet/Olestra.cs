// Copyright (c) Karl Alex Pauls 2021. No rights reserved. CC0
// Special thanks to SultonMRP and The World Tree Eco server community
// This work is derived from the source code of Eco: Global Survival by Strange Loop Games
// Olestra and Wow! trademarks are DEAD prior to 2021 https://tmsearch.uspto.gov/

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;

    [Serialized]
    [LocDisplayName("Olestra")]
    [Weight(80)]
    [Fuel(8000)]
    [Tag("Fuel")]
    [Tag("Fat", 0)]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class OlestraItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Olestra");
        public override LocString DisplayDescription => Localizer.DoStr("A fat substitute that adds no calories to products. Olestra may cause abdominal cramping and loose stools.");

        public override float Calories => 0;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 0, Protein = 0, Vitamins = 0 };

        public OlestraItem()
        {
            // powered production is over 10x faster than unpowered
            OlestraRecipe recipe = new OlestraRecipe(OlestraItem.GetRecipeList(), 100f, 0.3f);
            UnpoweredOlestraRecipe unpoweredRecipe = new UnpoweredOlestraRecipe(OlestraItem.GetRecipeList(), 500f, 3.2f);

            // oil refinery is powered
            CraftingComponent.AddRecipe(typeof(OilRefineryObject), recipe);
            // stove is powered
            CraftingComponent.AddRecipe(typeof(StoveObject), recipe);
            // kitchen is unpowered
            CraftingComponent.AddRecipe(typeof(KitchenObject), unpoweredRecipe);
        }

        public static List<Recipe> GetRecipeList()
        {
            Recipe petrolOlestra = new Recipe(
                "Olestra from Gasoline",
                Localizer.DoStr("Olestra from Gasoline"),
                new IngredientElement[1]
                {
                    new IngredientElement(typeof(PetroleumItem), 1, true)
                },
                new CraftingElement[2]
                {
                    // 100kJ/2 petroleum -> 48kJ fat
                    new CraftingElement<OlestraItem>(6f),
                    // 1 petrol barrel
                    new CraftingElement<BarrelItem>(1f)
                }
            );
            Recipe bdOlestra = new Recipe(
                "Olestra from Biodiesel",
                Localizer.DoStr("Olestra from Biodiesel"),
                new IngredientElement[1]
                {
                    new IngredientElement(typeof(BiodieselItem), 1, true)
                },
                new CraftingElement[2]
                {
                    // 80kJ bd -> 80kJ fat
                    new CraftingElement<OlestraItem>(10f),
                    // 1 bd barrel
                    new CraftingElement<BarrelItem>(1f)
                }
            );
            return new List<Recipe>() { petrolOlestra, bdOlestra };
        }
    }

}

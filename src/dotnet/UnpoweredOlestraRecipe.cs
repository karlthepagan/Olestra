// Copyright (c) Karl Alex Pauls 2021. No rights reserved. CC0
// Special thanks to SultonMRP and The World Tree Eco server community
// This work is derived from the source code of Eco: Global Survival by Strange Loop Games
// Olestra and Wow! trademarks are DEAD prior to 2021 https://tmsearch.uspto.gov/

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Localization;

    [RequiresSkill(typeof(CookingSkill), 7)]
    public class UnpoweredOlestraRecipe : RecipeFamily
    {
        public UnpoweredOlestraRecipe()
        {
            this.Recipes = this.GetRecipeList();
            float labor = 500f;
            float time = 3.2f;
            this.LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(labor, typeof(CookingSkill));
            this.CraftMinutes = RecipeFamily.CreateCraftTimeValue(time);
            this.Initialize(Localizer.DoStr("Olestra"), typeof(OlestraRecipe));

            // kitchen is unpowered
            CraftingComponent.AddRecipe(typeof(KitchenObject), this);
        }

        protected List<Recipe> GetRecipeList()
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

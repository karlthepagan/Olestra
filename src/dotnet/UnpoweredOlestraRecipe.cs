// Copyright (c) Karl Alex Pauls 2021. No rights reserved. CC0
// Special thanks to SultonMRP and The World Tree Eco server community
// This work is derived from the source code of Eco: Global Survival by Strange Loop Games
// Olestra and Wow! trademarks are DEAD prior to 2021 https://tmsearch.uspto.gov/

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Localization;

    [RequiresSkill(typeof(CookingSkill), 7)]
    public class UnpoweredOlestraRecipe : RecipeFamily
    {
        public UnpoweredOlestraRecipe(List<Recipe> recipeList, float labor, float time)
        {
            this.Recipes = recipeList;
            this.LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(labor, typeof(CookingSkill));
            this.CraftMinutes = RecipeFamily.CreateCraftTimeValue(time);
            this.Initialize(Localizer.DoStr("Olestra"), typeof(OlestraRecipe));
        }
    }
}

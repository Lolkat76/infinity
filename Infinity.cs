using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Infinity.Items;


namespace Infinity
{
    class Infinity : Mod
    {
        public Infinity()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MusketBall, 3996);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.EndlessMusketPouch);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.WoodenArrow, 3996);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.EndlessQuiver);
            recipe.AddRecipe();
        }
    }
}
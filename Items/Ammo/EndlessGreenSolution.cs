using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessGreenSolution : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infinite Green Solution");
        }

        public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.GreenSolution);
			item.maxStack = 1;
			item.consumable = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GreenSolution, 999);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
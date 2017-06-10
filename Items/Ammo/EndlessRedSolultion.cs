using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessRedSolution : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infinite Red Solution");
        }

        public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.RedSolution);
			item.maxStack = 1;
			item.consumable = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedSolution, 999);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfiniteRSol : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.RedSolution);
			item.name = "Infinite Red Solution";
			item.maxStack = 1;
			item.consumable = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedSolution, 999);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
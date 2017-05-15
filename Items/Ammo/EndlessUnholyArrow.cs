using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class EndlessUnholyArrow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Unholy Quiver";
			item.damage = 12;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "This isn't a great reward for farming the Eye so much.";
			item.consumable = false;
			item.knockBack = 3f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.UnholyArrow;
			item.shootSpeed = 3.4f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.UnholyArrow, 3996);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
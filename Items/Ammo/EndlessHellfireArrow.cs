using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class InfiniteHellfireArrow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Hellfire Quiver";
			item.damage = 13;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Hot stuff.";
			item.consumable = false;
			item.knockBack = 8f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.HellfireArrow;
			item.shootSpeed = 6.5f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellfireArrow, 3996);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
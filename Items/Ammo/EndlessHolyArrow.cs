using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessHolyArrow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Holy Quiver";
			item.damage = 13;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Summons falling stars on impact. Except you don't run out.";
			item.consumable = false;
			item.knockBack = 3.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.HolyArrow;
			item.shootSpeed = 3.5f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HolyArrow, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
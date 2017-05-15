using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessFrostburnArrow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Frostburn Quiver";
			item.damage = 9;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "It's either really irrational or really rational.";
			item.consumable = false;
			item.knockBack = 2.2f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.FrostburnArrow;
			item.shootSpeed = 3.75f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FrostburnArrow, 3996);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
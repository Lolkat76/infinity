using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessRocket2 : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Rocket II Munitions Crate";
			item.damage = 40;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Contains an endless supply of Rocket IIs.";
			item.consumable = false;
			item.knockBack = 4f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 3;
			item.shootSpeed = 3f;
			item.ammo = AmmoID.Rocket;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RocketII, 3996);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
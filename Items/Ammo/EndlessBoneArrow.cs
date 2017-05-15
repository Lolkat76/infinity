using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessBoneArrow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Bone Quiver";
			item.damage = 6;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "If you're looking for an Undertale joke you came to the wrong place.";
			item.consumable = false;
			item.knockBack = 0f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.BoneArrow;
			item.shootSpeed = 3.5f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BoneArrow, 3996);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
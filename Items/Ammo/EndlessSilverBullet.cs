using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class EndlessSilverBullet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Silver Pouch";
			item.damage = 9;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Aren't these good for killing alligators?";
			item.consumable = false;
			item.knockBack = 3f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.Bullet;
			item.shootSpeed = 4.5f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBullet, 3996);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
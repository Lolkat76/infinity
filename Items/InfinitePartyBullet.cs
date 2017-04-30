using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class InfinitePartyBullet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Infinite Party Bullet";
			item.damage = 10;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Hold on.";
			item.consumable = false;
			item.knockBack = 5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = 284;
			item.shootSpeed = 5.1f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PartyBullet, 3996);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
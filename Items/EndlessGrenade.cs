using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class EndlessGrenade : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Grenade";
			item.damage = 60;
			item.thrown = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 44;
			item.useAnimation = 44;
			item.useStyle = 1;
			item.maxStack = 1;
			item.toolTip = "A small explosion that will not destroy tiles.";
			item.consumable = false;
			item.knockBack = 8f;
			item.value = 10;
			item.rare = 4;
			item.shoot = 30;
			item.shootSpeed = 5.5f;
			item.noMelee = true; //Makes it so it cannot do damage like a sword
			item.noUseGraphic = true; //Makes it so the item can't be seen in hand when used.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Grenade, 999);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
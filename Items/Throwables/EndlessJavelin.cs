using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class EndlessJavelin : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Javelin";
			item.damage = 17;
			item.thrown = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = 1;
			item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 4.75f;
			item.value = 10;
			item.rare = 4;
			item.shoot = 507;
			item.shootSpeed = 11.5f;
			item.noMelee = true; //Makes it so it cannot do damage like a sword
			item.noUseGraphic = true; //Makes it so the item can't be seen in hand when used.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Javelin, 999);
			recipe.AddTile(18);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
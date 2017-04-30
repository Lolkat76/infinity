using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items
{
	public class EndlessKnifeP : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Poison Knife";
			item.damage = 14;
			item.thrown = true;
			item.autoReuse = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 1;
			item.maxStack = 1;
			item.toolTip = "A special knife that is never consumed.";
			item.consumable = false;
			item.knockBack = 2.4f;
			item.value = 10;
			item.rare = 4;
			item.shoot = 54;
			item.shootSpeed = 12f;
			item.noMelee = true; //Makes it so it cannot do damage like a sword
			item.noUseGraphic = true; //Makes it so the item can't be seen in hand when used.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(287, 999);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
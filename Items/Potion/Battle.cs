using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Potion
{
	public class Battle : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Gladiator Potion";
			item.width = 20;
            item.height = 28;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.maxStack = 1;
            item.consumable = false;
            item.toolTip = "Infinitely provides Battle";
            item.value = 10000;
            item.rare = 1;
            item.buffType = 13;
            item.buffTime = 99999;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(300, 30);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
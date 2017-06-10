using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.BuffPotions
{
	public class EndlessFeatherfallPotion : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wing Potion");
            Tooltip.SetDefault("Infinitely provides Featherfall");
        }

        public override void SetDefaults()
		{
			item.width = 20;
            item.height = 28;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.maxStack = 1;
            item.consumable = false;
            item.value = 10000;
            item.rare = 1;
            item.buffType = BuffID.Featherfall;
            item.buffTime = 216000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FeatherfallPotion, 30);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
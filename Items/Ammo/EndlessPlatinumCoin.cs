using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessPlatinumCoin : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Evershining Platinum Coin");
            Tooltip.SetDefault("The product of hours of grinding and farming..."
                +"\n...or a couple of seconds of cheating...");
        }

        public override void SetDefaults()
		{
			item.damage = 200;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 2f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.PlatinumCoin;
			item.shootSpeed = 4f;
			item.ammo = AmmoID.Coin;
            item.createTile = TileID.PlatinumCoinPile;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumCoin, 999);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessGoldCoin : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Evershining Gold Coin");
            Tooltip.SetDefault("One of the most Ausome coins to exist");
        }

        public override void SetDefaults()
		{
			item.damage = 100;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 2f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.GoldCoin;
			item.shootSpeed = 3f;
			item.ammo = AmmoID.Coin;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldCoin, 999);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
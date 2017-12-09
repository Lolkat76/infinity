using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessMeteorBullet : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Meteor Pouch");
            Tooltip.SetDefault("Still a reliable island hunter.");
        }

        public override void SetDefaults()
		{
			item.damage = 9;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 1f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.MeteorShot;
			item.shootSpeed = 3f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteorShot, 2997);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
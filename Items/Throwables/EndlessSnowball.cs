using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
	public class EndlessSnowball : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Snowball";
			item.damage = 8;
			item.thrown = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.maxStack = 1;
			item.toolTip = "A special snowball that is never consumed.";
			item.consumable = false;
			item.knockBack = 5.75f;
			item.value = 10;
			item.rare = 4;
			item.shoot = ProjectileID.SnowBallFriendly;
			item.shootSpeed = 7f;
			item.ammo = AmmoID.Snowball;
			item.noMelee = true; //Makes it so it cannot do damage like a sword
			item.noUseGraphic = true; //Makes it so the item can't be seen in hand when used.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Snowball, 999);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
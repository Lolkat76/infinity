using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
	public class EndlessRottenEgg : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "'Egg'";
			item.damage = 13;
			item.thrown = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.maxStack = 1;
			item.toolTip = "Hey it's egg.";
			item.consumable = false;
			item.knockBack = 6.5f;
			item.value = 10;
			item.rare = 4;
			item.shoot = ProjectileID.RottenEgg;
			item.shootSpeed = 9f;
			item.noMelee = true; //Makes it so it cannot do damage like a sword
			item.noUseGraphic = true; //Makes it so the item can't be seen in hand when used.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RottenEgg, 999);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
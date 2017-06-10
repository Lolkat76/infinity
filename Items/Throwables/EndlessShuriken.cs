using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
	public class EndlessShuriken : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Shuriken");
            Tooltip.SetDefault("A special shuriken that is never consumed.");
        }

        public override void SetDefaults()
		{
			item.damage = 10;
			item.thrown = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 0f;
			item.value = 10;
			item.rare = 4;
			item.shoot = ProjectileID.Shuriken;
			item.shootSpeed = 9f;
			item.noMelee = true; //Makes it so it cannot do damage like a sword
			item.noUseGraphic = true; //Makes it so the item can't be seen in hand when used.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Shuriken, 999);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
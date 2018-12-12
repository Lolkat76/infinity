using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
	public class EndlessMolotovCocktail : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Molotov Cocktail");
            Tooltip.SetDefault("I'mma be a one-man fire-throwing apocalypse.");
        }

        public override void SetDefaults()
		{
			item.damage = 24;
			item.thrown = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 39;
			item.useAnimation = 39;
			item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.maxStack = 1;
			item.consumable = false;
			item.knockBack = 7f;
			item.value = 10;
			item.rare = 4;
			item.shoot = ProjectileID.MolotovCocktail;
			item.shootSpeed = 6.5f;
			item.noMelee = true; //Makes it so it cannot do damage like a sword
			item.noUseGraphic = true; //Makes it so the item can't be seen in hand when used.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MolotovCocktail, 99);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
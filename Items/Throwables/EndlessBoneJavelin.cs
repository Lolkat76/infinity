using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
	public class EndlessBoneJavelin : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Bone Javelin");
        }

        public override void SetDefaults()
		{
			item.damage = 29;
			item.thrown = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.maxStack = 1;
			item.consumable = false;
			item.autoReuse = true;
			item.knockBack = 5f;
			item.value = 10;
			item.rare = 4;
			item.shoot = ProjectileID.BoneJavelin;
			item.shootSpeed = 10f;
			item.noMelee = true; //Makes it so it cannot do damage like a sword
			item.noUseGraphic = true; //Makes it so the item can't be seen in hand when used.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BoneJavelin, 999);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
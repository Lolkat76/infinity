﻿using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
    public class EndlessBloodWater : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Blood Water");
        }

        public override void SetDefaults()
        {          
            item.maxStack = 1;
            item.useStyle = 1;
            item.useTime = 15;
            item.useAnimation = 15;
            item.UseSound = SoundID.Item1;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.shootSpeed = 9f;
            item.width = 18;
            item.height = 20;
            item.value = 5000;
            item.rare = 2;
            item.damage = 20;
            item.knockBack = 3f;
            item.shoot = ProjectileID.BloodWater;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BloodWater, 120);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
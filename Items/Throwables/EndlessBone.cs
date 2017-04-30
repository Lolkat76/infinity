using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
    public class EndlessBone : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Endless Bone";           
            item.maxStack = 1;
            item.useStyle = 1;
            item.useTime = 12;
            item.useAnimation = 12;
            item.UseSound = SoundID.Item1;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.shootSpeed = 8f;
            item.width = 12;
            item.height = 14;
            item.toolTip = "A dog's definition of heaven";
            item.value = 5000;
            item.rare = 2;
            item.damage = 20;
            item.knockBack = 2.3f;
            item.shoot = ProjectileID.Bone;
            item.thrown = true;
            item.ammo = 154;
            item.notAmmo = false;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bone, 999);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
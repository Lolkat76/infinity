using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
    public class EndlessStarAnise : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Star Anise");
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
            item.shootSpeed = 12f;
            item.width = 18;
            item.height = 20;
            item.value = 5000;
            item.rare = 2;
            item.damage = 14;
            item.knockBack = 0f;
            item.shoot = ProjectileID.StarAnise;
            item.thrown = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StarAnise, 999);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
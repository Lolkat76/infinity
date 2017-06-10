using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
    public class EndlessFrostDaggerfish : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Frost Daggerfish");
        }

        public override void SetDefaults()
        {        
            item.maxStack = 1;
            item.useStyle = 1;
            item.useTime = 13;
            item.useAnimation = 13;
            item.UseSound = SoundID.Item1;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.shootSpeed = 12.5f;
            item.width = 28;
            item.height = 28;
            item.value = 5000;
            item.rare = 2;
            item.damage = 17;
            item.knockBack = 3.5f;
            item.shoot = ProjectileID.FrostDaggerfish;
            item.thrown = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FrostDaggerfish, 999);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
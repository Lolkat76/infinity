using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
    public class EndlessBombFish : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Endless Bomb Fish";           
            item.maxStack = 1;
            item.useStyle = 1;
            item.useTime = 25;
            item.useAnimation = 25;
            item.UseSound = SoundID.Item1;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.shootSpeed = 6f;
            item.width = 26;
            item.height = 26;
            item.toolTip = "Infinite Bomb Fish";
            item.value = 5000;
            item.rare = 2;
            item.damage = 0;
            item.knockBack = 3.5f;
            item.shoot = ProjectileID.BombFish;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BombFish, 396);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
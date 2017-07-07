using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Tremor.Items.Throwables
{
    public class EndlessTremorThrowingWrench : ModItem
    {
        Mod otherMod = ModLoader.GetMod("Tremor");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Throwing Wrench");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("ThrowingWrench"));
                item.consumable = false;
                item.maxStack = 1;
            }
        }

        public override void AddRecipes()
        {
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("ThrowingWrench"), 3996);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Tremor.Items.Throwables
{
    public class EndlessTremorPlatinumKunai : ModItem
    {
        Mod otherMod = ModLoader.GetMod("Tremor");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Platinum Kunai");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("PlatinumKunai"));
                item.consumable = false;
                item.maxStack = 1;
            }
        }

        public override void AddRecipes()
        {
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("PlatinumKunai"), 3996);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
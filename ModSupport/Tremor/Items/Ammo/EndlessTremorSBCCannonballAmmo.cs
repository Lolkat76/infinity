using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Tremor.Items.Ammo
{
    public class EndlessTremorSBCCannonball : ModItem
    {
        Mod otherMod = ModLoader.GetMod("Tremor");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless SBC Cannonball");

        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("SBCCannonballAmmo"));
                item.consumable = false;
                item.maxStack = 1;
            }
        }

        public override void AddRecipes()
        {
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("SBCCannonballAmmo"), 3996);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
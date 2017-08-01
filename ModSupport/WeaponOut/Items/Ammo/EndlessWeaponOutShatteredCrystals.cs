using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.WeaponOut.Items.Ammo
{
	public class EndlessWeaponOutShatteredCrystals : ModItem
	{
        Mod otherMod = ModLoader.GetMod("WeaponOut");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Shattered Crystal Pouch");
            Tooltip.SetDefault("Provides infinite Shattered Crystals");
        }

		public override void SetDefaults()
		{
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("ScatterShot"));
                item.consumable = false;
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("ScatterShot"), 3996);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
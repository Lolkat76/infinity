using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.WeaponOut.Items.Ammo
{
	public class EndlessWeaponOutSplinterShot : ModItem
	{
        Mod otherMod = ModLoader.GetMod("WeaponOut");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Splinter Shot");
            Tooltip.SetDefault("Provides infinite Splinter Shots");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(otherMod.ItemType("SplinterShot"));
            item.consumable = false;
            item.maxStack = 1;
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("SplinterShot"), 3996);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
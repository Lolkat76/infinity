using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.WeaponOut.Items.Ammo
{
	public class EndlessWeaponOutMeteorBreakshot : ModItem
	{
        Mod otherMod = ModLoader.GetMod("WeaponOut");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Meteoric Breakshot Pouch");
            Tooltip.SetDefault("Provides infinite Meteoric Breakshots");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("MeteorBreakshot"));
                item.consumable = false;               
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("MeteorBreakshot"), 3996);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
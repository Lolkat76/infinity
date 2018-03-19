using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Thorium.Ammo
{
	public class EndlessThoriumDazzleArrow : ModItem
	{
        Mod otherMod = ModLoader.GetMod("ThoriumMod");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Dazzling Quiver");
            Tooltip.SetDefault("Provides endless Dazzle arrows.");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("DazzleArrow"));
                item.consumable = false;               
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("DazzleArrow"), 3996);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
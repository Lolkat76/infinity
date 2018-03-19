using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Thorium.Ammo
{
	public class EndlessThoriumDurasteelArrow : ModItem
	{
        Mod otherMod = ModLoader.GetMod("ThoriumMod");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Durasteel Quiver");
            Tooltip.SetDefault("'Provides endless Durasteel Arrows.'");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("DurasteelArrow"));
                item.consumable = false;               
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("DurasteelArrow"), 3996);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Calamity.Items.Ammo
{
	public class EndlessCalamityElysianArrow : ModItem
	{
        Mod otherMod = ModLoader.GetMod("CalamityMod");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Elysian Quiver");
            Tooltip.SetDefault("Provides infinite Elysian Arrows");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("ElysianArrow"));
                item.consumable = false;               
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("ElysianArrow"), 3996);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
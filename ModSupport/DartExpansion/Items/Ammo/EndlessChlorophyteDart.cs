using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.DartExpansion.Items.Ammo
{
	public class EndlessChlorophyteDart : ModItem
	{
        Mod otherMod = ModLoader.GetMod("DartExpansion");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Chlorophyte Dart");
            Tooltip.SetDefault("Provides infinite Chlorophyte Darts");
        }

		public override void SetDefaults()
		{
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("ChlorophyteDart"));
                item.consumable = false;
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("ChlorophyteDart"), 999);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
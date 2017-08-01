using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.DartExpansion.Items.Ammo
{
	public class EndlessGoldenDart : ModItem
	{
        Mod otherMod = ModLoader.GetMod("DartExpansion");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Golden Dart");
            Tooltip.SetDefault("Provides infinite Golden Darts");
        }

		public override void SetDefaults()
		{
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("GoldenDart"));
                item.consumable = false;
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("GoldenDart"), 999);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
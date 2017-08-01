using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.DartExpansion.Items.Ammo
{
	public class EndlessVenomDart : ModItem
	{
        Mod otherMod = ModLoader.GetMod("DartExpansion");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Venom Dart");
            Tooltip.SetDefault("Provides infinite Venom Darts");
        }

		public override void SetDefaults()
		{
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("VenomDart"));
                item.consumable = false;
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("VenomDart"), 999);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
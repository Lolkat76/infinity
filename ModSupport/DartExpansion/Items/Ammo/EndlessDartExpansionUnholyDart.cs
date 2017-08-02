using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.DartExpansion.Items.Ammo
{
	public class EndlessDartExpansionUnholyDart : ModItem
	{
        Mod otherMod = ModLoader.GetMod("DartExpansion");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Unholy Dart");
            Tooltip.SetDefault("Provides infinite Unholy Darts");
        }

		public override void SetDefaults()
		{
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("UnholyDart"));
                item.consumable = false;
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("UnholyDart"), 999);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}

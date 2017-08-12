using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Calamity.Items.Ammo
{
	public class EndlessCalamityVeriumBullet : ModItem
	{
        Mod otherMod = ModLoader.GetMod("CalamityMod");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Verium Pouch");
            Tooltip.SetDefault("Provides infinite Verium Bullets");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("VeriumBullet"));
                item.consumable = false;               
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("VeriumBullet"), 3996);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
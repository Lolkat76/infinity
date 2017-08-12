using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Calamity.Items.Ammo
{
	public class EndlessCalamityAccelerationBullet : ModItem
	{
        Mod otherMod = ModLoader.GetMod("CalamityMod");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Acceleration Pouch");
            Tooltip.SetDefault("Provides infinite Acceleration Rounds");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("AccelerationBullet"));
                item.consumable = false;               
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("AccelerationBullet"), 3996);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
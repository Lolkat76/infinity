using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Thorium.Ammo
{
	public class EndlessThoriumSawbladeIchor : ModItem
	{
        Mod otherMod = ModLoader.GetMod("ThoriumMod");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vile Sawblade Munitions Crate");
            Tooltip.SetDefault("Endlesly provides vile sawblades.");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("SawbladeIchor"));
                item.consumable = false;               
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("SawbladeIchor"), 3996);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
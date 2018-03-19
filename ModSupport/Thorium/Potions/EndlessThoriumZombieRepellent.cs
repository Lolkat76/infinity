using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Thorium.Potions
{
	public class EndlessThoriumZombieRepellent : ModItem
	{
        Mod otherMod = ModLoader.GetMod("ThoriumMod");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bottomless Zombie Repellent");
			Tooltip.SetDefault("'The bottle is full of plants.'");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("ZombieRepellent"));
                item.consumable = false;
                item.buffTime = 216000;
                item.maxStack = 1;
            }
        }

        public override bool ConsumeItem(Player player)
        {
            return false;
        }

        public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("ZombieRepellent"), 30);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
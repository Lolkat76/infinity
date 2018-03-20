using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Thorium.Potions
{
	public class EndlessThoriumLesserLifeWater : ModItem
	{
        Mod otherMod = ModLoader.GetMod("ThoriumMod");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bottomless Lesser Life Water");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("LesserLifeWater"));
                item.buffType = otherMod.BuffType("LifeWaterRegen");
                item.consumable = false;
                item.buffTime = 3600;
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
                recipe.AddIngredient(otherMod.ItemType("LesserLifeWater"), 30);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
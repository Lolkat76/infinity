using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Other
{
    public class EndlessHealingPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bottomless Healing Potion");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.HealingPotion);
            item.maxStack = 1;
            item.consumable = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HealingPotion, 120);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}

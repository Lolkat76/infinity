using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Other
{
    public class EndlessGreaterManaPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bottomless Greater Mana Potion");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.GreaterManaPotion);
            item.maxStack = 1;
            item.consumable = false;
        }
        public override bool ConsumeItem(Player player)
        {
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreaterManaPotion, 120);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}

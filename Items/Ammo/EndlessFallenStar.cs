using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessFallenStar : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Fallen Star");
            Tooltip.SetDefault("'I hold the galaxy in my hands'");
        }

        public override void SetDefaults()
		{
            item.ammo = AmmoID.FallenStar;
			item.width = 18;
			item.height = 20;
			item.value = 25000;
			item.rare = 2;			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 49);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
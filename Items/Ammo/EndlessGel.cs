using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessGel : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Gel");
            Tooltip.SetDefault("It looks like it's slowly growing");
        }

        public override void SetDefaults()
		{
            item.ammo = AmmoID.Gel;
			item.width = 10;
			item.height = 12;
			item.value = 1000;
			item.rare = 2;		
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 3996);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
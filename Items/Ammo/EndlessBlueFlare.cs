using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessBlueFlare : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Flare Munitions Crate");
            Tooltip.SetDefault("Provides infinite Blue Flares");
        }

        public override void SetDefaults()
		{
			item.damage = 1;
			item.ranged = true;
            item.ammo = AmmoID.Flare;
            item.shoot = ProjectileID.BlueFlare;
			item.width = 26;
			item.height = 26;
			item.knockBack = 1.5f;
            item.shootSpeed = 6f;
			item.value = 1000;
			item.rare = 2;		
		}

        public override bool ConsumeAmmo(Player player)
        {
            return false;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlueFlare, 3996);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
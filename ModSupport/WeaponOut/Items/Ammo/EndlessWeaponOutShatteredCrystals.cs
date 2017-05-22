using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.WeaponOut.Items.Ammo
{
	public class EndlessWeaponOutShatteredCrystals : ModItem
	{
        Mod otherMod = ModLoader.GetMod("WeaponOut");

		public override void SetDefaults()
		{
			item.name = "Endless Shattered Crystals";
            item.ammo = AmmoID.Bullet;
            item.ranged = true;
			item.width = 14;
			item.height = 14;
            item.damage = 7;
            item.knockBack = 1f;
            item.shootSpeed = 4;
            if (otherMod != null)
            {
                item.shoot = otherMod.ProjectileType("ScatterShot");
            }
            item.toolTip = "Provides infinite Shattered Crystals";
			item.value = 1000;
			item.rare = 2;			
		}

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("ScatterShot"), 3996);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.BuffPotions.Combos
{
	public class FishingComboPotion : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fishing Combo Potion");
            Tooltip.SetDefault("Infinitely provides many fishing buffs.");
        }

        public override void SetDefaults()
		{
			item.width = 14;
			item.height = 24;
            item.useStyle = 2;
            item.useTime = 17;
            item.useAnimation = 17;
            item.UseSound = SoundID.Item3;
			item.value = 25000;
			item.rare = 8;			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "EndlessCratePotion", 1);
            recipe.AddIngredient(null, "EndlessFishingPotion", 1);
            recipe.AddIngredient(null, "EndlessSonarPotion", 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.Crate, 216000);
            player.AddBuff(BuffID.Fishing, 216000);
            player.AddBuff(BuffID.Sonar, 216000);
            return true;
        }
    }
}
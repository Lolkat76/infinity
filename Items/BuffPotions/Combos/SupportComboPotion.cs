using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.BuffPotions.Combos
{
	public class SupportComboPotion : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Support Combo Potion");
            Tooltip.SetDefault("Infinitely provides many supportive buffs.");
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
			recipe.AddIngredient(null, "EndlessBuilderPotion", 1);
            recipe.AddIngredient(null, "EndlessFeatherfallPotion", 1);
            recipe.AddIngredient(null, "EndlessFlipperPotion", 1);
            recipe.AddIngredient(null, "EndlessGravitationPotion", 1);
            recipe.AddIngredient(null, "EndlessMiningPotion", 1);
            recipe.AddIngredient(null, "EndlessNightOwlPotion", 1);
            recipe.AddIngredient(null, "EndlessShinePotion", 1);
            recipe.AddIngredient(null, "EndlessSwiftnessPotion", 1);
            recipe.AddIngredient(null, "EndlessWaterWalkingPotion", 1);
            recipe.AddIngredient(null, "EndlessObsidianSkinPotion", 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.Builder, 216000);
            player.AddBuff(BuffID.Featherfall, 216000);
            player.AddBuff(BuffID.Flipper, 216000);
            player.AddBuff(BuffID.Gravitation, 216000);
            player.AddBuff(BuffID.Mining, 216000);
            player.AddBuff(BuffID.NightOwl, 216000);
            player.AddBuff(BuffID.Shine, 216000);
            player.AddBuff(BuffID.Swiftness, 216000);
            player.AddBuff(BuffID.WaterWalking, 216000);
            player.AddBuff(BuffID.ObsidianSkin, 216000);
            return true;
        }
    }
}
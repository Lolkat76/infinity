using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.BuffPotions.Combos
{
	public class DefenseComboPotion : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Defence Combo Potion");
            Tooltip.SetDefault("Infinitely provides many defensive buffs.");
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
			recipe.AddIngredient(null, "EndlessDangersensePotion", 1);
            recipe.AddIngredient(null, "EndlessInfernoPotion", 1);
            recipe.AddIngredient(null, "EndlessEndurancePotion", 1);
            recipe.AddIngredient(null, "EndlessHeartreachPotion", 1);
            recipe.AddIngredient(null, "EndlessManaRegenPotion", 1);
            recipe.AddIngredient(null, "EndlessRegenerationPotion", 1);
            recipe.AddIngredient(null, "EndlessThornsPotion", 1);
            recipe.AddIngredient(null, "EndlessHunterPotion", 1);
            recipe.AddIngredient(null, "EndlessLifeforcePotion", 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.Dangersense, 216000);
            player.AddBuff(BuffID.Inferno, 216000);
            player.AddBuff(BuffID.Endurance, 216000);
            player.AddBuff(BuffID.Heartreach, 216000);
            player.AddBuff(BuffID.ManaRegeneration, 216000);
            player.AddBuff(BuffID.Thorns, 216000);
            player.AddBuff(BuffID.Regeneration, 216000);
            player.AddBuff(BuffID.Hunter, 216000);
            player.AddBuff(BuffID.Lifeforce, 216000);
            return true;
        }
    }
}
using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Consolaria.Items.Vanity
{
    [AutoloadEquip(EquipType.Legs)]

    public class GeorgesTuxedoPants : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.value = Item.buyPrice(0, 25, 0, 0);
            item.rare = 0;
            item.vanity = true;         
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("George's Pants");
            Tooltip.SetDefault("Oh myyy!");
            DisplayName.AddTranslation(GameCulture.Russian, "����� ����������");
            Tooltip.AddTranslation(GameCulture.Russian, "");
        }
    }
}

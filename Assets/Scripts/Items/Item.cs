using Magic;

namespace Items
{
    
    public enum ITEM_TYPES
    {
        Common,
        Uncommon,
        Rare,
        Legendary
    }

    public interface Item
    {
        int Cost { get; }
        int Mass { get; }
        bool isEquipment { get; }
        bool isQuestItem { get; }
        ITEM_TYPES ItemType { get; }
        MagicAttribute MagicAttribute { get; }
        
    }
    

   
}
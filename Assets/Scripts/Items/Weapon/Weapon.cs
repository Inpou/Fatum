using Magic;

namespace Items.Weapon
{
    public enum WEAPON_TYPES
    {
        OnehandMelee,
        TwohandMelee,
        Ranged   
    }
    public interface IWeapon
    {
        int Damage { get; }
        WEAPON_TYPES WeaponType { get; }
        
    }

    public abstract class Sword : Item, IWeapon
    {
        private int _cost;
        private int _mass;
        private bool _isQuestItem;
        private ITEM_TYPES _itemType;
        private MagicAttribute _magicAttribute;
        private int _damage;
        private WEAPON_TYPES _weaponType;

        public int Cost
        {
            get { return _cost; }
        }
        public int Mass
        {
            get { return _mass; }
        }
        public bool isEquipment
        {
            get { return true; }
        }
        public bool isQuestItem
        {
            get { return _isQuestItem; }
        }
        public ITEM_TYPES ItemType
        {
            get { return _itemType; }
        }
        public MagicAttribute MagicAttribute
        {
            get { return _magicAttribute; }
        }
        public int Damage
        {
            get { return _damage; }
        }
        public WEAPON_TYPES WeaponType
        {
            get { return _weaponType; }
        }
    }
    
}
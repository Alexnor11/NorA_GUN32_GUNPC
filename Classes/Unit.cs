namespace Classes
{
    class Unit(string name)
    {
        public string Name { get; } = name;
        private float health; 
        public float Health => health;
        private const float _Damage = 5f;        

        // Конструкторы
        public Unit() : this("Unknown Unit") { }

        public float _Health => Health * (1f + Armor);

      
        public bool SetDamage(float value)
        {          
            health -= value * (1f - Armor);           
            return Health <= 0f;
        }

            public void EquipWeapon(Weapon weapon)
        {
            EquippedWeapon = weapon;
        }

       
        public void EquipHelm(Helm helm)
        {
            EquippedHelm = helm;
        }
      
        public void EquipShell(Shell shell)
        {
            EquippedShell = shell;
        }
       
        public void EquipBoots(Boots boots)
        {
            EquippedBoots = boots;
        }
       
        public float Damage
        {
            get
            {               
                if (EquippedWeapon != null)
                    return EquippedWeapon.GetDamage() + _Damage; 
                else
                    return _Damage; 
            }
        }
       
        public float Armor
        {
            get
            {
                float totalArmor = 0f;               
                if (EquippedHelm != null)
                    totalArmor += EquippedHelm.ArmorValue;
                if (EquippedShell != null)
                    totalArmor *= EquippedShell.ArmorValue;
                if (EquippedBoots != null)
                    totalArmor += EquippedBoots.ArmorValue;
                return Math.Min(totalArmor, 1f);
            }
        }
       
        public void SetHealth(float initialHealth)
        {
            health = initialHealth;
        }

        // Предметы персонажа
        private Weapon EquippedWeapon { get; set; }
        private Helm EquippedHelm { get; set; }
        private Shell EquippedShell { get; set; }
        private Boots EquippedBoots { get; set; }
    }
}

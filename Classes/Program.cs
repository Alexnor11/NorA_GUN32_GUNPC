namespace Classes
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Подготовка к бою: ");
            Console.Write("Введите имя бойца: ");
            string name = Console.ReadLine();

            Console.Write("Введите начальное здоровье бойца (10-100): ");
            float health = float.Parse(Console.ReadLine());

            Console.Write("Введите значение брони шлема от 0 до 1: ");
            float helmArmor = float.Parse(Console.ReadLine());

            Console.Write("Введите значение брони кирасы от 0 до 1: ");
            float shellArmor = float.Parse(Console.ReadLine());

            Console.Write("Введите значение брони сапог от 0 до 1: ");
            float bootsArmor = float.Parse(Console.ReadLine());

            Console.Write("Укажите минимальный урон оружия (0-20): ");
            float minWeaponDamage = float.Parse(Console.ReadLine());

            Console.Write("Укажите максимальный урон оружия (20-40): ");
            float maxWeaponDamage = float.Parse(Console.ReadLine());

            Unit player = new Unit(name);
            player.SetHealth(health);

            Helm playerHelm = new Helm("Player's Helm") { ArmorValue = helmArmor };
            Shell playerShell = new Shell("Player's Shell") { ArmorValue = shellArmor };
            Boots playerBoots = new Boots("Player's Boots") { ArmorValue = bootsArmor };

            Weapon playerWeapon = new Weapon("Player's Weapon", minWeaponDamage, maxWeaponDamage);

            player.EquipHelm(playerHelm);
            player.EquipShell(playerShell);
            player.EquipBoots(playerBoots);
            player.EquipWeapon(playerWeapon);


            Console.WriteLine($"Общий показатель брони равен: {player.Armor}");
            Console.WriteLine($"Фактическое значение здоровья равно: {player._Health}");
        }

    }
}
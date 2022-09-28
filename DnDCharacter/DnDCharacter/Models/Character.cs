namespace DnDCharacter.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArmorClass { get; set; }
        public new CharacterInventory Inventory {get; set;}
        public int HitPoints { get; set; }
        public int Speed { get; set; }
        public int Experiance { get; set; }

        public Character()
        {
            
        }

       /* public void CreateCharacter()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of your character");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Armor Class of your character");
            ArmorClass = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Hit Points of your character");
            HitPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Speed of your character");
            Speed = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        public void AddItemToInventory(string item, int amount)
        {
            // Add items to inventory
            Inventory.Add(item, amount);
            Console.Clear();
            Console.WriteLine("YOUR INVENTORY");
            foreach (var items in Inventory)
            {
                Console.WriteLine($"{items.Key} : {items.Value}");
            }
        }
        public void RemoveItemFromInventory(string item, int amount)
        {
            //Removes amount of item from a list
            if ((Inventory[item] -= amount) < 0)
            {
                Inventory.Remove(item);
            }
            Console.Clear();
            Console.WriteLine("YOUR INVENTORY");
            foreach (var items in Inventory)
            {
                Console.WriteLine($"{items.Key} : {items.Value}");
            }
        }
        public void DecreaseArmorClass(int userInput)
        {
            // decrease Armor class by user input
            Console.Clear();
            ArmorClass -= userInput;
        }
        public void IncreaseArmorClass(int userInput)
        {
            // increase Armor class by user input
            Console.Clear();
            ArmorClass += userInput;
        }
        public void Attacked()
        {
            Random random = new Random();
            if (ArmorClass > random.Next(40))
            {
                Console.Clear();
                Console.WriteLine("YOU MISSED YOUR ATTACK!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("YOU HIT THE KILLER ROBOT!");
                HitPoints -= 5;
            }
        }
        public void Block()
        {
            Random random = new Random();
            if (ArmorClass > random.Next(40))
            {
                Console.Clear();
                Console.WriteLine("YOU BLOCKED THE KILLER ROBOTS ATTACK!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("THE KILLER ROBOT HIT YOU!");
                Thread.Sleep(1000);
                HitPoints -= 5;
            }
        }
        public void Run()
        {
            Random random = new Random();
            if (Speed > random.Next(40))
            {
                Console.Clear();
                Console.WriteLine("YOU GOT AWAY!");
                Thread.Sleep(3000);
            }
            else
            {

                Console.Clear();
                Console.WriteLine("YOU CANT GET AWAY, YOU'RE NOT FAST ENOUGH!");
            }
        }*/
    }
}

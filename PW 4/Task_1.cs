using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

class Spell
{
    public string Name { get; private set; }
    public int Mana { get; private set; }
    private string Effect { get; set; }
    public Spell(string name, int mana, string effect)
    {
        Name = name;
        Mana = mana;
        Effect = effect;
    }
    public void Use()
    {
        Console.WriteLine($"Волшебник колдует! {Effect}");
    }
    class Magician
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }
        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void CastSpell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                spell.Use();
                Mana = Mana - spell.Mana;
            }
            else
            {
                int AbsentMana =  spell.Mana - Mana;
                Console.WriteLine($"Для использования {spell.Name} не хватает {AbsentMana} единиц маны. Хлебни зелье!");
                    
            }
        }
    }
    static void Main()
    {
        Spell alohomora = new Spell("Alohomora", 60, "Замок открывается!");
        Spell vingardiumLeviosa = new Spell("Мingardium Leviosa", 60, "Предмет поднимается в воздух!");
        Magician garryPotter = new Magician("Гарри Поттер", 100);
        garryPotter.CastSpell(alohomora); 
        garryPotter.CastSpell(vingardiumLeviosa); 
        Console.ReadKey(true);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._1_Heroes_of_Code_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Heroes> heroesOnField = new List<Heroes>();
            for (int i = 0; i < n; i++)
            {
                string[] heroesArgs = Console.ReadLine()
                .Split(" ")
                .ToArray();
                string name = heroesArgs[0];
                int hp = int.Parse(heroesArgs[1]);
                int mp = int.Parse(heroesArgs[2]);
                Heroes newHero = new Heroes(name, hp, mp);
                heroesOnField.Add(newHero);
            }
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmds = input
                .Split(" - ")
                .ToArray();
                if (cmds[0] == "CastSpell")
                {
                    CastingSpell(heroesOnField, cmds);
                }
                else if (cmds[0] == "TakeDamage")
                {
                   TakingDamage(heroesOnField, cmds);
                }
                else if (cmds[0]== "Recharge")
                {
                    string name = cmds[1];
                    int manaPoints = int.Parse(cmds[2]);
                    foreach (var hero in heroesOnField)
                    {
                        if (hero.Name==name)
                        {
                            if (hero.MP+manaPoints>200)
                            {
                                Console.WriteLine($"{name} recharged for {200-hero.MP} MP!");
                                hero.MP = 200;
                            }
                            else
                            {
                                hero.MP += manaPoints;
                                Console.WriteLine($"{name} recharged for {manaPoints} MP!");
                            }
                            break;
                        }
                    }
                }
                else if (cmds[0]== "Heal")
                {
                    string name = cmds[1];
                    int hp = int.Parse(cmds[2]);
                    foreach (var hero in heroesOnField)
                    {
                        if (hero.Name == name)
                        {
                            if (hero.HP + hp > 100)
                            {
                                Console.WriteLine($"{name} healed for {100 - hero.HP} HP!");
                                hero.HP = 100;
                            }
                            else
                            {
                                hero.HP += hp;
                                Console.WriteLine($"{name} healed for {hp} HP!");
                            }
                            break;
                        }
                    }
                }
            }
           
                Console.WriteLine(String.Join(Environment.NewLine, heroesOnField));
            
        }
        static void CastingSpell(List<Heroes> heroes, string[] cmds)
        {
            string name = cmds[1];
            int mpNeeded = int.Parse(cmds[2]);
            string spellName = cmds[3];
            foreach (var hero in heroes)
            {
                if (hero.Name == name)
                {
                    if (hero.MP >= mpNeeded)
                    {
                        hero.MP = hero.MP - mpNeeded;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {hero.MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                    return;
                }
            }
        }
        static void TakingDamage(List<Heroes> heroes, string[] cmds)
        {
            string name = cmds[1];
            int damage = int.Parse(cmds[2]);
            string attacker = cmds[3];
            foreach (var hero in heroes)
            {
                if (hero.Name == name)
                {
                    if (hero.HP > damage)
                    {
                        hero.HP = hero.HP - damage;
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {hero.HP} HP left!");
                        return;
                    }
                    else
                    {
                        heroes.Remove(hero);
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        return; 
                    }
                }
            }
            
        }
    }
    public class Heroes
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public Heroes(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
        }
        public override string ToString()
        {
            return @$"{this.Name}
  HP: {this.HP}
  MP: {this.MP}";

        }
    }
}

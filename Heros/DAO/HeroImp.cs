using Heros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros.DAO
{
    public class HeroImp<T>
    {
        private List<Hero> heroes = new List<Hero>();

        public void Add(Hero hero)
        {
            heroes.Add(hero);
        }

        public Hero GetById(string name)
        {
            return heroes.Find(h => h.Name == name);
        }

        public IEnumerable<Hero> GetAll()
        {
            return heroes;
        }

        public void Update(Hero hero)
        {
            var existingHero = heroes.Find(h => h.Name == hero.Name);
            if (existingHero != null)
            {
                existingHero.Superpower = hero.Superpower;
                existingHero.Age = hero.Age;
            }
            else
            {

                throw new InvalidOperationException("Hero not found");
            }
        }

        public void Delete(string name)
        {
            var heroToRemove = heroes.Find(h => h.Name == name);
            if (heroToRemove != null)
            {
                heroes.Remove(heroToRemove);
            }
            else
            {

                throw new InvalidOperationException("Hero not found");
            }
        }
    }
}

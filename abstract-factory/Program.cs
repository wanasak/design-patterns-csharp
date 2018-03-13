using System;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory africa = new AfricarFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }
    }
}

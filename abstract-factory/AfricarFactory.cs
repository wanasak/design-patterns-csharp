namespace abstract_factory
{
    public class AfricarFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildbeest();
        }
    }
}

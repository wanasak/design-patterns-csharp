namespace abstract_factory
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore herb)
        {
            System.Console.WriteLine(this.GetType().Name + " eats " + herb.GetType().Name);
        }
    }
}

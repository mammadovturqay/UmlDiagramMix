using System;

namespace UmlDiagramMix.ThreeDesignPatterns
{
    internal class CreationalPatternsFactoryMethod
    {
        public interface IProduct
        {
            void Operation();
        }

        public class ConcreteProductA : IProduct
        {
            public void Operation()
            {
                Console.WriteLine("A Product Created");
            }
        }

        public class ConcreteProductB : IProduct
        {
            public void Operation()
            {
                Console.WriteLine("B Product Created");
            }
        }

        public abstract class Creator
        {
            public abstract IProduct FactoryMethod();
        }

        public class ConcreteCreatorA : Creator
        {
            public override IProduct FactoryMethod()
            {
                return new ConcreteProductA();
            }
        }

        public class ConcreteCreatorB : Creator
        {
            public override IProduct FactoryMethod()
            {
                return new ConcreteProductB();
            }
        }

        public class CreationalPatternRun_
        {

            public void RunFactoryMethod()
            {
                Creator creatorA = new ConcreteCreatorA();
                IProduct productA = creatorA.FactoryMethod();
                productA.Operation();

                Creator creatorB = new ConcreteCreatorB();
                IProduct productB = creatorB.FactoryMethod();
                productB.Operation();
            }
        }
    }
}

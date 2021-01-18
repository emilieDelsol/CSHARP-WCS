using System;
using System.Security.Cryptography.X509Certificates;

namespace POO_heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal[] mammalTable = new Mammal[5];
            Human human = new Human("Human");
            Monkey monkey = new Monkey("Monkey");
            Elefant elefant = new Elefant("Elefant");
            Wolf wolf = new Wolf("Wolf");
            Man man = new Man("Georges", true);
           

            mammalTable[0] = human;
            mammalTable[1] = monkey;
            mammalTable[2] = elefant;
            mammalTable[3] = wolf;
            mammalTable[4] = man;

            foreach (Mammal mammal in mammalTable)
            {
                mammal.GetTypeGroup();
                mammal.Scream();
                mammal.Eat();
                mammal.Move();
                man.GetNameHuman();
            }

            Reptilian[] reptilianTable = new Reptilian[4];
            Turtle turtle = new Turtle("Donatello");
            Turtle turtle2 = new Turtle("Raphaël");
            Lizard lizard = new Lizard("Geko");
            Snake snake = new Snake("Kaa");

            reptilianTable[0] = turtle;
            reptilianTable[1] = turtle2;
            reptilianTable[2] = lizard;
            reptilianTable[3] = snake;

            foreach (Reptilian reptilian in reptilianTable)
            {
                reptilian.GetTypeGroup();
                reptilian.Scream();
                reptilian.Eat();
                reptilian.Move();
            }
            /*Animal[] animalsTable = new Animal[7];
            Human human = new Human("Georges");
            Monkey monkey = new Monkey("Kong");
            Elefant elefant = new Elefant("Dumbo");
            Wolf wolf = new Wolf("Gosth");
            Turtle turtle = new Turtle("Donatello");
            Lizard lizard = new Lizard("Geko");
            Snake snake = new Snake("Kaa");

            animalsTable[0] = human;
            animalsTable[1] = monkey;
            animalsTable[2] = elefant;
            animalsTable[3] = wolf;
            animalsTable[4] = turtle;
            animalsTable[5] = lizard;
            animalsTable[6] = snake;
              
            foreach(Animal animal in animalsTable)
            {
                
                animal.Scream();
                animal.Eat();
                animal.Move();


            }*/

        }
    }
    public abstract class Animal
    {

        protected bool _hotBlood;
        protected string _nameGroup;
        protected bool _mammal;
        public Animal(string nameGroup, bool hotBlood, bool mammal)
        {
            _nameGroup = nameGroup;
            _hotBlood = hotBlood;
            _mammal = mammal;
        }

        public string GetNameGroup()
        {
            return _nameGroup;
        }
    }
    public abstract class Mammal : Animal
    {
        protected string _nameMammal;
        protected int _legsCount;
        protected bool _hairy;
        public Mammal(string nameMammal, int legsCount, bool hairy) : base("Mammal", true, true)
        {
            _nameMammal = nameMammal;
            _legsCount = legsCount;
            _hairy = hairy;
        }

        public virtual string GetNameMammal()
        {
            return _nameMammal;
        }

        public void GetTypeGroup()
        {

            Console.Write($"\n{_nameMammal} is a {_nameGroup}");
        }
        public virtual int GetLegs()
        {
            return _legsCount;
        }
        public virtual void Move()
        {
            Console.WriteLine(_nameMammal + " walk on " + GetLegs() + " legs");
        }
        public virtual void Eat()
        {
            System.Console.Write(_nameMammal + " eats ");
        }

        public virtual void Scream()
        {
            Console.Write($"\n{_nameMammal} ");
        }
    }
    public class Human : Mammal
    {
        public Human(string nameMammal) : base(nameMammal, 2, false)
        { }
        public override void Scream()
        {
            base.Scream();
            Console.WriteLine("speak");
        }
        public override void Eat()
        {
            base.Eat();
            Console.Write("vegetables and meet \n");
        }
    }

    public class Monkey : Mammal
    {
        public Monkey(string nameMammal) : base(nameMammal, 2, true)
        { }

        public override void Scream()
        {
            base.Scream();
            Console.WriteLine("Scream!!! ");
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine($"\tAnd on {GetLegs() + 2} legs to!");
        }
        public override void Eat()
        {
            base.Eat();
            Console.Write("vegetables \n");
        }
    }


    public class Elefant : Mammal
    {
        public Elefant(string nameMammal) : base(nameMammal, 4, true)
        { }
        public override void Scream()
        {
            base.Scream();
            Console.WriteLine(" trumpet!!");
        }

        public override void Eat()
        {
            base.Eat();
            Console.Write("vegetables \n");
        }

    }

    public class Wolf : Mammal
    {
        public Wolf(string nameMammal) : base(nameMammal, 4, true)
        { }
        public override void Scream()
        {
            base.Scream();
            Console.WriteLine("howls: AWOUUUUUUU!");
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("More precisely: " + _nameMammal + " walks to the amble !");
        }
        public override void Eat()
        {
            base.Eat();
            Console.Write("only meet \n");
        }
    }
    public abstract class Reptilian : Animal
    {
        protected string _nameReptilian;
        protected int _legsCount;
        protected bool _hairy;
        public Reptilian(string nameReptilian, int legsCount, bool hairy) : base("Reptilian", false, false)
        {
            _nameReptilian = nameReptilian;
            _legsCount = legsCount;
            _hairy = hairy;
        }

        public void GetTypeGroup()
        {

            Console.Write($"\n{_nameReptilian} is a {_nameGroup}");
        }

        public virtual int GetLegs()
        {
            return _legsCount;
        }
        public virtual void Move()
        {
            Console.WriteLine(_nameReptilian + " walk on " + GetLegs() + " legs");
        }
        public virtual void Eat()
        {
            System.Console.Write(_nameReptilian + " eats ");
        }

        public virtual void Scream()
        {
            Console.Write($"\n {_nameReptilian} ");
        }
    }

    public class Turtle : Reptilian
    {
        public Turtle(string nameReptilian) : base(nameReptilian, 4, false)
        { }
        public override void Scream()
        {
            base.Scream();
            Console.WriteLine("... speak because he is a ninja turtle! ");
        }
        public override void Move()
        {
            Console.WriteLine("\n" + _nameReptilian + " swim");
        }
        public override void Eat()
        {
            base.Eat();
            Console.Write("meet composed of molluscs, sponges, jellyfish, crabs, clams, fish, squid, and oysters. ");
        }
    }

    public class Lizard : Reptilian
    {
        public Lizard(string name) : base(name, 4, false)
        { }

        public override void Scream()
        {
            base.Scream();
            Console.WriteLine("... don't scream.");
        }
        public override void Eat()
        {
            base.Eat();
            Console.Write("meet and vegetables. \n");
        }
    }

    public class Snake : Reptilian
    {
        public Snake(string name) : base(name, 0, false)
        { }
        public override void Scream()
        {
            base.Scream();
            Console.WriteLine("hiss: KSsssssssssss!!");
        }
        public override void Move()
        {
            Console.WriteLine("\n" + _nameReptilian + " crawls.");
        }
        public override void Eat()
        {
            base.Eat();
            Console.Write("only meet");
        }
    }

        public abstract class Human2 : Mammal
        {
            
            public Human2(string name ) : base("Human2", 2, false)
            {}
            public override void Scream()
            {
                base.Scream();
                Console.WriteLine("speak");
            }
            public override void Eat()
            {
                base.Eat();
                Console.Write("vegetables and meet \n");
            }
            
        }
    public class Man : Human2
    {
        protected string _nameMan;
        protected bool _isMan;

        public Man(string nameMan, bool isMan) : base("Man")
        {
            _nameMan = nameMan;
            _isMan = isMan;

        }
       
        public string IsMan()
        {
            if (_isMan)
            {
                return "is a man";
            }
            else
            {
                return "is a woman";
            }
        }
        public void GetNameHuman()
        {
            Console.WriteLine($"This {_nameGroup} {IsMan()}! Name {_nameMan}");
        }
    }
    public class Woman : Human2
    {
        protected string _nameWoman;
        protected bool _isMan;

        public Woman(string nameWoman, bool isMan) : base("Woman")
        {
            _nameWoman = nameWoman;
            _isMan = isMan;

        }
        public void IsMan()
        {
            if (!_isMan)
            {
                Console.WriteLine("is a man");
            }
            else
            {
                Console.WriteLine("is a woman");
            }
        }
    }

    
}

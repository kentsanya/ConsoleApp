namespace Test.Logical
{

    //INTERACTION (Method+field (class or abstract class))
    public class Dog : Animal
    {
        public Dog(Toys toysconcret) : base(toysconcret)
        {
        }
    }

    //Realization (signature Method (interfaces))
    interface IMove 
    {
        void Move();
    }

    //Association
    public  class Animal:IMove
    {
        public People people;
        public Toys toys;
        public Species species;

        public Animal(Toys toysconcret) 
        {
            //Composition
            species = new Species();
            //Agregation
            toys =  toysconcret;
        }

        //Realization in the class
        public void Move()
        {
            throw new NotImplementedException();
        }
    }

    public class People 
    {

    }
    public class Toys 
    {

    }
    public class Species 
    {

    }


}
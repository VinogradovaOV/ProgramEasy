using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo<Animal> zoo = new Zoo<Animal>();
            Zoo<Cat> zooCat = new Zoo<Cat>();

            Animal animal = new Animal();
            Cat cat = new Cat();

            zooCat.MoveAnimal(cat); //можт принимать только тип cat
            zoo.MoveAnimal(cat); //может принимать и наследников
            zoo.MoveAnimal(animal);

            zoo.GetAnimal(); //вернет animal
            zooCat.GetAnimal(); //вернет cat

            //Вариантности обобщенного интерфейса

            Animal aCat = new Cat();// можем так сделать, потому что Cat наследник Animal

            IStudent<Animal> student = new Student<Animal>(); //можем так сделать, потому что Student нследник IStudent
                                                              //Не поддерживается приведение типов обобщения в интерфейсе!!!
                                                              //IStudent<Animal> studentCat = new Student<Cat>(); //так не работает
                                                              // Т=Т!!!
                                                              //В интерфейсе и в его реализации должен быть одинаковый тип Т - инвариантность обощенного интерфейса.

            //ключевое слово out позволяет приводить тип Т к его наследникам.
            //Ковариантный интерфейс
            IStudentOut<Animal> studentOut = new StudentOut<Cat>();

            //Ключевое слово in позволяет приводить наследный тип к типу Т
            //Контрвариантный интерфейс
            IStudentIn<Cat> studentIn = new StudentIn<Animal>();
        }
    }
}

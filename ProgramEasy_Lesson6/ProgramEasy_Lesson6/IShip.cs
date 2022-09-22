using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEasy_Lesson6
{
    /// <summary>
    /// Интерфейс - набор сигнатур методов, все методы интерфейса должны быть раелизованы в классе
    /// </summary>
   public interface IShip
    {
        string Move(int distanse); //модификатор доступа тот же, что и у интерфейса
        string Fight(); //внутри интерфейса не может быть реализованных методов!
        string Coordinates(int x, int y);
    }

    public interface IDestroy
    {
        string Destroy();
        string Coordinates(int x, int y); //Одинаковые методы с интерфейсом IShip! Должны быть реализованы явно
    }
}

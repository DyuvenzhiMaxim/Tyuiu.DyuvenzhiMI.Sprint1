
using System.Diagnostics.SymbolStore;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DyuvenzhiMI.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            Boolean Sym1 = value.Contains('!');
            Boolean Sym2 = value.Contains('?');
            return Sym1 && Sym2;
        }
    }
}

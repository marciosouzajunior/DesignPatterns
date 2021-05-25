
namespace DesignPatterns.Strategy
{

    /*
     * Strategy interface
     * 
     * Declares an interface common to all supported algorithms. Context uses
     * this interface to call the algorithm defined by a ConcreteStrategy.
     */
    public interface ISort
    {
        void sort(int[] numbers);
    }

}

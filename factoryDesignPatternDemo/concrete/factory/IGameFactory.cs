using factoryDesignPatternDemo.abstraction;

namespace factoryDesignPatternDemo.concrete.factory
{
    public interface IGameFactory
    {
        IOyun Gaming(Games game);
    }
}
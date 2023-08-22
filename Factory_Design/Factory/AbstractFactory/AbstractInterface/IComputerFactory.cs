namespace Factory_Design.Factory.AbstractFactory.AbstractInterface
{
    public interface IComputerFactory
    {
        IProcessor Processor();
        IBrand Brand();
        ISystemType SystemType();
    }
}

using CurrencyDisplay.Interfaces;

namespace CurrencyDisplay.Services;

public interface IUiBus
{
    void Register(IListener listener);
    void UnRegister(IListener listener);
    IListener<T>[] GetListeners<T>() where T : IUiBusEvent;
    void Notify<T>(T notification) where T : IUiBusEvent;
    void UnRegisterAll();
}
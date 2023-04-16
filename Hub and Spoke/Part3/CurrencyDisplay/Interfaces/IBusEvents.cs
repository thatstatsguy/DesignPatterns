using CurrencyDisplay.Components;

namespace CurrencyDisplay.Interfaces;

public interface IUiBus
{
    void Register(IListener listener);
    void UnRegister(IListener listener);
    IListener<T>[] GetListeners<T>() where T : IUiBusEvent;
    void Notify<T>(T notification) where T : IUiBusEvent;
    void UnRegisterAll();
}
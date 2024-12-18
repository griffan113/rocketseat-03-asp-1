namespace Rkst03ASP1.Entities;

public abstract class Device {
    protected static bool IsConnected() => true;

    public abstract string GetBrand();
}
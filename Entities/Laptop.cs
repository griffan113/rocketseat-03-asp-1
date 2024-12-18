namespace Rkst03ASP1.Entities;

public sealed class Laptop : Device {
    public string GetModel() {
        var isConnected = IsConnected();

        return isConnected ? "MacBook M1 Pro" : "Unknown";
    }

    public override string GetBrand() {
        return "Abble";
    }
}
#pragma warning disable SA1309 // Field names should not begin with underscore.

namespace ISP;

public class MultiFunctionalCar(ICar car, IAirplane airplane) : IMultiFunctionalVehicle
{
    private readonly ICar _car = car;
    private readonly IAirplane _airplane = airplane;

    public void Drive() => _car.Drive();
    public void Fly() => _airplane.Fly();
}

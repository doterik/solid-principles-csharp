/* https://code-maze.com/interface-segregation-principle */

using ISP;

var car = new Car();
car.Drive();

var multiFunctionalCar = new MultiFunctionalCar(car, new Airplane());
multiFunctionalCar.Fly();

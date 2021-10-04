using MarsRoverCase.Model;

namespace MarsRoverCase.Interface
{
    public interface IVehicle
    {
        int X { get; }

        int Y { get; }

        ILandingSurface LandingSurface { get; }

        Direction Direction { get; }

        void Move(Movement movement);
    }
}
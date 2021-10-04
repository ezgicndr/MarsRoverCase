using MarsRoverCase.Model;

namespace MarsRoverCase.Interface
{
    public interface ILandingSurface
    {
        SurfaceSize Size { get; }

        void Define(int width, int height);
    }
}
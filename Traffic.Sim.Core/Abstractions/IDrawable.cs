using System.Drawing;

namespace Traffic.Sim.Core.Abstractions;

public interface IDrawable
{
    PointF Position { get; set; }
    void Draw(Graphics graphics);
}
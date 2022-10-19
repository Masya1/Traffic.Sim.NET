using System.Drawing;
using Traffic.Sim.Core.Abstractions;

namespace Traffic.Sim.Core.Models.Cells;

public class Sidewalk : IDrawable
{
    public PointF Position { get; set; }

    public Sidewalk()
    {
        Position = PointF.Empty;
    }
    
    public void Draw(Graphics graphics)
    {
        throw new NotImplementedException();
    }
}
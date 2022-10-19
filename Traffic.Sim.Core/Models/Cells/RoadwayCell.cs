using System.Drawing;
using Traffic.Sim.Core.Abstractions;

namespace Traffic.Sim.Core.Models.Cells;

public class RoadwayCell : IDrawable
{
    public PointF Position { get; set; }
    
    public RoadwayCell()
    {
        Position = PointF.Empty;
    }
    
    public void Draw(Graphics graphics)
    {
        throw new NotImplementedException();
    }
}
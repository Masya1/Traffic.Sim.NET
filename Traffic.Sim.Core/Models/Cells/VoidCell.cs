using System.Drawing;
using Traffic.Sim.Core.Abstractions;

namespace Traffic.Sim.Core.Models.Cells;

public class VoidCell : IDrawable
{
    public PointF Position { get; set; }

    public VoidCell()
    {
        Position = PointF.Empty;
    }
    
    public void Draw(Graphics graphics)
    {
        throw new NotImplementedException();
    }
}
using System.Drawing;
using Traffic.Sim.Core.Abstractions;

namespace Traffic.Sim.Core.Models;

public class Map : IMap
{
    public IList<ITrafficParticipant> Participants { get; }
    public IList<IDrawable> Cells { get; }
    
    public void Update()
    {
        throw new NotImplementedException();
    }

    public void Draw(Graphics graphics)
    {
        throw new NotImplementedException();
    }
}
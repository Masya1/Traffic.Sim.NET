using System.Drawing;

namespace Traffic.Sim.Core.Abstractions;

public interface IMap
{
    IList<ITrafficParticipant> Participants { get; }
    IList<IDrawable> Cells { get; }

    void Update();
    void Draw(Graphics graphics);
}
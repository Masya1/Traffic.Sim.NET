using System.Drawing;
using Traffic.Sim.Core.Abstractions;

namespace Traffic.Sim.Core.Models.Objects;

public class Pedestrian : ITrafficParticipant
{
    public PointF Position { get; set; }
    public float Acceleration { get; set; }
    public float Speed { get; set; }

    public Pedestrian()
    {
        Position = PointF.Empty;
        Acceleration = 0;
        Speed = 0;
    }
    
    public void Draw(Graphics graphics)
    {
        throw new NotImplementedException();
    }
    
    public void Update()
    {
        throw new NotImplementedException();
    }

    public void SlowDown(bool fullStop = true)
    {
        throw new NotImplementedException();
    }

    public void KeepMoving(int maxSpeed)
    {
        throw new NotImplementedException();
    }
}
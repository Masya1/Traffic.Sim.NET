namespace Traffic.Sim.Core.Abstractions;

public interface ITrafficParticipant : IDrawable
{
    float Acceleration { get; set; }
    float Speed { get; set; }
    void Update();
    void SlowDown(bool fullStop = true);
    void KeepMoving(int maxSpeed);
}
namespace Traffic.Sim.Core.Routing;

public struct RouteAction
{
    public RouteActionDirection Direction { get; }
    public float From { get; }
    public float To { get; }

    public RouteAction(float from, float to, RouteActionDirection direction)
    {
        Direction = direction;
        From = from;
        To = to;
    }
}
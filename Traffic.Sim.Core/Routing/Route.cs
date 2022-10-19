namespace Traffic.Sim.Core.Routing;

public class Route
{
    private readonly Queue<RouteAction> _actions;
    private readonly bool _looped;

    public Route()
    {
        _actions = new Queue<RouteAction>();
        _looped = false;
    }
    
    public Route(IEnumerable<RouteAction> actions, bool looped = false)
    {
        _actions = new Queue<RouteAction>(actions);
        _looped = looped;
    }

    public bool IsFinished() => _actions.Count == 0;

    public RouteAction Next()
    {
        var action = _actions.Dequeue();
        _actions.Enqueue(action);

        return action;
    }
}
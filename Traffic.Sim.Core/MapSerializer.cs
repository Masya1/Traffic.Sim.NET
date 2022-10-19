using System.Text.Json;
using Traffic.Sim.Core.Abstractions;

namespace Traffic.Sim.Core;

public static class MapSerializer
{
    public static async Task Serialize<T>(T map, string fileName) 
        where T: class, IMap, new()
    {
        if (map == null) throw new ArgumentNullException(nameof(map));
        
        await using var fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

        await JsonSerializer.SerializeAsync(fs, map);
    }

    public static async Task<T> Deserialize<T>(string fileName) 
        where T : class, IMap, new()
    {
        await using var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        var map =  await JsonSerializer.DeserializeAsync<T>(fs);

        if (map is null)
        {
            throw new Exception($"Unable to deserialize empty map from file \"{fileName}\"");
        }

        return map;
    }
}
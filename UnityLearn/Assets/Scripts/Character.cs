using Newtonsoft.Json;
using UnityEngine;

public class Character
{
    [JsonProperty("Job")]
    public string Job { get; set; }

    [JsonProperty("hp")]
    public int hp { get; set; }

    [JsonProperty("attackPower")]
    public int attackPower { get; set; }

    [JsonProperty("dfe")]
    public int dfe { get; set; }

    [JsonProperty("evade")]
    public int evade { get; set; }

    [JsonProperty("crit_dmg")]
    public int crit_dmg { get; set; }

    [JsonProperty("crit_percent")]
    public int crit_percent { get; set; }
}

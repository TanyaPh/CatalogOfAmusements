using System.Text.Json.Serialization;

namespace d_04.Model;

public class MovieReview : ISearchable
{
    [JsonPropertyName("title")]
    public string Title{ get; set; }
    [JsonPropertyName("rank")]
    public int Rank { get; set; }
    [JsonPropertyName("critics_pick")]
    public int IsCriticsPick { get; set; }
    [JsonPropertyName("summary_short")]
    public string SummaryShort { get; set; }
    [JsonPropertyName("link")]
    public Dictionary<string, string> Src { get; set; }
    
    public override string ToString()
    {
        var pick = Convert.ToBoolean(IsCriticsPick) ? "[NYT critic’s pick]" : "";
        return $"{Title} {pick}\n{SummaryShort}\n{Src["url"]}\n";
    }
}
using System.Text.Json.Serialization;
namespace d_04.Model;

public class BookReview : ISearchable
{
    
    [JsonPropertyName("book_details")]
    public List<BookDetails> Info { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("list_name")]
    public string ListName { get; set; }

    [JsonPropertyName("amazon_product_url")]
    public string Url { get; set; }
    
    public string Title
    {
        get { return Info[0].Title; }
        set { Info[0].Title = value; }
    }

    public override string ToString()
    {
        return $"{Info[0].Title} by {Info[0].Author} [{Rank} on NYT’s {ListName}]\n{Info[0].SummaryShort}\n{Url}\n";
    }
}

public class BookDetails
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("author")]
    public string Author { get; set; }

    [JsonPropertyName("description")]
    public string SummaryShort { get; set; }
}

using Newtonsoft.Json;

namespace KlaviyoSharp.Models;
/// <summary>
/// Klaviyo Campaign Clone Request
/// </summary>
public class CampaignClone : KlaviyoObject<CampaignCloneAttributes>
{
    /// <summary>
    /// Creates a new Campaign Clone with default values
    /// </summary>
    /// <returns></returns>
    public static new CampaignClone Create()
    {
        return new() { Type = "campaign" };
    }
}
/// <summary>
/// Campaign Clone Attributes
/// </summary>
public class CampaignCloneAttributes
{
    /// <summary>
    /// The campaign ID to be cloned
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }
    /// <summary>
    /// The name for the new cloned campaign
    /// </summary>
    [JsonProperty("new_name")]
    public string NewName { get; set; }
}
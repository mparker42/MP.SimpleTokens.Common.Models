namespace MP.SimpleTokens.Common.Models.Tokens.ERC721Metadata
{
    /// <summary>
    /// There technically isn't a fixed format for metadata.
    /// Expect this object to frequently change based on real world implementations.
    /// </summary>
    public class ERC1155Suggested
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        public string? Title { get; set; }

        public string? Type { get; set; }

        public Dictionary<string, object>? Properties { get; set; }
    }
}

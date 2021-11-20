using System.Text.Json.Serialization;

namespace MP.SimpleTokens.Common.Models.Tokens.ERC721Metadata
{
    /// <summary>
    /// No formal documentaiton exists for the mintable metadata format as of creating this class
    /// Existing metadata and this forum post were used as reference: https://editorial.mintable.app/2021/08/09/nft-metadata-whats-all-this/
    /// </summary>
    public class Mintable : ERC1155Suggested
    {
        /// <summary>
        /// URL linking to the animation
        /// Only populated when an animated version of the NFT is available
        /// </summary>
        [JsonPropertyName("animation_url")]
        public string? AnimationUrl { get; set; }

        /// <summary>
        /// The percentage of royalties to the creator for each resale
        /// </summary>
        [JsonPropertyName("royalty_amount")]
        public int? RoyaltyAmount { get; set; }

        /// <summary>
        /// Whether the copyright is transferred to the buyer
        /// </summary>
        [JsonPropertyName("copyright_transfer")]
        public bool? CopyrightTransfer { get; set; }

        /// <summary>
        /// Token contract address on the etherium blockchain
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Whether the artwork can be resold
        /// </summary>
        public bool? Resellable { get; set; }

        /// <summary>
        /// NFT creator’s address on the chain
        /// </summary>
        [JsonPropertyName("original_creator")]
        public string? OriginalCreator { get; set; }

        /// <summary>
        /// Edition number of the artwork
        /// This allows for a limited run of the same token when used in combination with EditionTotal
        /// e.g. edition number 8 out of 300 total
        /// </summary>
        [JsonPropertyName("edition_number")]
        public int? EditionNumber { get; set; }

        /// <summary>
        /// Total number of editions of the artwork
        /// This allows for a limited run of the same token when used in combination with EditionNumber
        /// e.g. edition number 8 out of 300 total
        /// </summary>
        [JsonPropertyName("edition_total")]
        public int? EditionTotal { get; set; }

        /// <summary>
        /// Link to the NFT sale listing
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// The downloadable file for the NFT
        /// </summary>
        [JsonPropertyName("file_key")]
        public string? FileKey { get; set; }

        /// <summary>
        /// An undocumented property containing the mintable store category for the token
        /// </summary>
        public string? Category { get; set; }
    }
}

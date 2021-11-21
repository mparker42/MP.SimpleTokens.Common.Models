using System.Numerics;

namespace MP.SimpleTokens.Common.Models.Tokens
{
    public class BlockchainInfo
    {
        public string? Address { get; set; }

        public BigInteger? TokenId { get; set; }

        public string? TokenUri { get; set; }

        /// <summary>
        /// Assume GenericERC1155 if not provided
        /// </summary>
        public TokenVendor TokenVendor { get; set; }
    }
}

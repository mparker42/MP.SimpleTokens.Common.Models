using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.SimpleTokens.Common.Models.Tokens
{
    public class TokenInfo
    {
        public string? Id { get; set; }

        public TokenType? Type { get; set; }

        public BlockchainInfo? BlockchainInfo { get; set; }
    }
}

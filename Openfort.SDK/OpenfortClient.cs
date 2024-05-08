using Openfort.SDK.Wrapper;
using Openfort.SDK.Extensions;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Text;
using Openfort.SDK.Model;

namespace Openfort.SDK
{
    public class OpenfortClient
    {
        private readonly string apiKey;
        private readonly string? basePath;

        public OpenfortClient(string apiKey, string? basePath = null)
        {
            this.apiKey = apiKey;
            this.basePath = basePath;
        }

        private AccountsApiWrapper? accounts;
        public AccountsApiWrapper Accounts
        {
            get
            {
                if (accounts == null)
                {
                    accounts = new AccountsApiWrapper(apiKey, basePath);
                }
                return accounts;
            }
        }

        private ContractsApiWrapper? contracts;
        public ContractsApiWrapper Contracts
        {
            get
            {
                if (contracts == null)
                {
                    contracts = new ContractsApiWrapper(apiKey, basePath);
                }
                return contracts;
            }
        }

        private InventoriesApiWrapper? inventories;
        public InventoriesApiWrapper Inventories
        {
            get
            {
                if (inventories == null)
                {
                    inventories = new InventoriesApiWrapper(apiKey, basePath);
                }
                return inventories;
            }
        }

        private PlayersApiWrapper? players;
        public PlayersApiWrapper Players
        {
            get
            {
                if (players == null)
                {
                    players = new PlayersApiWrapper(apiKey, basePath);
                }
                return players;
            }
        }

        private PoliciesApiWrapper? policies;
        public PoliciesApiWrapper Policies
        {
            get
            {
                if (policies == null)
                {
                    policies = new PoliciesApiWrapper(apiKey, basePath);
                }
                return policies;
            }
        }

        private PolicyRulesApiWrapper? policyRules;
        public PolicyRulesApiWrapper PolicyRules
        {
            get
            {
                if (policyRules == null)
                {
                    policyRules = new PolicyRulesApiWrapper(apiKey, basePath);
                }
                return policyRules;
            }
        }

        private SessionsApiWrapper? sessions;
        public SessionsApiWrapper Sessions
        {
            get
            {
                if (sessions == null)
                {
                    sessions = new SessionsApiWrapper(apiKey, basePath);
                }
                return sessions;
            }
        }

        private TransactionIntentsApiWrapper? transactionIntents;
        public TransactionIntentsApiWrapper TransactionIntents
        {
            get
            {
                if (transactionIntents == null)
                {
                    transactionIntents = new TransactionIntentsApiWrapper(apiKey, basePath);
                }
                return transactionIntents;
            }
        }

        private Web3ConnectionsApiWrapper? web3Connections;
        public Web3ConnectionsApiWrapper Web3Connections
        {
            get
            {
                if (web3Connections == null)
                {
                    web3Connections = new Web3ConnectionsApiWrapper(apiKey, basePath);
                }
                return web3Connections;
            }
        }

        private SettingsApiWrapper? settings;
        public SettingsApiWrapper Settings
        {
            get
            {
                if (settings == null)
                {
                    settings = new SettingsApiWrapper(apiKey, basePath);
                }
                return settings;
            }
        }

        private IamApiWrapper? iam;
        public IamApiWrapper Iam
        {
            get
            {
                if (iam == null)
                {
                    iam = new IamApiWrapper(apiKey, basePath);
                }
                return iam;
            }
        }

        private PaymastersApiWrapper? paymasters;
        public PaymastersApiWrapper Paymasters
        {
            get
            {
                if (paymasters == null)
                {
                    paymasters = new PaymastersApiWrapper(apiKey, basePath);
                }
                return paymasters;
            }
        }

        private ExchangeApiWrapper? exchange;
        public ExchangeApiWrapper Exchange
        {
            get
            {
                if (exchange == null)
                {
                    exchange = new ExchangeApiWrapper(apiKey, basePath);
                }
                return exchange;
            }
        }


        public WebHookEvent? ConstructWebhookEvent(string body, string signature)
        {
            var signedPayload = Sign(body);
            if (!string.Equals(signedPayload, signature, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("Invalid signature");
            }
            return JsonConvert.DeserializeObject<WebHookEvent>(body);
        }

        private byte[] signingKey;
        private byte[] SigningKey
        {
            get
            {
                if (signingKey == null)
                {
                    var splittedSecret = apiKey.Split("_");
                    if (splittedSecret.Length != 3)
                    {
                        throw new Exception("Invalid secret key");
                    }
                    var bareKey = splittedSecret[2].Replace("-", String.Empty);
                    signingKey = Encoding.UTF8.GetBytes(bareKey);
                }
                return signingKey;
            }
        }

        private string Sign(string message)
        {
            var bytesArray = Encoding.UTF8.GetBytes(message);
            var hmac = IncrementalHash.CreateHMAC(HashAlgorithmName.SHA256, SigningKey);
            hmac.AppendData(bytesArray);
            return hmac.GetCurrentHash().ToHex();
        }
    }
}
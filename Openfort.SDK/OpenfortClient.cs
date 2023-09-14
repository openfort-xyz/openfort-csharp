using Openfort.SDK.Wrapper;

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

        private InventoryApiWrapper? inventory;
        public InventoryApiWrapper Inventory
        {
            get
            {
                if (inventory == null)
                {
                    inventory = new InventoryApiWrapper(apiKey, basePath);
                }
                return inventory;
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
    }
}
using System;

namespace Lime {
    public static class RoutingRuleExtensions {
        private static readonly RoutingRule _instance = new RoutingRule("instance");
        private static readonly RoutingRule _identity = new RoutingRule("identity");
        private static readonly RoutingRule _identityByPriority = new RoutingRule("identityByPriority");
        private static readonly RoutingRule _promiscuous = new RoutingRule("promiscuous");
        private static readonly RoutingRule _domain = new RoutingRule("domain");

        public static RoutingRule Instance(this PresenceExtension<RoutingRule> routingrule) {
            return _instance;
        }

        public static RoutingRule Identity(this PresenceExtension<RoutingRule> routingrule) {
            return _identity;
        }

        public static RoutingRule IdentityByPriority(this PresenceExtension<RoutingRule> routingrule) {
            return _identityByPriority;
        }

        public static RoutingRule Promiscuous(this PresenceExtension<RoutingRule> routingrule) {
            return _promiscuous;
        }

        public static RoutingRule Domain(this PresenceExtension<RoutingRule> routingrule) {
            return _domain;
        }
    }
}
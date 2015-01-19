namespace Lime {
    public static class MethodExtensions {
        private static readonly Method _get = new Method("get");
        private static readonly Method _set = new Method("set");
        private static readonly Method _delete = new Method("delete");
        private static readonly Method _observe = new Method("observe");

        public static Method Get(this CommandExtension<Method> command) {
            return _get;
        }

        public static Method Set(this CommandExtension<Method> command) {
            return _set;
        }

        public static Method Delete(this CommandExtension<Method> command) {
            return _delete;
        }

        public static Method Observe(this CommandExtension<Method> command) {
            return _observe;
        }
    }
}

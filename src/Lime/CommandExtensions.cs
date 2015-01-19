using System;
using System.ComponentModel;

namespace Lime {
    public static partial class CommandExtensions {
        public static void Method(this Command command, Func<CommandExtension<Method>, Func<Method>> method) {
            command.Method = method(null)();
        }

        public static void Uri(this Command command, Func<CommandExtension<Uri>, Func<Uri>> uri) {
            command.Uri = uri(null)();
        }

        public static void Type(this Command command, Func<CommandExtension<MediaType>, Func<MediaType>> type) {
            //command.Type = type(command);
        }

        public static void Status(this Command command, Func<CommandExtension<Status>, Func<Status>> status) {
            command.Status = status(null)();
        }

        public static void Reason(this Command command, Func<CommandExtension<Reason>, Func<string, Reason>> reason, string description = "") {
            command.Reason = reason(null)(description);
        }

        private static void Sandbox() {
            (new Command()).Reason(x => x.GeneralError, "");
        }
    }
}
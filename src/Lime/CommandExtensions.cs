using System;

namespace Lime {
    public static class CommandExtensions {
        public static void Method(this Command command, Func<Command,Method> method) {
            command.Method = method(command);
        }

        public static void Uri(this Command command, Func<Command,Uri> uri) {
            command.Uri = uri(command);
        }

        public static void Type(this Command command, Func<Command,Type> type) {
            command.Type = type(command);
        }

        public static void Status(this Command command, Func<Command,Status> status) {
            command.Status = status(command);
        }

        public static void Reason(this Command command, Func<Command, Reason> reason) {
            command.Reason = reason(command);
        }
    }
}
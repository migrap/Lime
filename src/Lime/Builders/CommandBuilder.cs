using System;

namespace Lime.Builders {
    public class CommandBuilder : ICommandBuilder {
        private Command _command = new Command();

        public ICommandBuilder From(Node value) {
            _command.From = value;
            return this;
        }

        public ICommandBuilder Id(Guid value) {
            _command.Id = value;
            return this;
        }

        public ICommandBuilder Procuration(Node value) {
            _command.Procuration = value;
            return this;
        }

        public ICommandBuilder To(Node value) {
            _command.To = value;
            return this;
        }

        public ICommandBuilder Type(MediaType value) {
            _command.Type = value;
            return this;
        }        

        public ICommandBuilder Method(Method value) {
            _command.Method = value;
            return this;
        }

        public ICommandBuilder Uri(string value) {
            _command.Uri = value;
            return this;
        }

        public ICommandBuilder Type(string value) {
            _command.Type = value;
            return this;
        }

        public ICommandBuilder Resource(object value) {
            _command.Resource = value;
            return this;
        }

        public ICommandBuilder Status(Status value) {
            _command.Status = value;
            return this;
        }

        public ICommandBuilder Reason(Reason value) {
            _command.Reason = value;
            return this;
        }

        public Command Build() {
            return _command;
        }
    }
}

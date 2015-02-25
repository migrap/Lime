using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lime.Builders {
    public interface ICommandBuilder : IBuilder<Command> {
        ICommandBuilder Id(Guid value);
        ICommandBuilder From(Node value);
        ICommandBuilder Procuration(Node value);
        ICommandBuilder To(Node value);
        ICommandBuilder Method(Method value);
        ICommandBuilder Uri(string value);
        ICommandBuilder Type(string value);
        ICommandBuilder Resource(object value);
        ICommandBuilder Status(Status value);
        ICommandBuilder Reason(Reason value);
    }
}
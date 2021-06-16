using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CLEAN.Domain.Core.Commands;

namespace CLEAN.Domain.Core.MessageBus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}

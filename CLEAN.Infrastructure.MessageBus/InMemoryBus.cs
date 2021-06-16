using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CLEAN.Domain.Core.Commands;
using CLEAN.Domain.Core.MessageBus;
using MediatR;

namespace CLEAN.Infrastructure.MessageBus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}

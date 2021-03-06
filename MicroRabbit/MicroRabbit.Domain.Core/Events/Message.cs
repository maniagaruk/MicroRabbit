﻿using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Message: IRequest
    {
        public string MessageType { get; protected set; }

        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}

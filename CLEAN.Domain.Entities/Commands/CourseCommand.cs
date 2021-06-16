﻿using System;
using System.Collections.Generic;
using System.Text;
using CLEAN.Domain.Core.Commands;

namespace CLEAN.Domain.Commands
{
    public abstract class CourseCommand : Command
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ImageUrl { get; protected set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.controller
{
    public interface ICommand
    {
        object Execute(object request);
    }
}

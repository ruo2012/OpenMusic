﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMusic.Services
{
    public interface IService
    {
        IClient Client { get; }
    }
}

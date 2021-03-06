﻿using System;
using System.Threading.Tasks;

namespace Installer.Core.Services
{
    public interface IArchiveUncompressor
    {
        Task Extract(string archivePath, string destination, IObserver<double> progressObserver = null);
        Task<string> ReadToEnd(string archivePath, string key);
    }
}
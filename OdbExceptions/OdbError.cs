﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdbCommunicator.OdbExceptions
{
    public enum OdbError
    {
        DeviceIsNotOdbCompatible,
        CouldNotFindCompatibleProtocol,
        WrongProtocolNumber,
        WrongResponseFromDevice,
        AlreadyConnectedToDevice,
        DeviceIsNotConnected,
        IncorrectDataLength,
        DataParseError
    }
}

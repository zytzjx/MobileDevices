﻿namespace MobileDevices.iOS.AfcServices
{
    /// <summary>
    /// 操作状态
    /// </summary>
    public enum AfcOperatingState : long
    {
        Success               =  0,
        UnknownError         =  1,
        OpHeaderInvalid     =  2,
        NoResources          =  3,
        ReadError            =  4,
        WriteError           =  5,
        UnknownPacketType   =  6,
        InvalidArg           =  7,
        ObjectNotFound      =  8,
        ObjectIsDir         =  9,
        PermDenied           = 10,
        ServiceNotConnected = 11,
        OpTimeout            = 12,
        TooMuchData         = 13,
        EndOfData           = 14,
        OpNotSupported      = 15,
        ObjectExists         = 16,
        ObjectBusy           = 17,
        NoSpaceLeft         = 18,
        OpWouldBlock        = 19,
        IoError              = 20,
        OpInterrupted        = 21,
        OpInProgress        = 22,
        InternalError        = 23,
        MuxError             = 30,
        NoMem                = 31,
        NotEnoughData       = 32,
        DirNotEmpty         = 33,
        ForceSignedType     = -1
    }
}

﻿namespace Microsoft.InfoCards.Diagnostics
{
    using System;

    internal enum EventCode
    {
        AUDIT_CARD_DELETE = 0x40050201,
        AUDIT_CARD_IMPORT = 0x40050202,
        AUDIT_CARD_WRITTEN = 0x40050200,
        AUDIT_SERVICE_IDLE_STOP = 0x40050206,
        AUDIT_STORE_DELETE = 0x40050205,
        AUDIT_STORE_EXPORT = 0x40050204,
        AUDIT_STORE_IMPORT = 0x40050203,
        E_ICARD_ARGUMENT = -1073413883,
        E_ICARD_COMMUNICATION = -1073413888,
        E_ICARD_DATA_ACCESS = -1073413887,
        E_ICARD_EXPORT = -1073413886,
        E_ICARD_FAILED_REQUIRED_CLAIMS = -1073413756,
        E_ICARD_FAILEDUISTART = -1073413867,
        E_ICARD_FILE_ACCESS = -1073413864,
        E_ICARD_IDENTITY = -1073413885,
        E_ICARD_IMPORT = -1073413884,
        E_ICARD_INFORMATIONCARD = -1073413881,
        E_ICARD_INVALID_PROOF_KEY = -1073413758,
        E_ICARD_LOGOVALIDATION = -1073413879,
        E_ICARD_MALFORMED_REQUEST = -1073413863,
        E_ICARD_MAXSESSIONCOUNT = -1073413865,
        E_ICARD_MISSING_APPLIESTO = -1073413759,
        E_ICARD_PASSWORDVALIDATION = -1073413878,
        E_ICARD_POLICY = -1073413877,
        E_ICARD_PROCESSDIED = -1073413876,
        E_ICARD_REFRESH_REQUIRED = -1073413760,
        E_ICARD_REQUEST = -1073413882,
        E_ICARD_SERVICE = -1073413874,
        E_ICARD_SERVICEBUSY = -1073413875,
        E_ICARD_SHUTTINGDOWN = -1073413873,
        E_ICARD_STORE_IMPORT = -1073413868,
        E_ICARD_STOREKEY = -1073413880,
        E_ICARD_TOKENCREATION = -1073413872,
        E_ICARD_TRUSTEXCHANGE = -1073413871,
        E_ICARD_UI_INITIALIZATION = -1073413862,
        E_ICARD_UNKNOWN_REFERENCE = -1073413757,
        E_ICARD_UNSUPPORTED = -1073413866,
        E_ICARD_UNTRUSTED = -1073413870,
        E_ICARD_USERCANCELLED = -1073413869,
        E_INVALIDARG = -2147483645,
        E_OUTOFMEMORY = -2147024882,
        SCARD_W_CANCELLED_BY_USER = -2146434962
    }
}


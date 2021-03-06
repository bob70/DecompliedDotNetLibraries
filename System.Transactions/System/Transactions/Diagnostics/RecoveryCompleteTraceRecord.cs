﻿namespace System.Transactions.Diagnostics
{
    using System;
    using System.Diagnostics;
    using System.Transactions;
    using System.Xml;

    internal class RecoveryCompleteTraceRecord : TraceRecord
    {
        private static RecoveryCompleteTraceRecord record = new RecoveryCompleteTraceRecord();
        private Guid rmId;
        private string traceSource;

        internal static void Trace(string traceSource, Guid rmId)
        {
            lock (record)
            {
                record.traceSource = traceSource;
                record.rmId = rmId;
                DiagnosticTrace.TraceEvent(TraceEventType.Information, "http://msdn.microsoft.com/2004/06/System/Transactions/RecoveryComplete", System.Transactions.SR.GetString("TraceRecoveryComplete"), record);
            }
        }

        internal override void WriteTo(XmlWriter xml)
        {
            TraceHelper.WriteTraceSource(xml, this.traceSource);
            xml.WriteElementString("ResourceManagerId", this.rmId.ToString());
        }

        internal override string EventId
        {
            get
            {
                return "http://schemas.microsoft.com/2004/03/Transactions/RecoveryCompleteTraceRecord";
            }
        }
    }
}


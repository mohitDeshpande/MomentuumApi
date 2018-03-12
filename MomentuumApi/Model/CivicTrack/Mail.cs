using System;
using System.Collections.Generic;

namespace MomentuumApi.Model.CivicTrack
{
    public partial class Mail
    {
        public string GcAlternateRecipientAllowed { get; set; }
        public string GcAutoForwarded { get; set; }
        public string GcBcc { get; set; }
        public string GcBillingInformation { get; set; }
        public string GcCategories { get; set; }
        public string GcCc { get; set; }
        public string GcCompanies { get; set; }
        public DateTime? GcCreationTime { get; set; }
        public DateTime? GcDeferredDeliveryTime { get; set; }
        public string GcDeleteAfterSubmit { get; set; }
        public DateTime? GcExpiryTime { get; set; }
        public DateTime? GcFlagDueBy { get; set; }
        public string GcFlagRequest { get; set; }
        public int? GcFlagStatus { get; set; }
        public string GcHtmlbody { get; set; }
        public int? GcImportance { get; set; }
        public int? GcInternetCodepage { get; set; }
        public string GcMileage { get; set; }
        public string GcNoAging { get; set; }
        public string GcOriginatorDeliveryReportRequested { get; set; }
        public string GcReadReceiptRequested { get; set; }
        public string GcReceivedByName { get; set; }
        public string GcReceivedOnBehalfOfName { get; set; }
        public string GcRecipientReassignmentProhibited { get; set; }
        public int? GcRemoteStatus { get; set; }
        public string GcReplyRecipientNames { get; set; }
        public string GcSenderEmailAddress { get; set; }
        public string GcSenderEmailType { get; set; }
        public string GcSenderName { get; set; }
        public int? GcSensitivity { get; set; }
        public DateTime? GcSentOn { get; set; }
        public string GcSentOnBehalfOfName { get; set; }
        public string GcSubject { get; set; }
        public string GcTo { get; set; }
        public string GcUnread { get; set; }
        public DateTime? GcReceivedTime { get; set; }
        public Guid GcGuid { get; set; }
        public DateTime? GcLastModificationTime { get; set; }
        public int Messageid { get; set; }
        public string Riding { get; set; }
    }
}

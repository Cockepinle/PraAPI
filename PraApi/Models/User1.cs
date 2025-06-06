﻿using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    /// <summary>
    /// Auth: Stores user login data within a secure schema.
    /// </summary>
    public partial class User1
    {
        public User1()
        {
            Identities = new HashSet<Identity>();
            MfaFactors = new HashSet<MfaFactor>();
            OneTimeTokens = new HashSet<OneTimeToken>();
            Sessions = new HashSet<Session>();
        }

        public Guid? InstanceId { get; set; }
        public Guid Id { get; set; }
        public string? Aud { get; set; }
        public string? Role { get; set; }
        public string? Email { get; set; }
        public string? EncryptedPassword { get; set; }
        public DateTime? EmailConfirmedAt { get; set; }
        public DateTime? InvitedAt { get; set; }
        public string? ConfirmationToken { get; set; }
        public DateTime? ConfirmationSentAt { get; set; }
        public string? RecoveryToken { get; set; }
        public DateTime? RecoverySentAt { get; set; }
        public string? EmailChangeTokenNew { get; set; }
        public string? EmailChange { get; set; }
        public DateTime? EmailChangeSentAt { get; set; }
        public DateTime? LastSignInAt { get; set; }
        public string? RawAppMetaData { get; set; }
        public string? RawUserMetaData { get; set; }
        public bool? IsSuperAdmin { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? Phone { get; set; }
        public DateTime? PhoneConfirmedAt { get; set; }
        public string? PhoneChange { get; set; }
        public string? PhoneChangeToken { get; set; }
        public DateTime? PhoneChangeSentAt { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public string? EmailChangeTokenCurrent { get; set; }
        public short? EmailChangeConfirmStatus { get; set; }
        public DateTime? BannedUntil { get; set; }
        public string? ReauthenticationToken { get; set; }
        public DateTime? ReauthenticationSentAt { get; set; }
        /// <summary>
        /// Auth: Set this column to true when the account comes from SSO. These accounts can have duplicate emails.
        /// </summary>
        public bool IsSsoUser { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsAnonymous { get; set; }

        public virtual ICollection<Identity> Identities { get; set; }
        public virtual ICollection<MfaFactor> MfaFactors { get; set; }
        public virtual ICollection<OneTimeToken> OneTimeTokens { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    public partial class Bucket
    {
        public Bucket()
        {
            Objects = new HashSet<Object>();
            S3MultipartUploads = new HashSet<S3MultipartUpload>();
            S3MultipartUploadsParts = new HashSet<S3MultipartUploadsPart>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        /// <summary>
        /// Field is deprecated, use owner_id instead
        /// </summary>
        public Guid? Owner { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? Public { get; set; }
        public bool? AvifAutodetection { get; set; }
        public long? FileSizeLimit { get; set; }
        public string[]? AllowedMimeTypes { get; set; }
        public string? OwnerId { get; set; }

        public virtual ICollection<Object> Objects { get; set; }
        public virtual ICollection<S3MultipartUpload> S3MultipartUploads { get; set; }
        public virtual ICollection<S3MultipartUploadsPart> S3MultipartUploadsParts { get; set; }
    }
}

// -----------------------------------------------------------------------
// <copyright file="GenerateQrCodeParameters.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using Pixsys.Library.Media.Common.Enums;
using SixLabors.ImageSharp;
using System.Diagnostics.CodeAnalysis;

namespace Pixsys.Library.QrCode.QrCodeManager.Models
{
    /// <summary>
    /// The needed parameters to generate QR code.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1206:DeclarationKeywordsMustFollowOrder", Justification = "Reviewed.")]
    public class GenerateQrCodeParameters
    {
        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public required string Content { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public Size Size { get; set; }

        /// <summary>
        /// Gets or sets the foreground color.
        /// </summary>
        /// <value>
        /// The foreground color.
        /// </value>
        public Color ForegroundColor { get; set; }

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        /// <value>
        /// The background color.
        /// </value>
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the destination folder.
        /// </summary>
        /// <value>
        /// The destination folder.
        /// </value>
        public required DirectoryInfo DestinationFolder { get; set; }

        /// <summary>
        /// Gets or sets the name of the destination file, without extension.
        /// </summary>
        /// <remarks>If filename contains an extension it will be replaced by the specified format.</remarks>
        public required string DestinationFileName { get; set; }

        /// <summary>
        /// Gets or sets the image format.
        /// </summary>
        /// <value>
        /// The format.
        /// </value>
        public ImageFormat Format { get; set; }
    }
}
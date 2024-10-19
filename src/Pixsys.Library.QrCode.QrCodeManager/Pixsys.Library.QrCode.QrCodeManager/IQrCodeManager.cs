// -----------------------------------------------------------------------
// <copyright file="IQrCodeManager.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using Pixsys.Library.Media.Common.Models;
using Pixsys.Library.QrCode.QrCodeManager.Models;

namespace Pixsys.Library.QrCode.QrCodeManager
{
    /// <summary>
    /// The Qr Code manager.
    /// </summary>
    public interface IQrCodeManager
    {
        /// <summary>
        /// Generates a QR code asynchronously.
        /// </summary>
        /// <param name="p">The parameters.</param>
        /// <returns>A <see cref="ImageProperties"/> representing the image properties.</returns>
        Task<ImageProperties> GenerateAsync(GenerateQrCodeParameters p);
    }
}
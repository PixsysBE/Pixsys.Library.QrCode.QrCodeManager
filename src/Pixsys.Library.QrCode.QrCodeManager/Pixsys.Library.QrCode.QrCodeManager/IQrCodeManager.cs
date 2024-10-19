// -----------------------------------------------------------------------
// <copyright file="IQrCodeManager.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using Pixsys.Library.QrCode.QrCodeManager.Models;

namespace Pixsys.Library.QrCode.QrCodeManager
{
    /// <summary>
    /// The Qr Code manager.
    /// </summary>
    internal interface IQrCodeManager
    {
        /// <summary>
        /// Generates a QR code asynchronously.
        /// </summary>
        /// <param name="p">The parameters.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task GenerateAsync(GenerateQrCodeParameters p);
    }
}
// -----------------------------------------------------------------------
// <copyright file="QrCodeManager.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using Pixsys.Library.Media.Common.Extensions;
using Pixsys.Library.QrCode.QrCodeManager.Models;
using QRCoder;
using SixLabors.ImageSharp.Processing;
using System.Diagnostics.CodeAnalysis;

namespace Pixsys.Library.QrCode.QrCodeManager
{
    /// <summary>
    /// The QR code manager.
    /// </summary>
    /// <seealso cref="IQrCodeManager" />
    internal sealed class QrCodeManager : IQrCodeManager
    {
        /// <inheritdoc />
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1000:KeywordsMustBeSpacedCorrectly", Justification = "Reviewed.")]
        public async Task GenerateAsync(GenerateQrCodeParameters p)
        {
            try
            {
                QRCodeGenerator qrGenerator = new();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(p.Content, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new(qrCodeData);
                SixLabors.ImageSharp.Image qrCodeImage = qrCode.GetGraphic(20, p.ForegroundColor, p.BackgroundColor, true);
                qrCodeImage.Mutate(x => x.Resize(p.Size.Width, p.Size.Height));
                _ = await qrCodeImage.SaveImageAsync(p.DestinationFolder, p.DestinationFileName, string.Empty, p.Format);
            }
            catch (Exception)
            {
                throw;

                // Console.WriteLine($"Une erreur s'est produite lors de la génération du QR code : {ex.Message}");
            }
        }
    }
}
// -----------------------------------------------------------------------
// <copyright file="QrCodeManagerExtensions.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Pixsys.Library.QrCode.QrCodeManager
{
    /// <summary>
    /// The QR Code Manager extensions.
    /// </summary>
    public static class QrCodeManagerExtensions
    {
        /// <summary>
        /// Adds QR Code Manager.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns>The updated builder.</returns>
        public static WebApplicationBuilder AddQrCodeManager(this WebApplicationBuilder builder)
        {
            if (!builder.Services.Any(x => x.ServiceType == typeof(IQrCodeManager)))
            {
                builder.Services.TryAddSingleton<IQrCodeManager, QrCodeManager>();
            }

            return builder;
        }
    }
}

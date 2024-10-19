
# QR Code Manager

This manager will create QR codes using SixLabors.ImageSharp

## 1. Installation

### 1.1 Register the service in `Program.cs`

```csharp
using Pixsys.Library.QrCode.QrCodeManager;

var builder = WebApplication.CreateBuilder(args);

_ = builder.Services.AddQrCodeManager();

```

### 1.2 Usage

#### 1.2.1 Inject the service into your controller

```csharp
private readonly IQrCodeManager _qrCodeManager;

public MyController(IQrCodeManager qrCodeManager)
{
    _qrCodeManager = qrCodeManager;
}
```

#### 1.2.2 Manager Methods

```csharp

var destinationFolder = "path/to/folder";
await _qrCodeManager.GenerateAsync(new Pixsys.Library.QrCode.QrCodeManager.Models.GenerateQrCodeParameters
{
    Content = "Hello World !",
    Format = Pixsys.Library.Media.Common.Enums.ImageFormat.Webp,
    BackgroundColor = SixLabors.ImageSharp.Color.White,
    ForegroundColor = SixLabors.ImageSharp.Color.Black,
    Size = new SixLabors.ImageSharp.Size(200, 200),
    DestinationFolder = Directory.CreateDirectory(destinationFolder),
    DestinationFileName = "hello_world"
});
```
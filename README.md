
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
await _qrCodeManager.Generate(new Pixsys.Library.Models.GenerateQrCodeParameters
{
    Content = <CONTENT>,
    Format = <FORMAT>,
    BackgroundColor = <BACKGROUND_COLOR>,
    ForegroundColor = <FOREGROUND_COLOR>,
    Size = <SIZE>,
    DestinationFolder = <DESTINATION_FOLDER>,
    DestinationFileName = <DESTINATION_FILE_NAME>
});
```
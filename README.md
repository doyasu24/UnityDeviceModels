# UnityDeviceModels

provides an alternative enum for device models that is available in all build targets.

This is particularly useful when you need to identify device models across different platforms in Unity projects.

```csharp
using DeviceModels;
using UnityEngine;

public class SampleComponent : MonoBehaviour
{
    private void Start()
    {
        // Get iPhone device generation from `iPhoneDeviceGenerations.Parse`.
        // This code will work on all platforms.
        iPhoneDeviceGeneration deviceGeneration = iPhoneDeviceGenerations.Parse(SystemInfo.deviceModel);
        // ex. deviceGeneration: iPhone16ProMax
        // ex. deviceGeneration: Unknown
        Debug.Log($"deviceGeneration: {deviceGeneration}");
    }

#if UNITY_IOS
    private void ExecuteOnlyInIOSBuild()
    {
        // `UnityEngine.iOS.DeviceGeneration` is only available in iOS build.
        // This code will cause a compilation error if you build on other platforms.
        UnityEngine.iOS.DeviceGeneration generation = UnityEngine.iOS.Device.generation;
        Debug.Log($"deviceGeneration: {generation}");
    }
#endif
}
```

## Install
You can add https://github.com/doyasu24/UnityDeviceModels.git?path=Assets/Plugins/DeviceModels#0.1.1 to Package Manager.

## License
MIT License

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

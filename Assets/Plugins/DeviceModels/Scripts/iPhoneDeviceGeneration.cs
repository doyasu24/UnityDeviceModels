// ReSharper disable InconsistentNaming

namespace DeviceModels
{
    /// <summary>
    /// iPhone device generation.
    /// <see cref="UnityEngine.iOS.DeviceGeneration"/> is only available in iOS build. You can use this enum instead.
    /// </summary>
    public enum iPhoneDeviceGeneration
    {
        /// Probably a device other than iPhone.
        /// `deviceModel` is not starting with `iPhone`.
        Unknown,

        /// Unknown iPhone.
        /// `deviceModel` starts with `iPhone`, but it is not any other defined iPhone.
        iPhoneUnknown,

        /// iPhone Simulator
        iPhoneSimulator,

        iPhone,
        iPhone3G,
        iPhone3GS,
        iPhone4,
        iPhone4S,
        iPhone5,
        iPhone5C,
        iPhone5S,
        iPhone6,
        iPhone6Plus,
        iPhone6s,
        iPhone6sPlus,
        iPhoneSE,
        iPhone7,
        iPhone7Plus,
        iPhone8,
        iPhone8Plus,
        iPhoneX,
        iPhoneXS,
        iPhoneXSMax,
        iPhoneXR,
        iPhone11,
        iPhone11Pro,
        iPhone11ProMax,
        iPhoneSE2,
        iPhone12Mini,
        iPhone12,
        iPhone12Pro,
        iPhone12ProMax,
        iPhone13Mini,
        iPhone13,
        iPhone13Pro,
        iPhone13ProMax,
        iPhoneSE3,
        iPhone14,
        iPhone14Plus,
        iPhone14Pro,
        iPhone14ProMax,
        iPhone15,
        iPhone15Plus,
        iPhone15Pro,
        iPhone15ProMax,
        iPhone16,
        iPhone16Plus,
        iPhone16Pro,
        iPhone16ProMax,
        iPhone16e,
    }

    public static class iPhoneDeviceGenerations
    {
        /// <summary>
        /// Converts the value of <see cref="UnityEngine.Device.SystemInfo.deviceModel">SystemInfo.deviceModel</see> to an <see cref="DeviceModels.iPhoneDeviceGeneration"/>.
        /// If the iPhone device generation cannot be determined, <see cref="DeviceModels.iPhoneDeviceGeneration.iPhoneUnknown"/> is returned.
        /// If it is not an iPhone, <see cref="DeviceModels.iPhoneDeviceGeneration.Unknown"/> is returned.
        /// </summary>
        /// <param name="deviceModel"><see cref="UnityEngine.Device.SystemInfo.deviceModel">SystemInfo.deviceModel</see></param>
        /// <returns></returns>
        public static iPhoneDeviceGeneration Parse(string deviceModel)
        {
            return deviceModel switch
            {
                "i386" or "x86_64" or "arm64" => iPhoneDeviceGeneration.iPhoneSimulator,
                "iPhone1,1" => iPhoneDeviceGeneration.iPhone,
                "iPhone1,2" => iPhoneDeviceGeneration.iPhone3G,
                "iPhone2,1" => iPhoneDeviceGeneration.iPhone3GS,
                "iPhone3,1" or "iPhone3,2" or "iPhone3,3" => iPhoneDeviceGeneration.iPhone4,
                "iPhone4,1" => iPhoneDeviceGeneration.iPhone4S,
                "iPhone5,1" or "iPhone5,2" => iPhoneDeviceGeneration.iPhone5,
                "iPhone5,3" or "iPhone5,4" => iPhoneDeviceGeneration.iPhone5C,
                "iPhone6,1" or "iPhone6,2" => iPhoneDeviceGeneration.iPhone5S,
                "iPhone7,1" => iPhoneDeviceGeneration.iPhone6Plus,
                "iPhone7,2" => iPhoneDeviceGeneration.iPhone6,
                "iPhone8,1" => iPhoneDeviceGeneration.iPhone6s,
                "iPhone8,2" => iPhoneDeviceGeneration.iPhone6sPlus,
                "iPhone8,4" => iPhoneDeviceGeneration.iPhoneSE,
                "iPhone9,1" or "iPhone9,3" => iPhoneDeviceGeneration.iPhone7,
                "iPhone9,2" or "iPhone9,4" => iPhoneDeviceGeneration.iPhone7Plus,
                "iPhone10,1" or "iPhone10,4" => iPhoneDeviceGeneration.iPhone8,
                "iPhone10,2" or "iPhone10,5" => iPhoneDeviceGeneration.iPhone8Plus,
                "iPhone10,3" or "iPhone10,6" => iPhoneDeviceGeneration.iPhoneX,
                "iPhone11,2" => iPhoneDeviceGeneration.iPhoneXS,
                "iPhone11,4" or "iPhone11,6" => iPhoneDeviceGeneration.iPhoneXSMax,
                "iPhone11,8" => iPhoneDeviceGeneration.iPhoneXR,
                "iPhone12,1" => iPhoneDeviceGeneration.iPhone11,
                "iPhone12,3" => iPhoneDeviceGeneration.iPhone11Pro,
                "iPhone12,5" => iPhoneDeviceGeneration.iPhone11ProMax,
                "iPhone12,8" => iPhoneDeviceGeneration.iPhoneSE2,
                "iPhone13,1" => iPhoneDeviceGeneration.iPhone12Mini,
                "iPhone13,2" => iPhoneDeviceGeneration.iPhone12,
                "iPhone13,3" => iPhoneDeviceGeneration.iPhone12Pro,
                "iPhone13,4" => iPhoneDeviceGeneration.iPhone12ProMax,
                "iPhone14,2" => iPhoneDeviceGeneration.iPhone13Pro,
                "iPhone14,3" => iPhoneDeviceGeneration.iPhone13ProMax,
                "iPhone14,4" => iPhoneDeviceGeneration.iPhone13Mini,
                "iPhone14,5" => iPhoneDeviceGeneration.iPhone13,
                "iPhone14,6" => iPhoneDeviceGeneration.iPhoneSE3,
                "iPhone14,7" => iPhoneDeviceGeneration.iPhone14,
                "iPhone14,8" => iPhoneDeviceGeneration.iPhone14Plus,
                "iPhone15,2" => iPhoneDeviceGeneration.iPhone14Pro,
                "iPhone15,3" => iPhoneDeviceGeneration.iPhone14ProMax,
                "iPhone15,4" => iPhoneDeviceGeneration.iPhone15,
                "iPhone15,5" => iPhoneDeviceGeneration.iPhone15Plus,
                "iPhone16,1" => iPhoneDeviceGeneration.iPhone15Pro,
                "iPhone16,2" => iPhoneDeviceGeneration.iPhone15ProMax,
                "iPhone17,1" => iPhoneDeviceGeneration.iPhone16Pro,
                "iPhone17,2" => iPhoneDeviceGeneration.iPhone16ProMax,
                "iPhone17,3" => iPhoneDeviceGeneration.iPhone16,
                "iPhone17,4" => iPhoneDeviceGeneration.iPhone16Plus,
                "iPhone17,5" => iPhoneDeviceGeneration.iPhone16e,
                _ => deviceModel.StartsWith("iPhone") ? iPhoneDeviceGeneration.iPhoneUnknown : iPhoneDeviceGeneration.Unknown
            };
        }
    }
}

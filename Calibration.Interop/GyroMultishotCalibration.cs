using System.Runtime.InteropServices;

namespace Calibration
{
    public static class Constants
    {
        public const double RotationRate = 15.041;
        public const int GyroMultishotConfigurationDataCount = 32;
    }
}

namespace Calibration.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GyroMultishotConfiguration
    {
        public double Azimuth;
        public double Inclination;
        public double Toolface;

        public double Ax;
        public double Ay;
        public double Az;

        public double Uwx;
        public double Uwy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GyroMultishotCalibrationArgs
    {
        public double Rotation;
        public double Latitude;
        public int IterationsCount;
        public int AxSign;
        public int AySign;
        public int AzSign;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.GyroMultishotConfigurationDataCount)]
        public GyroMultishotConfiguration[] Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GyroMultishotConfigurationError
    {
        public double Azimuth;
        public double Inclination;
        public double Toolface;

        public double AxError;
        public double AyError;
        public double AzError;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GyroMultishotCalibrationResult
    {
        public double KwX;
        public double DeltaX;
        public double RoX;
        public double EpsX;
        public double Eta1X;
        public double Eta2X;
        public double TauX;
        public double AlpwXY;

        public double KwY;
        public double DeltaY;
        public double RoY;
        public double EpsY;
        public double Eta1Y;
        public double Eta2Y;
        public double TauY;
        public double AlpwYX;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.GyroMultishotConfigurationDataCount)]
        public GyroMultishotConfigurationError[] Errors;
    }
}

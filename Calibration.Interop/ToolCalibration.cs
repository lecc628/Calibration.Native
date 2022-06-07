using System.Runtime.InteropServices;

namespace Calibration
{
    public static class Constants
    {
        public const double Const00 = 15.041;
        public const int ToolConfigurationDataCount = 32;
    }
}

namespace Calibration.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ToolConfiguration
    {
        public double Conf00;
        public double Conf01;
        public double Conf02;

        public double Conf03;
        public double Conf04;
        public double Conf05;

        public double Conf06;
        public double Conf07;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ToolCalibrationArgs
    {
        public double Arg00;
        public double Arg01;
        public int Arg02;
        public int Arg03;
        public int Arg04;
        public int Arg05;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.ToolConfigurationDataCount)]
        public ToolConfiguration[] Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ToolConfigurationError
    {
        public double Error00;
        public double Error01;
        public double Error02;

        public double Error03;
        public double Error04;
        public double Error05;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ToolCalibrationResult
    {
        public double Result00;
        public double Result01;
        public double Result02;
        public double Result03;
        public double Result04;
        public double Result05;
        public double Result06;
        public double Result07;

        public double Result08;
        public double Result09;
        public double Result10;
        public double Result11;
        public double Result12;
        public double Result13;
        public double Result14;
        public double Result15;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.ToolConfigurationDataCount)]
        public ToolConfigurationError[] Errors;
    }

    public static class NativeMethods
    {
        [DllImport("Calibration.Native.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void CalibrateTool(in ToolCalibrationArgs args, out ToolCalibrationResult result);
    }
}

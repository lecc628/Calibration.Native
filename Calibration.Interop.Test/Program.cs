
using Calibration;
using Calibration.Interop;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void InitGyroMultishotCalibration(out GyroMultishotCalibrationArgs args)
{
    args = new GyroMultishotCalibrationArgs
    {
        Rotation = Constants.RotationRate,
        Latitude = 36.71,
        IterationsCount = 50,
        AxSign = 1,
        AySign = 1,
        AzSign = -1,
        Data = new GyroMultishotConfiguration[Constants.GyroMultishotConfigurationDataCount]
        {
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
            new GyroMultishotConfiguration{ Azimuth = 0, Inclination = 1, Toolface = 2, Ax = 3, Ay = 4, Az = 5, Uwx = 6, Uwy = 7 },
        }
    };
}

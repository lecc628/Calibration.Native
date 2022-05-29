
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

static void PrintGyroMultishotCalibrationArgs(in GyroMultishotCalibrationArgs args, in string text)
{
    Console.WriteLine(text);
    Console.WriteLine("Rotation: {0:N6}\t|\tLatitude: {1:N6}", args.Rotation, args.Latitude);
    Console.WriteLine("IterationsCount: {0}", args.IterationsCount);
    Console.WriteLine("AxSign: {0}\t|\tAySign: {1}\t|\tAzSign: {2}", args.AxSign, args.AySign, args.AzSign);

    foreach (var data in args.Data)
    {
        Console.WriteLine(
            "Azimuth: {0:N6}\tAx: {1:N6}\t|\t" +
            "Inclination: {2:N6}\tAy: {3:N6}\t|\t" +
            "Toolface: {4:N6}\tAz: {5:N6}\t|\t" +
            "Uwx: {6:N6}\tUwy: {7:N6}",
            data.Azimuth, data.Ax, data.Inclination, data.Ay, data.Toolface, data.Az, data.Uwx, data.Uwy);
    }
}


using Calibration;
using Calibration.Interop;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void Use_CalibrateGyroMultishot()
{
    /* Initializes the arguments in order to make the calibration. */
    InitGyroMultishotCalibration(out GyroMultishotCalibrationArgs args);

    /* Prints for checking. */
    PrintGyroMultishotCalibrationArgs(in args, "\n\nArguments to make the calibration (before)\n");

    /* Does the calibration. */
    NativeMethods.CalibrateGyroMultishot(in args, out GyroMultishotCalibrationResult result);

    /* Prints for checking. */
    PrintGyroMultishotCalibrationArgs(in args, "\n\nArguments to make the calibration (after)\n");
    PrintGyroMultishotCalibrationResult(in result);
}

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

static void PrintGyroMultishotCalibrationResult(in GyroMultishotCalibrationResult result)
{
    Console.WriteLine("\n\nCalculated coefficients\n");
    Console.WriteLine("KwX:\t{0:N6}\t|\tKwY:\t{1:N6}", result.KwX, result.KwY);
    Console.WriteLine("DeltaX:\t{0:N6}\t|\tDeltaY:\t{1:N6}", result.DeltaX, result.DeltaY);
    Console.WriteLine("RoX:\t{0:N6}\t|\tRoY:\t{1:N6}", result.RoX, result.RoY);
    Console.WriteLine("EpsX:\t{0:N6}\t|\tEpsY:\t{1:N6}", result.EpsX, result.EpsY);
    Console.WriteLine("Eta1X:\t{0:N6}\t|\tEta1Y:\t{1:N6}", result.Eta1X, result.Eta1Y);
    Console.WriteLine("Eta2X:\t{0:N6}\t|\tEta2Y:\t{1:N6}", result.Eta2X, result.Eta2Y);
    Console.WriteLine("TauX:\t{0:N6}\t|\tTauY:\t{1:N6}", result.TauX, result.TauY);
    Console.WriteLine("AlpwXY:\t{0:N6}\t|\tAlpwYX:\t{1:N6}", result.AlpwXY, result.AlpwYX);

    Console.WriteLine("\n\nCalculated errors\n");
    foreach (var error in result.Errors)
    {
        Console.WriteLine(
            "Azimuth: {0:N6}\tAxError: {1:N6}\t|\t" +
            "Inclination: {2:N6}\tAyError: {3:N6}\t|\t" +
            "Toolface: {4:N6}\tAzError: {5:N6}",
            error.Azimuth, error.AxError, error.Inclination, error.AyError, error.Toolface, error.AzError);
    }
}

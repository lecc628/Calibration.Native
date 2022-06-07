
using Calibration;
using Calibration.Interop;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nExample using from CSharp code the CalibrateTool fuction that is implemented in a C-style dll.");
UseCalibrateToolFunction();


static void UseCalibrateToolFunction()
{
    /* Initializes the arguments in order to make the calibration. */
    InitToolCalibration(out ToolCalibrationArgs args);

    /* Prints for checking. */
    PrintToolCalibrationArgs(in args, "\n\nArguments to make the calibration (before)\n");

    /* Does the calibration. */
    NativeMethods.CalibrateTool(in args, out ToolCalibrationResult result);

    /* Prints for checking. */
    PrintToolCalibrationArgs(in args, "\n\nArguments to make the calibration (after)\n");
    PrintToolCalibrationResult(in result);
}

static void InitToolCalibration(out ToolCalibrationArgs args)
{
    args = new ToolCalibrationArgs
    {
        Arg00 = Constants.Const00,
        Arg01 = 36.71,
        Arg02 = 50,
        Arg03 = 1,
        Arg04 = 1,
        Arg05 = -1,
        Data = new ToolConfiguration[Constants.ToolConfigurationDataCount]
        {
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
            new ToolConfiguration{ Conf00 = 0, Conf01 = 1, Conf02 = 2, Conf03 = 3, Conf04 = 4, Conf05 = 5, Conf06 = 6, Conf07 = 7 },
        }
    };
}

static void PrintToolCalibrationArgs(in ToolCalibrationArgs args, in string text)
{
    Console.WriteLine(text);
    Console.WriteLine("Arg00: {0:N6}\t|\tArg01: {1:N6}", args.Arg00, args.Arg01);
    Console.WriteLine("Arg02: {0}", args.Arg02);
    Console.WriteLine("Arg03: {0}\t|\tArg04: {1}\t|\tArg05: {2}", args.Arg03, args.Arg04, args.Arg05);

    foreach (var data in args.Data)
    {
        Console.WriteLine(
            "Conf00: {0:N6}\tConf03: {1:N6}\t|\t" +
            "Conf01: {2:N6}\tConf04: {3:N6}\t|\t" +
            "Conf02: {4:N6}\tConf05: {5:N6}\t|\t" +
            "Conf06: {6:N6}\tConf07: {7:N6}",
            data.Conf00, data.Conf03, data.Conf01, data.Conf04, data.Conf02, data.Conf05, data.Conf06, data.Conf07);
    }
}

static void PrintToolCalibrationResult(in ToolCalibrationResult result)
{
    Console.WriteLine("\n\nCalculated results\n");
    Console.WriteLine("Result00:\t{0:N6}\t|\tResult08:\t{1:N6}", result.Result00, result.Result08);
    Console.WriteLine("Result01:\t{0:N6}\t|\tResult09:\t{1:N6}", result.Result01, result.Result09);
    Console.WriteLine("Result02:\t{0:N6}\t|\tResult10:\t{1:N6}", result.Result02, result.Result10);
    Console.WriteLine("Result03:\t{0:N6}\t|\tResult11:\t{1:N6}", result.Result03, result.Result11);
    Console.WriteLine("Result04:\t{0:N6}\t|\tResult12:\t{1:N6}", result.Result04, result.Result12);
    Console.WriteLine("Result05:\t{0:N6}\t|\tResult13:\t{1:N6}", result.Result05, result.Result13);
    Console.WriteLine("Result06:\t{0:N6}\t|\tResult14:\t{1:N6}", result.Result06, result.Result14);
    Console.WriteLine("Result07:\t{0:N6}\t|\tResult15:\t{1:N6}", result.Result07, result.Result15);

    Console.WriteLine("\n\nCalculated errors\n");
    foreach (var error in result.Errors)
    {
        Console.WriteLine(
            "Error00: {0:N6}\tError03: {1:N6}\t|\t" +
            "Error01: {2:N6}\tError04: {3:N6}\t|\t" +
            "Error02: {4:N6}\tError05: {5:N6}",
            error.Error00, error.Error03, error.Error01, error.Error04, error.Error02, error.Error05);
    }
}

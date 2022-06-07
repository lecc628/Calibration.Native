#include "ToolCalibration.h"

_COMMON_EXPORT_IMPORT_API_ void CalibrateTool(const ToolCalibrationArgs& args, ToolCalibrationResult& result)
{
    result.Result00 = 0.100;
    result.Result01 = 0.101;
    result.Result02 = 0.102;
    result.Result03 = 0.103;
    result.Result04 = 0.104;
    result.Result05 = 0.105;
    result.Result06 = 0.106;
    result.Result07 = 0.107;

    result.Result08 = 0.108;
    result.Result09 = 0.109;
    result.Result10 = 0.110;
    result.Result11 = 0.111;
    result.Result12 = 0.112;
    result.Result13 = 0.113;
    result.Result14 = 0.114;
    result.Result15 = 0.115;

    ToolConfigurationError error = { 0.0, 0.1, 0.2, 0.3, 0.4, 0.5 };

    for (int i = 0; i < TOOL_CONFIGURATION_DATA_COUNT; ++i)
    {
        result.Errors[i] = error;
    }
}

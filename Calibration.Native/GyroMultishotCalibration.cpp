#include "GyroMultishotCalibration.h"

_COMMON_EXPORT_IMPORT_API_ void CalibrateGyroMultishot(const GyroMultishotCalibrationArgs& args, GyroMultishotCalibrationResult& result)
{
    result.KwX = 0.100;
    result.DeltaX = 0.101;
    result.RoX = 0.102;
    result.EpsX = 0.103;
    result.Eta1X = 0.104;
    result.Eta2X = 0.105;
    result.TauX = 0.106;
    result.AlpwXY = 0.107;

    result.KwY = 0.108;
    result.DeltaY = 0.109;
    result.RoY = 0.110;
    result.EpsY = 0.111;
    result.Eta1Y = 0.112;
    result.Eta2Y = 0.113;
    result.TauY = 0.114;
    result.AlpwYX = 0.115;

    GyroMultishotConfigurationError error = { 0.0, 0.1, 0.2, 0.3, 0.4, 0.5 };

    for (int i = 0; i < GYRO_MULTISHOT_CONFIGURATION_DATA_COUNT; ++i)
    {
        result.Errors[i] = error;
    }
}

#pragma once

#ifdef _COMMON_EXPORT_API_
#define _COMMON_EXPORT_IMPORT_API_ __declspec(dllexport)
#elif _COMMON_IMPORT_API_
#define _COMMON_EXPORT_IMPORT_API_ __declspec(dllimport)
#else
#define _COMMON_EXPORT_IMPORT_API_ 
#endif // _COMMON_EXPORT_API_

#ifdef __cplusplus
#define _COMMON_START_EXTERN_C_ extern "C" {
#define _COMMON_END_EXTERN_C_ }
#else
#define _COMMON_START_EXTERN_C_
#define _COMMON_END_EXTERN_C_
#endif

_COMMON_START_EXTERN_C_

#define GYRO_MULTISHOT_CONFIGURATION_DATA_COUNT 32

typedef struct GyroMultishotConfiguration
{
	double Azimuth;
	double Inclination;
	double Toolface;

	double Ax;
	double Ay;
	double Az;

	double Uwx;
	double Uwy;
} GyroMultishotConfiguration;

typedef struct GyroMultishotCalibrationArgs
{
	double Rotation;
	double Latitude;
	int IterationsCount;
	int AxSign;
	int AySign;
	int AzSign;

	GyroMultishotConfiguration Data[GYRO_MULTISHOT_CONFIGURATION_DATA_COUNT];
} GyroMultishotCalibrationArgs;

typedef struct GyroMultishotConfigurationError
{
	double Azimuth;
	double Inclination;
	double Toolface;

	double AxError;
	double AyError;
	double AzError;
} GyroMultishotConfigurationError;

typedef struct GyroMultishotCalibrationResult
{
	double KwX;
	double DeltaX;
	double RoX;
	double EpsX;
	double Eta1X;
	double Eta2X;
	double TauX;
	double AlpwXY;

	double KwY;
	double DeltaY;
	double RoY;
	double EpsY;
	double Eta1Y;
	double Eta2Y;
	double TauY;
	double AlpwYX;

	GyroMultishotConfigurationError Errors[GYRO_MULTISHOT_CONFIGURATION_DATA_COUNT];
} GyroMultishotCalibrationResult;

_COMMON_EXPORT_IMPORT_API_ void CalibrateGyroMultishot(const GyroMultishotCalibrationArgs& args, GyroMultishotCalibrationResult& result);

_COMMON_END_EXTERN_C_

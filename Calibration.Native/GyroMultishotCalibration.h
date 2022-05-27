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

_COMMON_END_EXTERN_C_

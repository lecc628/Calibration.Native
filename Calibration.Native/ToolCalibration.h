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

#define TOOL_CONFIGURATION_DATA_COUNT 32

typedef struct ToolConfiguration
{
	double Conf00;
	double Conf01;
	double Conf02;

	double Conf03;
	double Conf04;
	double Conf05;

	double Conf06;
	double Conf07;
} ToolConfiguration;

typedef struct ToolCalibrationArgs
{
	double Arg00;
	double Arg01;
	int Arg02;
	int Arg03;
	int Arg04;
	int Arg05;

	ToolConfiguration Data[TOOL_CONFIGURATION_DATA_COUNT];
} ToolCalibrationArgs;

typedef struct ToolConfigurationError
{
	double Error00;
	double Error01;
	double Error02;

	double Error03;
	double Error04;
	double Error05;
} ToolConfigurationError;

typedef struct ToolCalibrationResult
{
	double Result00;
	double Result01;
	double Result02;
	double Result03;
	double Result04;
	double Result05;
	double Result06;
	double Result07;

	double Result08;
	double Result09;
	double Result10;
	double Result11;
	double Result12;
	double Result13;
	double Result14;
	double Result15;

	ToolConfigurationError Errors[TOOL_CONFIGURATION_DATA_COUNT];
} ToolCalibrationResult;

_COMMON_EXPORT_IMPORT_API_ void CalibrateTool(const ToolCalibrationArgs& args, ToolCalibrationResult& result);

_COMMON_END_EXTERN_C_

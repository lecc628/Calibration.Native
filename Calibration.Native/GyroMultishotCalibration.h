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

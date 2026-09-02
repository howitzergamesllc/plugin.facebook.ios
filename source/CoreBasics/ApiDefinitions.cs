
using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;

namespace Facebook.CoreBasics
{

	// @interface FBSDKBase64 : NSObject
	[BaseType (typeof(NSObject))]
	interface FBSDKBase64
	{
		// +(NSData * _Nullable)decodeAsData:(NSString * _Nullable)string;
		[Static]
		[Export ("decodeAsData:")]
		[return: NullAllowed]
		NSData DecodeAsData ([NullAllowed] string @string);

		// +(NSString * _Nullable)decodeAsString:(NSString * _Nullable)string;
		[Static]
		[Export ("decodeAsString:")]
		[return: NullAllowed]
		string DecodeAsString ([NullAllowed] string @string);

		// +(NSString * _Nullable)encodeString:(NSString * _Nullable)string;
		[Static]
		[Export ("encodeString:")]
		[return: NullAllowed]
		string EncodeString ([NullAllowed] string @string);

		// +(NSString * _Nonnull)base64FromBase64Url:(NSString * _Nonnull)base64Url;
		[Static]
		[Export ("base64FromBase64Url:")]
		string Base64FromBase64Url (string base64Url);
	}

	// typedef id _Nullable (^FBSDKInvalidObjectHandler)(id _Nonnull, BOOL * _Nonnull);
	unsafe delegate NSObject FBSDKInvalidObjectHandler (NSObject arg0, bool* arg1);

	// @interface FBSDKBasicUtility : NSObject
	[BaseType (typeof(NSObject))]
	interface FBSDKBasicUtility
	{
		// +(NSString * _Nullable)JSONStringForObject:(id _Nonnull)object error:(NSError * _Nullable * _Nullable)errorRef invalidObjectHandler:(FBSDKInvalidObjectHandler _Nullable)invalidObjectHandler;
		[Static]
		[Export ("JSONStringForObject:error:invalidObjectHandler:")]
		[return: NullAllowed]
		string JSONStringForObject (NSObject @object, [NullAllowed] out NSError errorRef, [NullAllowed] FBSDKInvalidObjectHandler invalidObjectHandler);

		// +(BOOL)dictionary:(NSMutableDictionary<id,id> * _Nonnull)dictionary setJSONStringForObject:(id _Nonnull)object forKey:(id<NSCopying> _Nonnull)key error:(NSError * _Nullable * _Nullable)errorRef;
		[Static]
		[Export ("dictionary:setJSONStringForObject:forKey:error:")]
		bool Dictionary (NSMutableDictionary<NSObject, NSObject> dictionary, NSObject @object, NSCopying key, [NullAllowed] out NSError errorRef);

		// +(id _Nullable)objectForJSONString:(NSString * _Nonnull)string error:(NSError * _Nullable * _Nullable)errorRef;
		[Static]
		[Export ("objectForJSONString:error:")]
		[return: NullAllowed]
		NSObject ObjectForJSONString (string @string, [NullAllowed] out NSError errorRef);

		// +(NSString * _Nullable)queryStringWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary error:(NSError * _Nullable * _Nullable)errorRef invalidObjectHandler:(FBSDKInvalidObjectHandler _Nullable)invalidObjectHandler;
		[Static]
		[Export ("queryStringWithDictionary:error:invalidObjectHandler:")]
		[return: NullAllowed]
		string QueryStringWithDictionary (NSDictionary<NSString, NSObject> dictionary, [NullAllowed] out NSError errorRef, [NullAllowed] FBSDKInvalidObjectHandler invalidObjectHandler);

		// +(id _Nonnull)convertRequestValue:(id _Nonnull)value;
		[Static]
		[Export ("convertRequestValue:")]
		NSObject ConvertRequestValue (NSObject value);

		// +(NSString * _Nonnull)URLEncode:(NSString * _Nonnull)value;
		[Static]
		[Export ("URLEncode:")]
		string URLEncode (string value);

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)dictionaryWithQueryString:(NSString * _Nonnull)queryString;
		[Static]
		[Export ("dictionaryWithQueryString:")]
		NSDictionary<NSString, NSString> DictionaryWithQueryString (string queryString);

		// +(NSString * _Nonnull)URLDecode:(NSString * _Nonnull)value;
		[Static]
		[Export ("URLDecode:")]
		string URLDecode (string value);

		// +(NSData * _Nullable)gzip:(NSData * _Nonnull)data;
		[Static]
		[Export ("gzip:")]
		[return: NullAllowed]
		NSData Gzip (NSData data);

		// +(NSString * _Nonnull)anonymousID;
		[Static]
		[Export ("anonymousID")]
		string AnonymousID { get; }

		// +(NSString * _Nonnull)persistenceFilePath:(NSString * _Nonnull)filename;
		[Static]
		[Export ("persistenceFilePath:")]
		string PersistenceFilePath (string filename);

		// +(NSString * _Nullable)SHA256Hash:(NSObject * _Nullable)input;
		[Static]
		[Export ("SHA256Hash:")]
		[return: NullAllowed]
		string SHA256Hash ([NullAllowed] NSObject input);
	}

	// @protocol FBSDKCrashObserving
	interface IFBSDKCrashObserving {}

	[Protocol]
	interface FBSDKCrashObserving
	{
		// @required @property (copy, nonatomic) NSArray<NSString *> * _Nonnull prefixes;
		[Abstract]
		[Export ("prefixes", ArgumentSemantic.Copy)]
		string[] Prefixes { get; set; }

		// @required @property (copy, nonatomic) NSArray<NSString *> * _Nullable frameworks;
		[Abstract]
		[NullAllowed, Export ("frameworks", ArgumentSemantic.Copy)]
		string[] Frameworks { get; set; }

		// @required -(void)didReceiveCrashLogs:(NSArray<NSDictionary<NSString *,id> *> * _Nonnull)crashLogs;
		[Abstract]
		[Export ("didReceiveCrashLogs:")]
		void DidReceiveCrashLogs (NSDictionary<NSString, NSObject>[] crashLogs);
	}

	// @interface FBSDKCrashHandler : NSObject <FBSDKCrashHandler>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKCrashHandler
	{
		// @property (readonly, nonatomic, class) FBSDKCrashHandler * _Nonnull shared;
		[Static]
		[Export ("shared")]
		FBSDKCrashHandler Shared { get; }

		// +(void)disable;
		[Static]
		[Export ("disable")]
		void Disable ();

		// +(void)addObserver:(id<FBSDKCrashObserving> _Nonnull)observer;
		[Static]
		[Export ("addObserver:")]
		void AddObserver (IFBSDKCrashObserving observer);

		// +(void)removeObserver:(id<FBSDKCrashObserving> _Nonnull)observer;
		[Static]
		[Export ("removeObserver:")]
		void RemoveObserver (IFBSDKCrashObserving observer);

		// +(void)clearCrashReportFiles;
		[Static]
		[Export ("clearCrashReportFiles")]
		void ClearCrashReportFiles ();

		// +(NSString * _Nonnull)getFBSDKVersion;
		[Static]
		[Export ("getFBSDKVersion")]
		string FBSDKVersion { get; }

		// -(void)saveException:(NSException * _Nonnull)exception;
		[Export ("saveException:")]
		void SaveException (NSException exception);
	}

	// @protocol FBSDKDataPersisting
	interface IFBSDKDataPersisting {}

	[Protocol]
	interface FBSDKDataPersisting
	{
		// @required -(void)fb_setInteger:(NSInteger)integer forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("fb_setInteger:forKey:")]
		void Fb_setInteger (nint integer, string key);

		// @required -(void)fb_setObject:(id _Nonnull)object forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("fb_setObject:forKey:")]
		void Fb_setObject (NSObject @object, string key);

		// @required -(NSData * _Nullable)fb_dataForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("fb_dataForKey:")]
		[return: NullAllowed]
		NSData Fb_dataForKey (string key);

		// @required -(NSInteger)fb_integerForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("fb_integerForKey:")]
		nint Fb_integerForKey (string key);

		// @required -(NSString * _Nullable)fb_stringForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("fb_stringForKey:")]
		[return: NullAllowed]
		string Fb_stringForKey (string key);

		// @required -(id _Nullable)fb_objectForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("fb_objectForKey:")]
		[return: NullAllowed]
		NSObject Fb_objectForKey (string key);

		// @required -(BOOL)fb_boolForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("fb_boolForKey:")]
		bool Fb_boolForKey (string key);

		// @required -(void)fb_setBool:(BOOL)value forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("fb_setBool:forKey:")]
		void Fb_setBool (bool value, string key);

		// @required -(void)fb_removeObjectForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("fb_removeObjectForKey:")]
		void Fb_removeObjectForKey (string key);
	}

/*
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char FBLinkable_NSUserDefaults_DataPersisting;
		[Field ("FBLinkable_NSUserDefaults_DataPersisting", "__Internal")]
		sbyte FBLinkable_NSUserDefaults_DataPersisting { get; }

		// extern const void *const _Nonnull FBLink_NSUserDefaults_DataPersisting __attribute__((weak));
		[Field ("FBLink_NSUserDefaults_DataPersisting", "__Internal")]
		unsafe void* FBLink_NSUserDefaults_DataPersisting { get; }

		// extern const void *const _Nonnull FBLink_NSUserDefaults_DataPersisting __attribute__((used)) __attribute__((weak));
		[Field ("FBLink_NSUserDefaults_DataPersisting", "__Internal")]
		unsafe void* FBLink_NSUserDefaults_DataPersisting { get; }
	}
*/

	// @interface DataPersisting (NSUserDefaults) <FBSDKDataPersisting>
	[Category]
	[BaseType (typeof(NSUserDefaults))]
	interface NSUserDefaults_DataPersisting : IFBSDKDataPersisting
	{
	}

	// @protocol FBSDKFileDataExtracting
	interface IFBSDKFileDataExtracting {}

	[Model]
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBSDKFileDataExtracting
	{
		// @required +(NSData * _Nullable)fb_dataWithContentsOfFile:(NSString * _Nonnull)path options:(NSDataReadingOptions)readOptionsMask error:(NSError * _Nullable * _Nullable)error;
		[Static, Abstract]
		[Export ("fb_dataWithContentsOfFile:options:error:")]
		[return: NullAllowed]
		NSData GetData (string path, NSDataReadingOptions readOptionsMask, [NullAllowed] out NSError error);
	}

/*
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char FBLinkable_NSData_FileDataExtracting;
		[Field ("FBLinkable_NSData_FileDataExtracting", "__Internal")]
		sbyte FBLinkable_NSData_FileDataExtracting { get; }

		// extern const void *const _Nonnull FBLink_NSData_FileDataExtracting __attribute__((weak));
		[Field ("FBLink_NSData_FileDataExtracting", "__Internal")]
		unsafe void* FBLink_NSData_FileDataExtracting { get; }

		// extern const void *const _Nonnull FBLink_NSData_FileDataExtracting __attribute__((used)) __attribute__((weak));
		[Field ("FBLink_NSData_FileDataExtracting", "__Internal")]
		unsafe void* FBLink_NSData_FileDataExtracting { get; }
	}
	*/

	// @interface FileDataExtracting (NSData) <FBSDKFileDataExtracting>
	[Category]
	[BaseType (typeof(NSData))]
	interface NSData_FileDataExtracting : IFBSDKFileDataExtracting
	{
	}

	// @protocol FBSDKFileManaging
	interface IFBSDKFileManaging {}

	[Protocol]
	interface FBSDKFileManaging
	{
		// @required -(BOOL)fb_createDirectoryAtPath:(NSString * _Nonnull)path withIntermediateDirectories:(BOOL)createIntermediates attributes:(NSDictionary<NSFileAttributeKey,id> * _Nullable)attributes error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export ("fb_createDirectoryAtPath:withIntermediateDirectories:attributes:error:")]
		bool Fb_createDirectoryAtPath (string path, bool createIntermediates, [NullAllowed] NSDictionary<NSString, NSObject> attributes, [NullAllowed] out NSError error);

		// @required -(BOOL)fb_fileExistsAtPath:(NSString * _Nonnull)path;
		[Abstract]
		[Export ("fb_fileExistsAtPath:")]
		bool Fb_fileExistsAtPath (string path);

		// @required -(BOOL)fb_removeItemAtPath:(NSString * _Nonnull)path error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export ("fb_removeItemAtPath:error:")]
		bool Fb_removeItemAtPath (string path, [NullAllowed] out NSError error);

		// @required -(NSArray<NSString *> * _Nonnull)fb_contentsOfDirectoryAtPath:(NSString * _Nonnull)path error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error")));
		[Abstract]
		[Export ("fb_contentsOfDirectoryAtPath:error:")]
		string[] Fb_contentsOfDirectoryAtPath (string path, [NullAllowed] out NSError error);
	}

/*
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char FBLinkable_NSFileManager_FileManaging;
		[Field ("FBLinkable_NSFileManager_FileManaging", "__Internal")]
		sbyte FBLinkable_NSFileManager_FileManaging { get; }

		// extern const void *const _Nonnull FBLink_NSFileManager_FileManaging __attribute__((weak));
		[Field ("FBLink_NSFileManager_FileManaging", "__Internal")]
		unsafe void* FBLink_NSFileManager_FileManaging { get; }

		// extern const void *const _Nonnull FBLink_NSFileManager_FileManaging __attribute__((used)) __attribute__((weak));
		[Field ("FBLink_NSFileManager_FileManaging", "__Internal")]
		unsafe void* FBLink_NSFileManager_FileManaging { get; }
	}
*/

	// @interface FileManaging (NSFileManager) <FBSDKFileManaging>
	[Category]
	[BaseType (typeof(NSFileManager))]
	interface NSFileManager_FileManaging : IFBSDKFileManaging
	{
	}

	// @protocol FBSDKInfoDictionaryProviding
	interface IFBSDKInfoDictionaryProviding {}
	
	[Protocol]
	interface FBSDKInfoDictionaryProviding
	{
		// @required @property (readonly, copy) NSDictionary<NSString *,id> * _Nullable fb_infoDictionary;
		[Abstract]
		[NullAllowed, Export ("fb_infoDictionary", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Fb_infoDictionary { get; }

		// @required @property (readonly, copy) NSString * _Nullable fb_bundleIdentifier;
		[Abstract]
		[NullAllowed, Export ("fb_bundleIdentifier")]
		string Fb_bundleIdentifier { get; }

		// @required -(id _Nullable)fb_objectForInfoDictionaryKey:(NSString * _Nonnull)key __attribute__((swift_name("fb_object(forInfoDictionaryKey:)")));
		[Abstract]
		[Export ("fb_objectForInfoDictionaryKey:")]
		[return: NullAllowed]
		NSObject Fb_objectForInfoDictionaryKey (string key);
	}

/*
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char FBLinkable_NSBundle_InfoDictionaryProviding;
		[Field ("FBLinkable_NSBundle_InfoDictionaryProviding", "__Internal")]
		sbyte FBLinkable_NSBundle_InfoDictionaryProviding { get; }

		// extern const void *const _Nonnull FBLink_NSBundle_InfoDictionaryProviding __attribute__((weak));
		[Field ("FBLink_NSBundle_InfoDictionaryProviding", "__Internal")]
		unsafe void* FBLink_NSBundle_InfoDictionaryProviding { get; }

		// extern const void *const _Nonnull FBLink_NSBundle_InfoDictionaryProviding __attribute__((used)) __attribute__((weak));
		[Field ("FBLink_NSBundle_InfoDictionaryProviding", "__Internal")]
		unsafe void* FBLink_NSBundle_InfoDictionaryProviding { get; }
	}
	*/

	// @interface InfoDictionaryProviding (NSBundle) <FBSDKInfoDictionaryProviding>
	[Category]
	[BaseType (typeof(NSBundle))]
	interface NSBundle_InfoDictionaryProviding : IFBSDKInfoDictionaryProviding
	{
	}

	// @interface FBSDKLibAnalyzer : NSObject
	[BaseType (typeof(NSObject))]
	interface FBSDKLibAnalyzer
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)getMethodsTable:(NSArray<NSString *> * _Nonnull)prefixes frameworks:(NSArray<NSString *> * _Nullable)frameworks;
		[Static]
		[Export ("getMethodsTable:frameworks:")]
		NSDictionary<NSString, NSString> GetMethodsTable (string[] prefixes, [NullAllowed] string[] frameworks);

		// +(NSArray<NSString *> * _Nullable)symbolicateCallstack:(NSArray<NSString *> * _Nonnull)callstack methodMapping:(NSDictionary<NSString *,id> * _Nonnull)methodMapping;
		[Static]
		[Export ("symbolicateCallstack:methodMapping:")]
		[return: NullAllowed]
		string[] SymbolicateCallstack (string[] callstack, NSDictionary<NSString, NSObject> methodMapping);
	}

	// @protocol FBSDKNetworkTask <NSObject>
	interface IFBSDKNetworkTask {}
	
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKNetworkTask
	{
		// @required @property (readonly) NSURLSessionTaskState fb_state;
		[Abstract]
		[Export ("fb_state")]
		NSUrlSessionTaskState Fb_state { get; }

		// @required -(void)fb_resume;
		[Abstract]
		[Export ("fb_resume")]
		void Fb_resume ();

		// @required -(void)fb_cancel;
		[Abstract]
		[Export ("fb_cancel")]
		void Fb_cancel ();
	}

/*
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char FBLinkable_NSURLSessionTask_NetworkTask;
		[Field ("FBLinkable_NSURLSessionTask_NetworkTask", "__Internal")]
		sbyte FBLinkable_NSURLSessionTask_NetworkTask { get; }

		// extern const void *const _Nonnull FBLink_NSURLSessionTask_NetworkTask __attribute__((weak));
		[Field ("FBLink_NSURLSessionTask_NetworkTask", "__Internal")]
		unsafe void* FBLink_NSURLSessionTask_NetworkTask { get; }

		// extern const void *const _Nonnull FBLink_NSURLSessionTask_NetworkTask __attribute__((used)) __attribute__((weak));
		[Field ("FBLink_NSURLSessionTask_NetworkTask", "__Internal")]
		unsafe void* FBLink_NSURLSessionTask_NetworkTask { get; }
	}
	*/


	// typedef id _Nullable (^FBSDKInvalidObjectHandler)(id _Nonnull, BOOL * _Nonnull);
	unsafe delegate NSObject FBSDKKeysAndObjectsHandler (NSObject arg0, NSObject arg1, bool* arg2);


	// @interface NetworkTask (NSURLSessionTask) <FBSDKNetworkTask>
	[Category]
	[BaseType (typeof(NSUrlSessionTask))]
	interface NSURLSessionTask_NetworkTask : IFBSDKNetworkTask
	{
	}

	// @interface FBSDKTypeUtility : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKTypeUtility
	{
		// +(NSArray<id> * _Nullable)arrayValue:(id _Nullable)object;
		[Static]
		[Export ("arrayValue:")]
		[return: NullAllowed]
		NSObject[] ArrayValue ([NullAllowed] NSObject @object);

		// +(id _Nullable)array:(NSArray<id> * _Nonnull)array objectAtIndex:(NSUInteger)index;
		[Static]
		[Export ("array:objectAtIndex:")]
		[return: NullAllowed]
		NSObject Array (NSObject[] array, nuint index);

		// +(void)array:(NSMutableArray * _Nonnull)array addObject:(id _Nullable)object;
		[Static]
		[Export ("array:addObject:")]
		void Array (NSMutableArray array, [NullAllowed] NSObject @object);

		// +(BOOL)boolValue:(id _Nonnull)object;
		[Static]
		[Export ("boolValue:")]
		bool BoolValue (NSObject @object);

		// +(NSDictionary<NSString *,id> * _Nullable)dictionaryValue:(id _Nullable)object;
		[Static]
		[Export ("dictionaryValue:")]
		[return: NullAllowed]
		NSDictionary<NSString, NSObject> DictionaryValue ([NullAllowed] NSObject @object);

		// +(id _Nullable)dictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary objectForKey:(NSString * _Nonnull)key ofType:(Class _Nonnull)type;
		[Static]
		[Export ("dictionary:objectForKey:ofType:")]
		[return: NullAllowed]
		NSObject Dictionary (NSDictionary<NSString, NSObject> dictionary, string key, Class type);

		// +(void)dictionary:(NSMutableDictionary * _Nonnull)dictionary setObject:(id _Nullable)object forKey:(id<NSCopying> _Nullable)key;
		[Static]
		[Export ("dictionary:setObject:forKey:")]
		void Dictionary (NSMutableDictionary dictionary, [NullAllowed] NSObject @object, [NullAllowed] NSCopying key);

		// +(void)dictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary enumerateKeysAndObjectsUsingBlock:(void (^ _Nonnull)(id _Nonnull, id _Nonnull, BOOL * _Nonnull))block;
		[Static]
		[Export ("dictionary:enumerateKeysAndObjectsUsingBlock:")]
		unsafe void Dictionary (NSDictionary<NSString, NSObject> dictionary, FBSDKKeysAndObjectsHandler handler);

		// +(NSInteger)integerValue:(id _Nonnull)object;
		[Static]
		[Export ("integerValue:")]
		nint IntegerValue (NSObject @object);

		// +(double)doubleValue:(id _Nonnull)object;
		[Static]
		[Export ("doubleValue:")]
		double DoubleValue (NSObject @object);

		// +(NSNumber * _Nonnull)numberValue:(id _Nonnull)object;
		[Static]
		[Export ("numberValue:")]
		NSNumber NumberValue (NSObject @object);

		// +(NSString * _Nonnull)stringValueOrNil:(id _Nonnull)object;
		[Static]
		[Export ("stringValueOrNil:")]
		string StringValueOrNil (NSObject @object);

		// +(id _Nullable)objectValue:(id _Nonnull)object;
		[Static]
		[Export ("objectValue:")]
		[return: NullAllowed]
		NSObject ObjectValue (NSObject @object);

		// +(NSString * _Nullable)coercedToStringValue:(id _Nonnull)object;
		[Static]
		[Export ("coercedToStringValue:")]
		[return: NullAllowed]
		string CoercedToStringValue (NSObject @object);

		// +(NSTimeInterval)timeIntervalValue:(id _Nonnull)object;
		[Static]
		[Export ("timeIntervalValue:")]
		double TimeIntervalValue (NSObject @object);

		// +(NSUInteger)unsignedIntegerValue:(id _Nonnull)object;
		[Static]
		[Export ("unsignedIntegerValue:")]
		nuint UnsignedIntegerValue (NSObject @object);

		// +(NSURL * _Nullable)coercedToURLValue:(id _Nonnull)object;
		[Static]
		[Export ("coercedToURLValue:")]
		[return: NullAllowed]
		NSUrl CoercedToURLValue (NSObject @object);

		// +(NSData * _Nullable)dataWithJSONObject:(id _Nonnull)obj options:(NSJSONWritingOptions)opt error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("dataWithJSONObject:options:error:")]
		[return: NullAllowed]
		NSData DataWithJSONObject (NSObject obj, NSJsonWritingOptions opt, [NullAllowed] out NSError error);

		// +(id _Nullable)JSONObjectWithData:(NSData * _Nonnull)data options:(NSJSONReadingOptions)opt error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("JSONObjectWithData:options:error:")]
		[return: NullAllowed]
		NSObject JSONObjectWithData (NSData data, NSJsonReadingOptions opt, [NullAllowed] out NSError error);
	}

	delegate void FBSDKURLSessionCompletionHandler([NullAllowed] NSData data, [NullAllowed] NSUrlResponse response, [NullAllowed] NSError error);

	// @protocol FBSDKURLSessionProviding <NSObject>
	interface IFBSDKURLSessionProviding {}
	
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface FBSDKURLSessionProviding
	{
		// @required -(id<FBSDKNetworkTask> _Nonnull)fb_dataTaskWithRequest:(NSURLRequest * _Nonnull)request completionHandler:(void (^ _Nonnull)(NSData * _Nullable, NSURLResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export ("fb_dataTaskWithRequest:completionHandler:")]
		IFBSDKNetworkTask CompletionHandler (NSUrlRequest request, FBSDKURLSessionCompletionHandler completionHandler);
	}

/*
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char FBLinkable_NSURLSession_URLSessionProviding;
		[Field ("FBLinkable_NSURLSession_URLSessionProviding", "__Internal")]
		sbyte FBLinkable_NSURLSession_URLSessionProviding { get; }

		// extern const void *const _Nonnull FBLink_NSURLSession_URLSessionProviding __attribute__((weak));
		[Field ("FBLink_NSURLSession_URLSessionProviding", "__Internal")]
		unsafe void* FBLink_NSURLSession_URLSessionProviding { get; }

		// extern const void *const _Nonnull FBLink_NSURLSession_URLSessionProviding __attribute__((used)) __attribute__((weak));
		[Field ("FBLink_NSURLSession_URLSessionProviding", "__Internal")]
		unsafe void* FBLink_NSURLSession_URLSessionProviding { get; }
	}
	*/

	// @interface URLSessionProviding (NSURLSession) <FBSDKURLSessionProviding>
	[Category]
	[BaseType (typeof(NSUrlSession))]
	interface NSURLSession_URLSessionProviding : IFBSDKURLSessionProviding
	{
	}

	// typedef void (^FBSDKURLSessionTaskBlock)(NSData * _Nullable, NSURLResponse * _Nullable, NSError * _Nullable);
	delegate void FBSDKURLSessionTaskBlock ([NullAllowed] NSData data, [NullAllowed] NSUrlResponse response, [NullAllowed] NSError error);

	// @interface FBSDKURLSessionTask : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKURLSessionTask
	{
		// @property (nonatomic, strong) id<FBSDKNetworkTask> _Nonnull task;
		[Export ("task", ArgumentSemantic.Strong)]
		IFBSDKNetworkTask Task { get; set; }

		// @property (readonly, atomic) NSURLSessionTaskState state;
		[Export ("state")]
		NSUrlSessionTaskState State { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nonnull requestStartDate;
		[Export ("requestStartDate", ArgumentSemantic.Strong)]
		NSDate RequestStartDate { get; }

		// @property (copy, nonatomic) FBSDKURLSessionTaskBlock _Nullable handler;
		[NullAllowed, Export ("handler", ArgumentSemantic.Copy)]
		FBSDKURLSessionTaskBlock Handler { get; set; }

		// @property (assign, nonatomic) uint64_t requestStartTime;
		[Export ("requestStartTime")]
		ulong RequestStartTime { get; set; }

		// @property (assign, nonatomic) NSUInteger loggerSerialNumber;
		[Export ("loggerSerialNumber")]
		nuint LoggerSerialNumber { get; set; }

		// -(instancetype _Nullable)initWithRequest:(NSURLRequest * _Nonnull)request fromSession:(id<FBSDKURLSessionProviding> _Nonnull)session completionHandler:(FBSDKURLSessionTaskBlock _Nullable)handler;
		[Export ("initWithRequest:fromSession:completionHandler:")]
		NativeHandle Constructor (NSUrlRequest request, IFBSDKURLSessionProviding session, [NullAllowed] FBSDKURLSessionTaskBlock handler);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();
	}

	delegate void FBSDKDispatchBlock();

	// @interface FBSDKURLSession : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FBSDKURLSession
	{
		// @property (atomic, strong) NSURLSession * _Nullable session;
		[NullAllowed, Export ("session", ArgumentSemantic.Strong)]
		NSUrlSession Session { get; set; }

		// @property (nonatomic, weak) id<NSURLSessionDataDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		INSUrlSessionDataDelegate Delegate { get; set; }

		// @property (retain, nonatomic) NSOperationQueue * _Nullable delegateQueue;
		[NullAllowed, Export ("delegateQueue", ArgumentSemantic.Retain)]
		NSOperationQueue DelegateQueue { get; set; }

		// -(instancetype _Nonnull)initWithDelegate:(id<NSURLSessionDataDelegate> _Nonnull)delegate delegateQueue:(NSOperationQueue * _Nonnull)delegateQueue;
		[Export ("initWithDelegate:delegateQueue:")]
		NativeHandle Constructor (INSUrlSessionDataDelegate @delegate, NSOperationQueue delegateQueue);

		// -(void)executeURLRequest:(NSURLRequest * _Nonnull)request completionHandler:(FBSDKURLSessionTaskBlock _Nonnull)handler;
		[Export ("executeURLRequest:completionHandler:")]
		void ExecuteURLRequest (NSUrlRequest request, FBSDKURLSessionTaskBlock handler);

		// -(void)updateSessionWithBlock:(dispatch_block_t _Nonnull)block;
		[Export ("updateSessionWithBlock:")]
		void UpdateSessionWithBlock (FBSDKDispatchBlock handler);

		// -(void)invalidateAndCancel;
		[Export ("invalidateAndCancel")]
		void InvalidateAndCancel ();

		// -(BOOL)valid;
		[Export ("valid")]
		bool Valid { get; }
	}

	// @protocol FBSDKNotificationDelivering
	interface IFBSDKNotificationDelivering {}
	
	
	[Protocol]
	interface FBSDKNotificationDelivering
	{
		// @required -(void)fb_addObserver:(id _Nonnull)observer selector:(SEL _Nonnull)selector name:(NSNotificationName _Nullable)name object:(id _Nullable)object;
		[Abstract]
		[Export ("fb_addObserver:selector:name:object:")]
		void Fb_addObserver (NSObject observer, Selector selector, [NullAllowed] string name, [NullAllowed] NSObject @object);

		// @required -(id<NSObject> _Nonnull)fb_addObserverForName:(NSNotificationName _Nullable)name object:(id _Nullable)obj queue:(NSOperationQueue * _Nullable)queue usingBlock:(void (^ _Nonnull)(NSNotification * _Nonnull))block;
		[Abstract]
		[Export ("fb_addObserverForName:object:queue:usingBlock:")]
		NSObject Fb_addObserverForName ([NullAllowed] string name, [NullAllowed] NSObject obj, [NullAllowed] NSOperationQueue queue, Action<NSNotification> block);

		// @required -(void)fb_removeObserver:(id _Nonnull)observer;
		[Abstract]
		[Export ("fb_removeObserver:")]
		void Fb_removeObserver (NSObject observer);
	}

/*
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char FBLinkable_NSNotificationCenter_NotificationDelivering;
		[Field ("FBLinkable_NSNotificationCenter_NotificationDelivering", "__Internal")]
		sbyte FBLinkable_NSNotificationCenter_NotificationDelivering { get; }

		// extern const void *const _Nonnull FBLink_NSNotificationCenter_NotificationDelivering __attribute__((weak));
		[Field ("FBLink_NSNotificationCenter_NotificationDelivering", "__Internal")]
		unsafe void* FBLink_NSNotificationCenter_NotificationDelivering { get; }

		// extern const void *const _Nonnull FBLink_NSNotificationCenter_NotificationDelivering __attribute__((used)) __attribute__((weak));
		[Field ("FBLink_NSNotificationCenter_NotificationDelivering", "__Internal")]
		unsafe void* FBLink_NSNotificationCenter_NotificationDelivering { get; }
	}
	*/

	// @interface NotificationDelivering (NSNotificationCenter) <FBSDKNotificationDelivering>
	[Category]
	[BaseType (typeof(NSNotificationCenter))]
	interface NSNotificationCenter_NotificationDelivering : IFBSDKNotificationDelivering
	{
	}
}
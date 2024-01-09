module rec AzHttp
open System
open Fable.Core
open Fable.Core.JS
open AzAbort
open AzAuth
open AzLogger
open AzTracing

type Array<'T> = System.Collections.Generic.IList<'T>
type Error = System.Exception
type Function = System.Action
type ReadonlyArray<'T> = System.Collections.Generic.IReadOnlyList<'T>
type RegExp = System.Text.RegularExpressions.Regex

// type AbortSignalLike = @azure_abort_controller.AbortSignalLike
// type AccessToken = @azure_core_auth.AccessToken
// type Context = @azure_core_tracing.Context
// type Debugger = @azure_logger.Debugger
// type GetTokenOptions = @azure_core_auth.GetTokenOptions
// type isTokenCredential = @azure_core_auth.isTokenCredential
// type OperationTracingOptions = @azure_core_tracing.OperationTracingOptions
// type Span = @azure_core_tracing.Span
// type SpanOptions = @azure_core_tracing.SpanOptions
// type TokenCredential = @azure_core_auth.TokenCredential
let [<Import("Constants","temp")>] Constants: Constants = jsNative
let [<Import("isNode","temp")>] isNode: bool = jsNative
let [<Import("MapperType","temp")>] MapperType: MapperType = jsNative
let [<Import("XML_ATTRKEY","temp")>] XML_ATTRKEY: obj = jsNative
let [<Import("XML_CHARKEY","temp")>] XML_CHARKEY: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract AccessTokenRefresher: AccessTokenRefresherStatic
    abstract ApiKeyCredentials: ApiKeyCredentialsStatic
    /// <summary>Applies the properties on the prototype of sourceCtors to the prototype of targetCtor</summary>
    // / <param name="sourceCtors">- An array of source objects from which the properties need to be taken.</param>
    abstract applyMixins: targetCtorParam: obj * sourceCtors: ResizeArray<obj option> -> unit
    abstract BaseRequestPolicy: BaseRequestPolicyStatic
    abstract BasicAuthenticationCredentials: BasicAuthenticationCredentialsStatic
    /// <summary>Creates a new factory for a RequestPolicy that applies a bearer token to
    /// the requests' `Authorization` headers.</summary>
    /// <param name="credential">- The TokenCredential implementation that can supply the bearer token.</param>
    /// <param name="scopes">- The scopes for which the bearer token applies.</param>
    abstract bearerTokenAuthenticationPolicy: credential: TokenCredential * scopes: U2<string, ResizeArray<string>> -> RequestPolicyFactory
    abstract createPipelineFromOptions: pipelineOptions: InternalPipelineOptions * ?authPolicyFactory: RequestPolicyFactory -> ServiceClientOptions
    /// This function is only here for compatibility. Use createSpanFunction in core-tracing.
    abstract createSpanFunction: args: SpanConfig -> (string -> 'T -> IExportsCreateSpanFunction<'T>)
    abstract DefaultHttpClient: DefaultHttpClientStatic
    /// <summary>A wrapper for setTimeout that resolves a promise after delayInMs milliseconds.</summary>
    /// <param name="delayInMs">- The number of milliseconds to be delayed.</param>
    /// <param name="value">- The value to be resolved with after a timeout of t milliseconds.</param>
    /// <param name="options">- The options for delay - currently abort options</param>
    abstract delay: delayInMs: float * ?value: 'T * ?options: DelayOptions -> Promise<U2<'T, unit>>
    /// Create a new serialization RequestPolicyCreator that will serialized HTTP request bodies as they
    /// pass through the HTTP pipeline.
    abstract deserializationPolicy: ?deserializationContentTypes: DeserializationContentTypes * ?parsingOptions: SerializerOptions -> RequestPolicyFactory
    abstract deserializeResponseBody: jsonContentTypes: ResizeArray<string> * xmlContentTypes: ResizeArray<string> * response: HttpOperationResponse * ?options: SerializerOptions -> Promise<HttpOperationResponse>
    /// Returns a request policy factory that can be used to create an instance of
    /// {@link DisableResponseDecompressionPolicy}.
    abstract disableResponseDecompressionPolicy: unit -> RequestPolicyFactory
    /// <summary>Encodes an URI.</summary>
    /// <param name="uri">- The URI to be encoded.</param>
    abstract encodeUri: uri: string -> string
    /// <summary>Executes an array of promises sequentially. Inspiration of this method is here:
    /// https://pouchdb.com/2015/05/18/we-have-a-problem-with-promises.html. An awesome blog on promises!</summary>
    /// <param name="promiseFactories">- An array of promise factories(A function that return a promise)</param>
    /// <param name="kickstart">- Input to the first promise that is used to kickstart the promise chain.
    /// If not provided then the promise chain starts with undefined.</param>
    abstract executePromisesSequentially: promiseFactories: Array<obj option> * kickstart: obj -> Promise<obj option>
    abstract ExpiringAccessTokenCache: ExpiringAccessTokenCacheStatic
    abstract exponentialRetryPolicy: ?retryCount: float * ?retryInterval: float * ?maxRetryInterval: float -> RequestPolicyFactory
    abstract FetchHttpClient: FetchHttpClientStatic
    abstract flattenResponse: _response: HttpOperationResponse * responseSpec: OperationResponse option -> RestResponse
    abstract generateClientRequestIdPolicy: ?requestIdHeaderName: string -> RequestPolicyFactory
    /// Generated UUID
    abstract generateUuid: unit -> string
    abstract getDefaultProxySettings: ?proxyUrl: string -> ProxySettings option
    abstract getDefaultUserAgentValue: unit -> string
    abstract HttpHeaders: HttpHeadersStatic
    /// <summary>Indicates whether the given string is in ISO 8601 format.</summary>
    /// <param name="value">- The value to be validated for ISO 8601 duration format.</param>
    abstract isDuration: value: string -> bool
    /// <summary>Validates the given uuid as a string</summary>
    /// <param name="uuid">- The uuid as a string that needs to be validated</param>
    abstract isValidUuid: uuid: string -> bool
    abstract keepAlivePolicy: ?keepAliveOptions: KeepAliveOptions -> RequestPolicyFactory
    abstract logPolicy: ?loggingOptions: LogPolicyOptions -> RequestPolicyFactory
    /// <summary>Converts an OperationOptions to a RequestOptionsBase</summary>
    /// <param name="opts">- OperationOptions object to convert to RequestOptionsBase</param>
    abstract operationOptionsToRequestOptionsBase: opts: 'T -> RequestOptionsBase
    /// <summary>Converts given XML string into JSON</summary>
    /// <param name="str">- String containing the XML content to be parsed into JSON</param>
    /// <param name="opts">- Options that govern the parsing of given xml string</param>
    abstract parseXML: str: string * ?opts: SerializerOptions -> Promise<obj option>
    /// <summary>Converts a Promise to a callback.</summary>
    /// <param name="promise">- The Promise to be converted to a callback</param>
    abstract promiseToCallback: promise: Promise<obj option> -> (Function -> unit)
    /// <summary>Converts a Promise to a service callback.</summary>
    /// <param name="promise">- The Promise of HttpOperationResponse to be converted to a service callback</param>
    abstract promiseToServiceCallback: promise: Promise<HttpOperationResponse> -> (ServiceCallback<'T> -> unit)
    /// <summary>A policy that allows one to apply proxy settings to all requests.
    /// If not passed static settings, they will be retrieved from the HTTPS_PROXY
    /// or HTTP_PROXY environment variables.</summary>
    /// <param name="proxySettings">- ProxySettings to use on each request.</param>
    /// <param name="options">- additional settings, for example, custom NO_PROXY patterns</param>
    abstract proxyPolicy: ?proxySettings: ProxySettings * ?options: ProxyPolicyOptions -> RequestPolicyFactory
    abstract redirectPolicy: ?maximumRetries: float -> RequestPolicyFactory
    abstract RequestPolicyOptions: RequestPolicyOptionsStatic
    abstract RestError: RestErrorStatic
    abstract serializeObject: toSerialize: obj -> obj option
    abstract Serializer: SerializerStatic
    abstract ServiceClient: ServiceClientStatic
    abstract signingPolicy: authenticationProvider: ServiceClientCredentials -> RequestPolicyFactory
    /// <summary>Converts given JSON object to XML string</summary>
    /// <param name="obj">- JSON object to be converted into XML string</param>
    /// <param name="opts">- Options that govern the parsing of given JSON object</param>
    abstract stringifyXML: obj: obj * ?opts: SerializerOptions -> string
    /// <summary>Returns a stripped version of the Http Request that does not contain the
    /// Authorization header.</summary>
    /// <param name="request">- The Http Request object</param>
    abstract stripRequest: request: WebResourceLike -> WebResourceLike
    /// <summary>Returns a stripped version of the Http Response which only contains body,
    /// headers and the status.</summary>
    /// <param name="response">- The Http Response</param>
    abstract stripResponse: response: HttpOperationResponse -> obj option
    abstract systemErrorRetryPolicy: ?retryCount: float * ?retryInterval: float * ?minRetryInterval: float * ?maxRetryInterval: float -> RequestPolicyFactory
    abstract throttlingRetryPolicy: unit -> RequestPolicyFactory
    abstract TopicCredentials: TopicCredentialsStatic
    abstract tracingPolicy: ?tracingOptions: TracingPolicyOptions -> RequestPolicyFactory
    abstract URLBuilder: URLBuilderStatic
    abstract URLQuery: URLQueryStatic
    abstract userAgentPolicy: ?userAgentData: TelemetryInfo -> RequestPolicyFactory
    abstract WebResource: WebResourceStatic

type [<AllowNullLiteral>] DelayOptions =
    abstract abortSignal: AbortSignalLike option with get, set
    abstract abortErrorMsg: string option with get, set

type [<AllowNullLiteral>] ProxyPolicyOptions =
    /// a list of patterns to override those loaded from NO_PROXY environment variable.
    abstract customNoProxyList: ResizeArray<string> option with get, set

/// Provides a cache for an AccessToken that was that
/// was returned from a TokenCredential.
type [<AllowNullLiteral>] AccessTokenCache =
    /// <summary>Sets the cached token.</summary>
    /// <param name="accessToken">- The {@link AccessToken} to be cached or null to
    /// clear the cached token.</param>
    abstract setCachedToken: accessToken: AccessToken option -> unit
    /// Returns the cached {@link AccessToken} or undefined if nothing is cached.
    abstract getCachedToken: unit -> AccessToken option

/// Helps the core-http token authentication policies with requesting a new token if we're not currently waiting for a new token.
type [<AllowNullLiteral>] AccessTokenRefresher =
    /// Returns true if the required milliseconds(defaulted to 30000) have been passed signifying
    /// that we are ready for a new refresh.
    abstract isReady: unit -> bool
    /// Requests a new token if we're not currently waiting for a new token.
    /// Returns null if the required time between each call hasn't been reached.
    abstract refresh: options: GetTokenOptions -> Promise<AccessToken option>

/// Helps the core-http token authentication policies with requesting a new token if we're not currently waiting for a new token.
type [<AllowNullLiteral>] AccessTokenRefresherStatic =
    [<Emit "new $0($1...)">] abstract Create: credential: TokenCredential * scopes: U2<string, ResizeArray<string>> * ?requiredMillisecondsBeforeNewRefresh: float -> AccessTokenRefresher

/// Describes the options to be provided while creating an instance of ApiKeyCredentials
type [<AllowNullLiteral>] ApiKeyCredentialOptions =
    /// A key value pair of the header parameters that need to be applied to the request.
    abstract inHeader: ApiKeyCredentialOptionsInHeader option with get, set
    /// A key value pair of the query parameters that need to be applied to the request.
    abstract inQuery: ApiKeyCredentialOptionsInHeader option with get, set

/// Authenticates to a service using an API key.
type [<AllowNullLiteral>] ApiKeyCredentials =
    inherit ServiceClientCredentials
    /// <summary>Signs a request with the values provided in the inHeader and inQuery parameter.</summary>
    /// <param name="webResource">- The WebResourceLike to be signed.</param>
    abstract signRequest: webResource: WebResourceLike -> Promise<WebResourceLike>

/// Authenticates to a service using an API key.
type [<AllowNullLiteral>] ApiKeyCredentialsStatic =
    /// <param name="options">- Specifies the options to be provided for auth. Either header or query needs to be provided.</param>
    [<Emit "new $0($1...)">] abstract Create: options: ApiKeyCredentialOptions -> ApiKeyCredentials

type [<AllowNullLiteral>] Authenticator =
    [<Emit "$0($1...)">] abstract Invoke: challenge: obj -> Promise<string>

type [<AllowNullLiteral>] BaseMapper =
    /// Name for the xml element
    abstract xmlName: string option with get, set
    /// Xml element namespace
    abstract xmlNamespace: string option with get, set
    /// Xml element module prefix
    abstract xmlNamespacePrefix: string option with get, set
    /// Determines if the current property should be serialized as an attribute of the parent xml element
    abstract xmlIsAttribute: bool option with get, set
    /// Name for the xml elements when serializing an array
    abstract xmlElementName: string option with get, set
    /// Whether or not the current property should have a wrapping XML element
    abstract xmlIsWrapped: bool option with get, set
    /// Whether or not the current property is readonly
    abstract readOnly: bool option with get, set
    /// Whether or not the current property is a constant
    abstract isConstant: bool option with get, set
    /// Whether or not the current property is required
    abstract required: bool option with get, set
    /// Whether or not the current property allows mull as a value
    abstract nullable: bool option with get, set
    /// The name to use when serializing
    abstract serializedName: string option with get, set
    /// Type of the mapper
    abstract ``type``: MapperType with get, set
    /// Default value when one is not explicitly provided
    abstract defaultValue: obj option with get, set
    /// Constraints to test the current value against
    abstract constraints: MapperConstraints option with get, set

type [<AllowNullLiteral>] BaseRequestPolicy =
    inherit RequestPolicy
    abstract _nextPolicy: RequestPolicy
    abstract _options: RequestPolicyOptionsLike
    abstract sendRequest: webResource: WebResourceLike -> Promise<HttpOperationResponse>
    /// <summary>Get whether or not a log with the provided log level should be logged.</summary>
    /// <param name="logLevel">- The log level of the log that will be logged.</param>
    abstract shouldLog: logLevel: HttpPipelineLogLevel -> bool
    /// <summary>Attempt to log the provided message to the provided logger. If no logger was provided or if
    /// the log level does not meat the logger's threshold, then nothing will be logged.</summary>
    /// <param name="logLevel">- The log level of this log.</param>
    /// <param name="message">- The message of this log.</param>
    abstract log: logLevel: HttpPipelineLogLevel * message: string -> unit

type [<AllowNullLiteral>] BaseRequestPolicyStatic =
    [<Emit "new $0($1...)">] abstract Create: _nextPolicy: RequestPolicy * _options: RequestPolicyOptionsLike -> BaseRequestPolicy

type [<AllowNullLiteral>] BasicAuthenticationCredentials =
    inherit ServiceClientCredentials
    abstract userName: string with get, set
    abstract password: string with get, set
    abstract authorizationScheme: string with get, set
    /// <summary>Signs a request with the Authentication header.</summary>
    /// <param name="webResource">- The WebResourceLike to be signed.</param>
    abstract signRequest: webResource: WebResourceLike -> Promise<WebResourceLike>

type [<AllowNullLiteral>] BasicAuthenticationCredentialsStatic =
    /// <summary>Creates a new BasicAuthenticationCredentials object.</summary>
    /// <param name="userName">- User name.</param>
    /// <param name="password">- Password.</param>
    /// <param name="authorizationScheme">- The authorization scheme.</param>
    [<Emit "new $0($1...)">] abstract Create: userName: string * password: string * ?authorizationScheme: string -> BasicAuthenticationCredentials

type CommonRequestInfo =
    string

type [<AllowNullLiteral>] CommonRequestInit =
    interface end

type [<AllowNullLiteral>] CommonResponse =
    interface end

type [<AllowNullLiteral>] CompositeMapper =
    inherit BaseMapper
    /// Type of the mapper
    abstract ``type``: CompositeMapperType with get, set

type [<AllowNullLiteral>] CompositeMapperType =
    abstract name: string with get, set
    abstract className: string option with get, set
    abstract modelProperties: CompositeMapperTypeModelProperties option with get, set
    abstract additionalProperties: Mapper option with get, set
    abstract uberParent: string option with get, set
    abstract polymorphicDiscriminator: PolymorphicDiscriminator option with get, set

type [<AllowNullLiteral>] DefaultHttpClient =
    inherit FetchHttpClient
    abstract fetch: input: CommonRequestInfo * ?init: CommonRequestInit -> Promise<CommonResponse>
    abstract prepareRequest: httpRequest: WebResourceLike -> Promise<obj>
    abstract processRequest: operationResponse: HttpOperationResponse -> Promise<unit>

type [<AllowNullLiteral>] DefaultHttpClientStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultHttpClient

/// The content-types that will indicate that an operation response should be deserialized in a
/// particular way.
type [<AllowNullLiteral>] DeserializationContentTypes =
    /// The content-types that indicate that an operation response should be deserialized as JSON.
    /// Defaults to [ "application/json", "text/json" ].
    abstract json: ResizeArray<string> option with get, set
    /// The content-types that indicate that an operation response should be deserialized as XML.
    /// Defaults to [ "application/xml", "application/atom+xml" ].
    abstract xml: ResizeArray<string> option with get, set

/// Options to configure API response deserialization.
type [<AllowNullLiteral>] DeserializationOptions =
    /// Configures the expected content types for the deserialization of
    /// JSON and XML response bodies.
    abstract expectedContentTypes: DeserializationContentTypes with get, set

type [<AllowNullLiteral>] DictionaryMapper =
    inherit BaseMapper
    /// Type of the mapper
    abstract ``type``: DictionaryMapperType with get, set
    abstract headerCollectionPrefix: string option with get, set

type [<AllowNullLiteral>] DictionaryMapperType =
    abstract name: string with get, set
    abstract value: Mapper with get, set

type [<AllowNullLiteral>] EnumMapper =
    inherit BaseMapper
    /// Type of the mapper
    abstract ``type``: EnumMapperType with get, set

type [<AllowNullLiteral>] EnumMapperType =
    abstract name: string with get, set
    abstract allowedValues: ResizeArray<obj option> with get, set

/// Provides an {@link AccessTokenCache} implementation which clears
/// the cached {@link AccessToken}'s after the expiresOnTimestamp has
/// passed.
type [<AllowNullLiteral>] ExpiringAccessTokenCache =
    inherit AccessTokenCache
    /// Sets the cached token.
    abstract setCachedToken: accessToken: AccessToken option -> unit
    /// Returns the cached {@link AccessToken} or undefined if nothing is cached.
    abstract getCachedToken: unit -> AccessToken option

/// Provides an {@link AccessTokenCache} implementation which clears
/// the cached {@link AccessToken}'s after the expiresOnTimestamp has
/// passed.
type [<AllowNullLiteral>] ExpiringAccessTokenCacheStatic =
    /// Constructs an instance of {@link ExpiringAccessTokenCache} with
    /// an optional expiration buffer time.
    [<Emit "new $0($1...)">] abstract Create: ?tokenRefreshBufferMs: float -> ExpiringAccessTokenCache

type [<AllowNullLiteral>] FetchHttpClient =
    inherit HttpClient
    abstract sendRequest: httpRequest: WebResourceLike -> Promise<HttpOperationResponse>
    abstract prepareRequest: httpRequest: WebResourceLike -> Promise<obj>
    abstract processRequest: operationResponse: HttpOperationResponse -> Promise<unit>
    abstract fetch: input: CommonRequestInfo * ?init: CommonRequestInit -> Promise<CommonResponse>

type [<AllowNullLiteral>] FetchHttpClientStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> FetchHttpClient

/// An interface that can send HttpRequests and receive promised HttpResponses.
type [<AllowNullLiteral>] HttpClient =
    inherit RequestPolicy

/// An individual header within a HttpHeaders collection.
type [<AllowNullLiteral>] HttpHeader =
    /// The name of the header.
    abstract name: string with get, set
    /// The value of the header.
    abstract value: string with get, set

/// A collection of HTTP header key/value pairs.
type [<AllowNullLiteral>] HttpHeaders =
    inherit HttpHeadersLike
    /// <summary>Set a header in this collection with the provided name and value. The name is
    /// case-insensitive.</summary>
    /// <param name="headerName">- The name of the header to set. This value is case-insensitive.</param>
    /// <param name="headerValue">- The value of the header to set.</param>
    abstract set: headerName: string * headerValue: U2<string, float> -> unit
    /// <summary>Get the header value for the provided header name, or undefined if no header exists in this
    /// collection with the provided name.</summary>
    /// <param name="headerName">- The name of the header.</param>
    abstract get: headerName: string -> string option
    /// Get whether or not this header collection contains a header entry for the provided header name.
    abstract contains: headerName: string -> bool
    /// <summary>Remove the header with the provided headerName. Return whether or not the header existed and
    /// was removed.</summary>
    /// <param name="headerName">- The name of the header to remove.</param>
    abstract remove: headerName: string -> bool
    /// Get the headers that are contained this collection as an object.
    abstract rawHeaders: unit -> RawHttpHeaders
    /// Get the headers that are contained in this collection as an array.
    abstract headersArray: unit -> ResizeArray<HttpHeader>
    /// Get the header names that are contained in this collection.
    abstract headerNames: unit -> ResizeArray<string>
    /// Get the header values that are contained in this collection.
    abstract headerValues: unit -> ResizeArray<string>
    /// Get the JSON object representation of this HTTP header collection.
    abstract toJson: unit -> RawHttpHeaders
    /// Get the string representation of this HTTP header collection.
    abstract toString: unit -> string
    /// Create a deep clone/copy of this HttpHeaders collection.
    abstract clone: unit -> HttpHeaders

/// A collection of HTTP header key/value pairs.
type [<AllowNullLiteral>] HttpHeadersStatic =
    [<Emit "new $0($1...)">] abstract Create: ?rawHeaders: RawHttpHeaders -> HttpHeaders

/// A collection of HTTP header key/value pairs.
type [<AllowNullLiteral>] HttpHeadersLike =
    /// <summary>Set a header in this collection with the provided name and value. The name is
    /// case-insensitive.</summary>
    /// <param name="headerName">- The name of the header to set. This value is case-insensitive.</param>
    /// <param name="headerValue">- The value of the header to set.</param>
    abstract set: headerName: string * headerValue: U2<string, float> -> unit
    /// <summary>Get the header value for the provided header name, or undefined if no header exists in this
    /// collection with the provided name.</summary>
    /// <param name="headerName">- The name of the header.</param>
    abstract get: headerName: string -> string option
    /// Get whether or not this header collection contains a header entry for the provided header name.
    abstract contains: headerName: string -> bool
    /// <summary>Remove the header with the provided headerName. Return whether or not the header existed and
    /// was removed.</summary>
    /// <param name="headerName">- The name of the header to remove.</param>
    abstract remove: headerName: string -> bool
    /// Get the headers that are contained this collection as an object.
    abstract rawHeaders: unit -> RawHttpHeaders
    /// Get the headers that are contained in this collection as an array.
    abstract headersArray: unit -> ResizeArray<HttpHeader>
    /// Get the header names that are contained in this collection.
    abstract headerNames: unit -> ResizeArray<string>
    /// Get the header values that are contained in this collection.
    abstract headerValues: unit -> ResizeArray<string>
    /// Create a deep clone/copy of this HttpHeaders collection.
    abstract clone: unit -> HttpHeadersLike
    /// Get the JSON object representation of this HTTP header collection.
    /// The result is the same as `rawHeaders()`.
    abstract toJson: unit -> RawHttpHeaders

type [<StringEnum>] [<RequireQualifiedAccess>] HttpMethods =
    | [<CompiledName "GET">] GET
    | [<CompiledName "PUT">] PUT
    | [<CompiledName "POST">] POST
    | [<CompiledName "DELETE">] DELETE
    | [<CompiledName "PATCH">] PATCH
    | [<CompiledName "HEAD">] HEAD
    | [<CompiledName "OPTIONS">] OPTIONS
    | [<CompiledName "TRACE">] TRACE

/// Wrapper object for http request and response. Deserialized object is stored in
/// the `parsedBody` property when the response body is received in JSON or XML.
type [<AllowNullLiteral>] HttpOperationResponse =
    inherit HttpResponse
    /// The parsed HTTP response headers.
    abstract parsedHeaders: HttpOperationResponseParsedHeaders option with get, set
    /// The response body as text (string format)
    abstract bodyAsText: string option with get, set
    /// The response body as parsed JSON or XML
    abstract parsedBody: obj option with get, set
    /// BROWSER ONLY
    ///
    /// The response body as a browser Blob.
    /// Always undefined in node.js.
    // TODO: WAS THIS LINE // abstract blobBody: Promise<Blob> option with get, set
    abstract blobBody: Promise<obj> option with get, set
    // NODEJS ONLY
    //
    // The response body as a node.js Readable stream.
    // Always undefined in the browser.
    // TODO: NEED TO GET NODEJS
    // abstract readableStreamBody: NodeJS.ReadableStream option with get, set

/// A Logger that can be added to a HttpPipeline. This enables each RequestPolicy to log messages
/// that can be used for debugging purposes.
type [<AllowNullLiteral>] HttpPipelineLogger =
    /// The log level threshold for what logs will be logged.
    abstract minimumLogLevel: HttpPipelineLogLevel with get, set
    /// <summary>Log the provided message.</summary>
    /// <param name="logLevel">- The HttpLogDetailLevel associated with this message.</param>
    /// <param name="message">- The message to log.</param>
    abstract log: logLevel: HttpPipelineLogLevel * message: string -> unit

type [<RequireQualifiedAccess>] HttpPipelineLogLevel =
    | OFF = 0
    | ERROR = 1
    | WARNING = 2
    | INFO = 3


type HttpRequestBody =
    // TODO: WAS THIS LINE BLOB AND NODEJS // U5<Blob, string, ArrayBuffer, ArrayBufferView, (unit -> NodeJS.ReadableStream)>
    U5<obj, string, ArrayBuffer, ArrayBufferView, unit -> obj>

/// The properties on an HTTP response which will always be present.
type [<AllowNullLiteral>] HttpResponse =
    /// The raw request
    abstract request: WebResourceLike with get, set
    /// The HTTP response status (e.g. 200)
    abstract status: float with get, set
    /// The HTTP response headers.
    abstract headers: HttpHeadersLike with get, set

/// Defines options that are used to configure internal options of
/// the HTTP pipeline for an SDK client.
type [<AllowNullLiteral>] InternalPipelineOptions =
    inherit PipelineOptions
    /// Options to configure API response deserialization.
    abstract deserializationOptions: DeserializationOptions option with get, set
    /// Options to configure request/response logging.
    abstract loggingOptions: LogPolicyOptions option with get, set
    /// Configure whether to decompress response according to Accept-Encoding header (node-fetch only)
    abstract decompressResponse: bool option with get, set
    /// Send JSON Array payloads as NDJSON.
    abstract sendStreamingJson: bool option with get, set

/// Options for how HTTP connections should be maintained for future
/// requests.
type [<AllowNullLiteral>] KeepAliveOptions =
    abstract enable: bool with get, set

type [<AllowNullLiteral>] LogPolicyOptions =
    /// Header names whose values will be logged when logging is enabled. Defaults to
    /// Date, traceparent, x-ms-client-request-id, and x-ms-request id.  Any headers
    /// specified in this field will be added to that list.  Any other values will
    /// be written to logs as "REDACTED".
    abstract allowedHeaderNames: ResizeArray<string> option with get, set
    /// Query string names whose values will be logged when logging is enabled. By default no
    /// query string values are logged.
    abstract allowedQueryParameters: ResizeArray<string> option with get, set
    /// The Debugger (logger) instance to use for writing pipeline logs.
    abstract logger: Debugger option with get, set

type Mapper =
    U5<BaseMapper, CompositeMapper, SequenceMapper, DictionaryMapper, EnumMapper>

type [<AllowNullLiteral>] MapperConstraints =
    abstract InclusiveMaximum: float option with get, set
    abstract ExclusiveMaximum: float option with get, set
    abstract InclusiveMinimum: float option with get, set
    abstract ExclusiveMinimum: float option with get, set
    abstract MaxLength: float option with get, set
    abstract MinLength: float option with get, set
    abstract Pattern: RegExp option with get, set
    abstract MaxItems: float option with get, set
    abstract MinItems: float option with get, set
    abstract UniqueItems: obj option with get, set
    abstract MultipleOf: float option with get, set

// TODO: DUPLICATE DEFINITION, NEED REVIEW TS TYPE DEFINITION
// type MapperType =
//     U5<SimpleMapperType, CompositeMapperType, SequenceMapperType, DictionaryMapperType, EnumMapperType>

/// A collection of properties that apply to a single invocation of an operation.
type [<AllowNullLiteral>] OperationArguments =
    /// The parameters that were passed to the operation method.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: parameterName: string -> obj option with get, set
    /// The optional arugments that are provided to an operation.
    abstract options: RequestOptionsBase option with get, set

/// The base options type for all operations.
type [<AllowNullLiteral>] OperationOptions =
    /// The signal which can be used to abort requests.
    abstract abortSignal: AbortSignalLike option with get, set
    /// Options used when creating and sending HTTP requests for this operation.
    abstract requestOptions: OperationRequestOptions option with get, set
    /// Options used when tracing is enabled.
    abstract tracingOptions: OperationTracingOptions option with get, set

/// A common interface that all Operation parameter's extend.
type [<AllowNullLiteral>] OperationParameter =
    /// The path to this parameter's value in OperationArguments or the object that contains paths for
    /// each property's value in OperationArguments.
    abstract parameterPath: ParameterPath with get, set
    /// The mapper that defines how to validate and serialize this parameter's value.
    abstract mapper: Mapper with get, set

/// A parameter for an operation that will be added as a query parameter to the operation's HTTP
/// request.
type [<AllowNullLiteral>] OperationQueryParameter =
    inherit OperationParameter
    /// Whether or not to skip encoding the query parameter's value before adding it to the URL.
    abstract skipEncoding: bool option with get, set
    /// If this query parameter's value is a collection, what type of format should the value be
    /// converted to.
    abstract collectionFormat: QueryCollectionFormat option with get, set

type [<AllowNullLiteral>] OperationRequestOptions =
    /// User defined custom request headers that will be applied before the request is sent.
    abstract customHeaders: OperationRequestOptionsCustomHeaders option with get, set
    /// The number of milliseconds a request can take before automatically being terminated.
    abstract timeout: float option with get, set
    /// Callback which fires upon upload progress.
    abstract onUploadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Callback which fires upon download progress.
    abstract onDownloadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Whether or not the HttpOperationResponse should be deserialized. If this is undefined, then the
    /// HttpOperationResponse should be deserialized.
    abstract shouldDeserialize: U2<bool, HttpOperationResponse -> bool> option with get, set

/// An OperationResponse that can be returned from an operation request for a single status code.
type [<AllowNullLiteral>] OperationResponse =
    /// The mapper that will be used to deserialize the response headers.
    abstract headersMapper: Mapper option with get, set
    /// The mapper that will be used to deserialize the response body.
    abstract bodyMapper: Mapper option with get, set
    /// Indicates if this is an error response
    abstract isError: bool option with get, set

/// A specification that defines an operation.
type [<AllowNullLiteral>] OperationSpec =
    /// The serializer to use in this operation.
    abstract serializer: Serializer
    /// The HTTP method that should be used by requests for this operation.
    abstract httpMethod: HttpMethods
    /// The URL that was provided in the service's specification. This will still have all of the URL
    /// template variables in it. If this is not provided when the OperationSpec is created, then it
    /// will be populated by a "baseUri" property on the ServiceClient.
    abstract baseUrl: string option
    /// The fixed path for this operation's URL. This will still have all of the URL template variables
    /// in it.
    abstract path: string option
    /// The content type of the request body. This value will be used as the "Content-Type" header if
    /// it is provided.
    abstract contentType: string option
    /// The media type of the request body.
    /// This value can be used to aide in serialization if it is provided.
    abstract mediaType: U2<string, string> option
    /// The parameter that will be used to construct the HTTP request's body.
    abstract requestBody: OperationParameter option
    /// Whether or not this operation uses XML request and response bodies.
    abstract isXML: bool option
    /// The parameters to the operation method that will be substituted into the constructed URL.
    abstract urlParameters: ReadonlyArray<OperationURLParameter> option
    /// The parameters to the operation method that will be added to the constructed URL's query.
    abstract queryParameters: ReadonlyArray<OperationQueryParameter> option
    /// The parameters to the operation method that will be converted to headers on the operation's
    /// HTTP request.
    abstract headerParameters: ReadonlyArray<OperationParameter> option
    /// The parameters to the operation method that will be used to create a formdata body for the
    /// operation's HTTP request.
    abstract formDataParameters: ReadonlyArray<OperationParameter> option
    /// The different types of responses that this operation can return based on what status code is
    /// returned.
    abstract responses: OperationSpecResponses

/// A parameter for an operation that will be substituted into the operation's request URL.
type [<AllowNullLiteral>] OperationURLParameter =
    inherit OperationParameter
    /// Whether or not to skip encoding the URL parameter's value before adding it to the URL.
    abstract skipEncoding: bool option with get, set

type ParameterPath =
    // TODO: WAS THIS LINE// U3<string, ResizeArray<string>, ParameterPath>
    U3<string, ResizeArray<string>, obj>

/// The Parameter value provided for path or query parameters in RequestPrepareOptions
type [<AllowNullLiteral>] ParameterValue =
    abstract value: obj option with get, set
    abstract skipUrlEncoding: bool with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

/// Defines options that are used to configure the HTTP pipeline for
/// an SDK client.
type [<AllowNullLiteral>] PipelineOptions =
    /// The HttpClient implementation to use for outgoing HTTP requests.  Defaults
    /// to DefaultHttpClient.
    abstract httpClient: HttpClient option with get, set
    /// Options that control how to retry failed requests.
    abstract retryOptions: RetryOptions option with get, set
    /// Options to configure a proxy for outgoing requests.
    abstract proxyOptions: ProxyOptions option with get, set
    abstract keepAliveOptions: KeepAliveOptions option with get, set
    /// Options for how redirect responses are handled.
    abstract redirectOptions: RedirectOptions option with get, set
    /// Options for adding user agent details to outgoing requests.
    abstract userAgentOptions: UserAgentOptions option with get, set

type [<AllowNullLiteral>] PolymorphicDiscriminator =
    abstract serializedName: string with get, set
    abstract clientName: string with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set

type ProxyOptions =
    ProxySettings

/// Options to configure a proxy for outgoing requests (Node.js only).
type [<AllowNullLiteral>] ProxySettings =
    /// The proxy's host address.
    abstract host: string with get, set
    /// The proxy host's port.
    abstract port: float with get, set
    /// The user name to authenticate with the proxy, if required.
    abstract username: string option with get, set
    /// The password to authenticate with the proxy, if required.
    abstract password: string option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] QueryCollectionFormat =
    | [<CompiledName ",">] Csv
    | [<CompiledName " ">] Ssv
    | [<CompiledName "	">] Tsv
    | [<CompiledName "|">] Pipes
    | [<CompiledName "Multi">] Multi

type [<AllowNullLiteral>] RawHttpHeaders =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: headerName: string -> string with get, set

/// Options for how redirect responses are handled.
type [<AllowNullLiteral>] RedirectOptions =
    abstract handleRedirects: bool with get, set
    abstract maxRetries: float option with get, set

/// Describes the base structure of the options object that will be used in every operation.
type [<AllowNullLiteral>] RequestOptionsBase =
    /// will be applied before the request is sent.
    abstract customHeaders: OperationRequestOptionsCustomHeaders option with get, set
    /// The signal which can be used to abort requests.
    abstract abortSignal: AbortSignalLike option with get, set
    /// The number of milliseconds a request can take before automatically being terminated.
    /// If the request is terminated, an `AbortError` is thrown.
    abstract timeout: float option with get, set
    /// Callback which fires upon upload progress.
    abstract onUploadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Callback which fires upon download progress.
    abstract onDownloadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Whether or not the HttpOperationResponse should be deserialized. If this is undefined, then the
    /// HttpOperationResponse should be deserialized.
    abstract shouldDeserialize: U2<bool, HttpOperationResponse -> bool> option with get, set
    /// Tracing: Options used to create a span when tracing is enabled.
    abstract spanOptions: SpanOptions option with get, set
    /// Tracing: Context used when creating spans.
    abstract tracingContext: Context option with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set
    /// Options to override XML parsing/building behavior.
    abstract serializerOptions: SerializerOptions option with get, set

type [<AllowNullLiteral>] RequestPolicy =
    abstract sendRequest: httpRequest: WebResourceLike -> Promise<HttpOperationResponse>

type [<AllowNullLiteral>] RequestPolicyFactory =
    abstract create: nextPolicy: RequestPolicy * options: RequestPolicyOptionsLike -> RequestPolicy

/// Optional properties that can be used when creating a RequestPolicy.
type [<AllowNullLiteral>] RequestPolicyOptions =
    /// <summary>Get whether or not a log with the provided log level should be logged.</summary>
    /// <param name="logLevel">- The log level of the log that will be logged.</param>
    abstract shouldLog: logLevel: HttpPipelineLogLevel -> bool
    /// <summary>Attempt to log the provided message to the provided logger. If no logger was provided or if
    /// the log level does not meet the logger's threshold, then nothing will be logged.</summary>
    /// <param name="logLevel">- The log level of this log.</param>
    /// <param name="message">- The message of this log.</param>
    abstract log: logLevel: HttpPipelineLogLevel * message: string -> unit

/// Optional properties that can be used when creating a RequestPolicy.
type [<AllowNullLiteral>] RequestPolicyOptionsStatic =
    [<Emit "new $0($1...)">] abstract Create: ?_logger: HttpPipelineLogger -> RequestPolicyOptions

/// Optional properties that can be used when creating a RequestPolicy.
type [<AllowNullLiteral>] RequestPolicyOptionsLike =
    /// <summary>Get whether or not a log with the provided log level should be logged.</summary>
    /// <param name="logLevel">- The log level of the log that will be logged.</param>
    abstract shouldLog: logLevel: HttpPipelineLogLevel -> bool
    /// <summary>Attempt to log the provided message to the provided logger. If no logger was provided or if
    /// the log level does not meet the logger's threshold, then nothing will be logged.</summary>
    /// <param name="logLevel">- The log level of this log.</param>
    /// <param name="message">- The message of this log.</param>
    abstract log: logLevel: HttpPipelineLogLevel * message: string -> unit

type [<AllowNullLiteral>] RequestPrepareOptions =
    /// The HTTP request method. Valid values are "GET", "PUT", "HEAD", "DELETE", "OPTIONS", "POST",
    /// or "PATCH".
    abstract ``method``: HttpMethods with get, set
    /// The request url. It may or may not have query parameters in it. Either provide the "url" or
    /// provide the "pathTemplate" in the options object. Both the options are mutually exclusive.
    abstract url: string option with get, set
    /// A dictionary of query parameters to be appended to the url, where
    /// the "key" is the "query-parameter-name" and the "value" is the "query-parameter-value".
    /// The "query-parameter-value" can be of type "string" or it can be of type "object".
    /// The "object" format should be used when you want to skip url encoding. While using the object format,
    /// the object must have a property named value which provides the "query-parameter-value".
    /// Example:
    ///     - query-parameter-value in "object" format: `{ "query-parameter-name": { value: "query-parameter-value", skipUrlEncoding: true } }`
    ///     - query-parameter-value in "string" format: `{ "query-parameter-name": "query-parameter-value"}`.
    /// Note: "If options.url already has some query parameters, then the value provided in options.queryParameters will be appended to the url.
    abstract queryParameters: RequestPrepareOptionsQueryParameters option with get, set
    /// The path template of the request url. Either provide the "url" or provide the "pathTemplate" in
    /// the options object. Both the options are mutually exclusive.
    /// Example: `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}`
    abstract pathTemplate: string option with get, set
    /// The base url of the request. Default value is: "https://management.azure.com". This is
    /// applicable only with pathTemplate. If you are providing options.url then it is expected that
    /// you provide the complete url.
    abstract baseUrl: string option with get, set
    /// A dictionary of path parameters that need to be replaced with actual values in the pathTemplate.
    /// Here the key is the "path-parameter-name" and the value is the "path-parameter-value".
    /// The "path-parameter-value" can be of type "string"  or it can be of type "object".
    /// The "object" format should be used when you want to skip url encoding. While using the object format,
    /// the object must have a property named value which provides the "path-parameter-value".
    /// Example:
    ///     - path-parameter-value in "object" format: `{ "path-parameter-name": { value: "path-parameter-value", skipUrlEncoding: true } }`
    ///     - path-parameter-value in "string" format: `{ "path-parameter-name": "path-parameter-value" }`.
    abstract pathParameters: RequestPrepareOptionsQueryParameters option with get, set
    abstract formData: HttpOperationResponseParsedHeaders option with get, set
    /// A dictionary of request headers that need to be applied to the request.
    /// Here the key is the "header-name" and the value is the "header-value". The header-value MUST be of type string.
    ///   - ContentType must be provided with the key name as "Content-Type". Default value "application/json; charset=utf-8".
    ///   - "Transfer-Encoding" is set to "chunked" by default if "options.bodyIsStream" is set to true.
    ///   - "Content-Type" is set to "application/octet-stream" by default if "options.bodyIsStream" is set to true.
    ///   - "accept-language" by default is set to "en-US"
    ///   - "x-ms-client-request-id" by default is set to a new Guid. To not generate a guid for the request, please set options.disableClientRequestId to true
    abstract headers: HttpOperationResponseParsedHeaders option with get, set
    /// When set to true, instructs the client to not set "x-ms-client-request-id" header to a new Guid().
    abstract disableClientRequestId: bool option with get, set
    /// The request body. It can be of any type. This value will be serialized if it is not a stream.
    abstract body: obj option with get, set
    /// Provides information on how to serialize the request body.
    abstract serializationMapper: Mapper option with get, set
    /// A dictionary of mappers that may be used while [de]serialization.
    abstract mappers: ApiKeyCredentialOptionsInHeader option with get, set
    // Provides information on how to deserialize the response body.
    // TODO: RECORD UNDEFINED
    // abstract deserializationMapper: Record<string, obj> option with get, set
    /// Indicates whether this method should JSON.stringify() the request body. Default value: false.
    abstract disableJsonStringifyOnBody: bool option with get, set
    /// Indicates whether the request body is a stream (useful for file upload scenarios).
    abstract bodyIsStream: bool option with get, set
    abstract abortSignal: AbortSignalLike option with get, set
    abstract onUploadProgress: (TransferProgressEvent -> unit) option with get, set
    abstract onDownloadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Tracing: Options used to create a span when tracing is enabled.
    abstract spanOptions: SpanOptions option with get, set
    /// Tracing: Context used when creating spans.
    abstract tracingContext: Context option with get, set

type [<AllowNullLiteral>] RestError =
    // TODO: NEED TO IMLPEMENT ABORT ERROR
    // inherit Error
    abstract code: string option with get, set
    abstract statusCode: float option with get, set
    abstract request: WebResourceLike option with get, set
    abstract response: HttpOperationResponse option with get, set
    abstract details: obj option with get, set

type [<AllowNullLiteral>] RestErrorStatic =
    abstract REQUEST_SEND_ERROR: string
    abstract PARSE_ERROR: string
    [<Emit "new $0($1...)">] abstract Create: message: string * ?code: string * ?statusCode: float * ?request: WebResourceLike * ?response: HttpOperationResponse -> RestError

/// The flattened response to a REST call.
/// Contains the underlying HttpOperationResponse as well as
/// the merged properties of the parsedBody, parsedHeaders, etc.
type [<AllowNullLiteral>] RestResponse =
    /// The underlying HTTP response containing both raw and deserialized response data.
    abstract _response: HttpOperationResponse with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<RequireQualifiedAccess>] RetryMode =
    | Exponential = 0

/// Options that control how to retry failed requests.
type [<AllowNullLiteral>] RetryOptions =
    /// The maximum number of retry attempts.  Defaults to 3.
    abstract maxRetries: float option with get, set
    /// The amount of delay in milliseconds between retry attempts. Defaults to 30000
    /// (30 seconds). The delay increases exponentially with each retry up to a maximum
    /// specified by maxRetryDelayInMs.
    abstract retryDelayInMs: float option with get, set
    /// The maximum delay in milliseconds allowed before retrying an operation. Defaults
    /// to 90000 (90 seconds).
    abstract maxRetryDelayInMs: float option with get, set
    /// Currently supporting only Exponential mode.
    abstract mode: RetryMode option with get, set

type [<AllowNullLiteral>] SequenceMapper =
    inherit BaseMapper
    /// Type of the mapper
    abstract ``type``: SequenceMapperType with get, set

type [<AllowNullLiteral>] SequenceMapperType =
    abstract name: string with get, set
    abstract element: Mapper with get, set

type [<AllowNullLiteral>] Serializer =
    abstract modelMappers: HttpOperationResponseParsedHeaders
    abstract isXML: bool option
    abstract validateConstraints: mapper: Mapper * value: obj * objectName: string -> unit
    /// <summary>Serialize the given object based on its metadata defined in the mapper</summary>
    /// <param name="mapper">- The mapper which defines the metadata of the serializable object</param>
    /// <param name="object">- A valid Javascript object to be serialized</param>
    /// <param name="objectName">- Name of the serialized object</param>
    /// <param name="options">- additional options to deserialization</param>
    abstract serialize: mapper: Mapper * ``object``: obj * ?objectName: string * ?options: SerializerOptions -> obj option
    /// <summary>Deserialize the given object based on its metadata defined in the mapper</summary>
    /// <param name="mapper">- The mapper which defines the metadata of the serializable object</param>
    /// <param name="responseBody">- A valid Javascript entity to be deserialized</param>
    /// <param name="objectName">- Name of the deserialized object</param>
    /// <param name="options">- Controls behavior of XML parser and builder.</param>
    abstract deserialize: mapper: Mapper * responseBody: obj * objectName: string * ?options: SerializerOptions -> obj option

type [<AllowNullLiteral>] SerializerStatic =
    [<Emit "new $0($1...)">] abstract Create: ?modelMappers: SerializerStaticModelMappers * ?isXML: bool -> Serializer

type [<AllowNullLiteral>] SerializerStaticModelMappers =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

/// Options to govern behavior of xml parser and builder.
type [<AllowNullLiteral>] SerializerOptions =
    /// indicates the name of the root element in the resulting XML when building XML.
    abstract rootName: string option with get, set
    /// indicates whether the root element is to be included or not in the output when parsing XML.
    abstract includeRoot: bool option with get, set
    /// key used to access the XML value content when parsing XML.
    abstract xmlCharKey: string option with get, set

/// Service callback that is returned for REST requests initiated by the service client.
type [<AllowNullLiteral>] ServiceCallback<'TResult> =
    /// <summary>A method that will be invoked as a callback to a service function.</summary>
    /// <param name="err">- The error occurred if any, while executing the request; otherwise null.</param>
    /// <param name="result">- The deserialized response body if an error did not occur.</param>
    /// <param name="request">- The raw/actual request sent to the server if an error did not occur.</param>
    /// <param name="response">- The raw/actual response from the server if an error did not occur.</param>
    [<Emit "$0($1...)">] abstract Invoke: err: U2<Error, RestError> option * ?result: 'TResult * ?request: WebResourceLike * ?response: HttpOperationResponse -> unit

/// ServiceClient sends service requests and receives responses.
type [<AllowNullLiteral>] ServiceClient =
    /// If specified, this is the base URI that requests will be made against for this ServiceClient.
    /// If it is not specified, then all OperationSpecs must contain a baseUrl property.
    abstract baseUri: string option with get, set
    /// The default request content type for the service.
    /// Used if no requestContentType is present on an OperationSpec.
    abstract requestContentType: string option with get, set
    /// Send the provided httpRequest.
    abstract sendRequest: options: U2<RequestPrepareOptions, WebResourceLike> -> Promise<HttpOperationResponse>
    /// <summary>Send an HTTP request that is populated using the provided OperationSpec.</summary>
    /// <param name="operationArguments">- The arguments that the HTTP request's templated values will be populated from.</param>
    /// <param name="operationSpec">- The OperationSpec to use to populate the httpRequest.</param>
    /// <param name="callback">- The callback to call when the response is received.</param>
    abstract sendOperationRequest: operationArguments: OperationArguments * operationSpec: OperationSpec * ?callback: ServiceCallback<obj option> -> Promise<RestResponse>

/// ServiceClient sends service requests and receives responses.
type [<AllowNullLiteral>] ServiceClientStatic =
    /// <summary>The ServiceClient constructor</summary>
    /// <param name="credentials">- The credentials used for authentication with the service.</param>
    /// <param name="options">- The service client options that govern the behavior of the client.</param>
    [<Emit "new $0($1...)">] abstract Create: ?credentials: U2<TokenCredential, ServiceClientCredentials> * ?options: ServiceClientOptions -> ServiceClient

type [<AllowNullLiteral>] ServiceClientCredentials =
    /// <summary>Signs a request with the Authentication header.</summary>
    /// <param name="webResource">- The WebResourceLike/request to be signed.</param>
    abstract signRequest: webResource: WebResourceLike -> Promise<WebResourceLike>

/// Options to be provided while creating the client.
type [<AllowNullLiteral>] ServiceClientOptions =
    /// An array of factories which get called to create the RequestPolicy pipeline used to send a HTTP
    /// request on the wire, or a function that takes in the defaultRequestPolicyFactories and returns
    /// the requestPolicyFactories that will be used.
    abstract requestPolicyFactories: U2<ResizeArray<RequestPolicyFactory>, ResizeArray<RequestPolicyFactory> -> U2<unit, ResizeArray<RequestPolicyFactory>>> option with get, set
    /// The HttpClient that will be used to send HTTP requests.
    abstract httpClient: HttpClient option with get, set
    /// The HttpPipelineLogger that can be used to debug RequestPolicies within the HTTP pipeline.
    abstract httpPipelineLogger: HttpPipelineLogger option with get, set
    /// If set to true, turn off the default retry policy.
    abstract noRetryPolicy: bool option with get, set
    /// Gets or sets the retry timeout in seconds for AutomaticRPRegistration. Default value is 30.
    abstract rpRegistrationRetryTimeout: float option with get, set
    /// Whether or not to generate a client request ID header for each HTTP request.
    abstract generateClientRequestIdHeader: bool option with get, set
    /// Whether to include credentials in CORS requests in the browser.
    /// See https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/withCredentials for more information.
    abstract withCredentials: bool option with get, set
    /// If specified, a GenerateRequestIdPolicy will be added to the HTTP pipeline that will add a
    /// header to all outgoing requests with this header name and a random UUID as the request ID.
    abstract clientRequestIdHeaderName: string option with get, set
    /// The content-types that will be associated with JSON or XML serialization.
    abstract deserializationContentTypes: DeserializationContentTypes option with get, set
    /// The header name to use for the telemetry header while sending the request. If this is not
    /// specified, then "User-Agent" will be used when running on Node.js and "x-ms-useragent" will
    /// be used when running in a browser.
    abstract userAgentHeaderName: U2<string, string -> string> option with get, set
    /// The string to be set to the telemetry header while sending the request, or a function that
    /// takes in the default user-agent string and returns the user-agent string that will be used.
    abstract userAgent: U2<string, string -> string> option with get, set
    /// Proxy settings which will be used for every HTTP request (Node.js only).
    abstract proxySettings: ProxySettings option with get, set
    /// If specified, will be used to build the BearerTokenAuthenticationPolicy.
    abstract credentialScopes: U2<string, ResizeArray<string>> option with get, set

type [<AllowNullLiteral>] SimpleMapperType =
    abstract name: SimpleMapperTypeName with get, set

/// This function is only here for compatibility. Use createSpanFunction in core-tracing.
type [<AllowNullLiteral>] SpanConfig =
    /// Package name prefix
    abstract packagePrefix: string with get, set
    /// Service namespace
    abstract ``namespace``: string with get, set

type [<AllowNullLiteral>] TelemetryInfo =
    abstract key: string option with get, set
    abstract value: string option with get, set

type [<AllowNullLiteral>] TopicCredentials =
    inherit ApiKeyCredentials

type [<AllowNullLiteral>] TopicCredentialsStatic =
    /// <summary>Creates a new EventGrid TopicCredentials object.</summary>
    /// <param name="topicKey">- The EventGrid topic key</param>
    [<Emit "new $0($1...)">] abstract Create: topicKey: string -> TopicCredentials

type [<AllowNullLiteral>] TracingPolicyOptions =
    abstract userAgent: string option with get, set

type [<AllowNullLiteral>] TransferProgressEvent =
    /// The number of bytes loaded so far.
    abstract loadedBytes: float with get, set

/// A class that handles creating, modifying, and parsing URLs.
type [<AllowNullLiteral>] URLBuilder =
    /// Set the scheme/protocol for this URL. If the provided scheme contains other parts of a URL
    /// (such as a host, port, path, or query), those parts will be added to this URL as well.
    abstract setScheme: scheme: string option -> unit
    /// Get the scheme that has been set in this URL.
    abstract getScheme: unit -> string option
    /// Set the host for this URL. If the provided host contains other parts of a URL (such as a
    /// port, path, or query), those parts will be added to this URL as well.
    abstract setHost: host: string option -> unit
    /// Get the host that has been set in this URL.
    abstract getHost: unit -> string option
    /// Set the port for this URL. If the provided port contains other parts of a URL (such as a
    /// path or query), those parts will be added to this URL as well.
    abstract setPort: port: U2<float, string> option -> unit
    /// Get the port that has been set in this URL.
    abstract getPort: unit -> string option
    /// Set the path for this URL. If the provided path contains a query, then it will be added to
    /// this URL as well.
    abstract setPath: path: string option -> unit
    /// Append the provided path to this URL's existing path. If the provided path contains a query,
    /// then it will be added to this URL as well.
    abstract appendPath: path: string option -> unit
    /// Get the path that has been set in this URL.
    abstract getPath: unit -> string option
    /// Set the query in this URL.
    abstract setQuery: query: string option -> unit
    /// Set a query parameter with the provided name and value in this URL's query. If the provided
    /// query parameter value is undefined or empty, then the query parameter will be removed if it
    /// existed.
    abstract setQueryParameter: queryParameterName: string * queryParameterValue: obj -> unit
    /// Get the value of the query parameter with the provided query parameter name. If no query
    /// parameter exists with the provided name, then undefined will be returned.
    abstract getQueryParameterValue: queryParameterName: string -> U2<string, ResizeArray<string>> option
    /// Get the query in this URL.
    abstract getQuery: unit -> string option
    abstract toString: unit -> string
    /// If the provided searchValue is found in this URLBuilder, then replace it with the provided
    /// replaceValue.
    abstract replaceAll: searchValue: string * replaceValue: string -> unit

/// A class that handles creating, modifying, and parsing URLs.
type [<AllowNullLiteral>] URLBuilderStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> URLBuilder
    abstract parse: text: string -> URLBuilder

type [<AllowNullLiteral>] UrlParameterValue =
    abstract value: string with get, set
    abstract skipUrlEncoding: bool with get, set

/// A class that handles the query portion of a URLBuilder.
type [<AllowNullLiteral>] URLQuery =
    /// Get whether or not there any query parameters in this URLQuery.
    abstract any: unit -> bool
    /// Get the keys of the query string.
    abstract keys: unit -> ResizeArray<string>
    /// Set a query parameter with the provided name and value. If the parameterValue is undefined or
    /// empty, then this will attempt to remove an existing query parameter with the provided
    /// parameterName.
    abstract set: parameterName: string * parameterValue: obj -> unit
    /// Get the value of the query parameter with the provided name. If no parameter exists with the
    /// provided parameter name, then undefined will be returned.
    abstract get: parameterName: string -> U2<string, ResizeArray<string>> option
    /// Get the string representation of this query. The return value will not start with a "?".
    abstract toString: unit -> string

/// A class that handles the query portion of a URLBuilder.
type [<AllowNullLiteral>] URLQueryStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> URLQuery
    /// Parse a URLQuery from the provided text.
    abstract parse: text: string -> URLQuery

/// Options for adding user agent details to outgoing requests.
type [<AllowNullLiteral>] UserAgentOptions =
    abstract userAgentPrefix: string option with get, set

/// Creates a new WebResource object.
///
/// This class provides an abstraction over a REST call by being library / implementation agnostic and wrapping the necessary
/// properties to initiate a request.
type [<AllowNullLiteral>] WebResource =
    inherit WebResourceLike
    /// The URL being accessed by the request.
    abstract url: string with get, set
    /// The HTTP method to use when making the request.
    abstract ``method``: HttpMethods with get, set
    /// The HTTP body contents of the request.
    abstract body: obj option with get, set
    /// The HTTP headers to use when making the request.
    abstract headers: HttpHeadersLike with get, set
    abstract streamResponseBody: bool option with get, set
    /// A list of status codes whose corresponding HttpOperationResponse body should be treated as a stream.
    abstract streamResponseStatusCodes: Set<float> option with get, set
    /// Whether or not the HttpOperationResponse should be deserialized. If this is undefined, then the
    /// HttpOperationResponse should be deserialized.
    abstract shouldDeserialize: U2<bool, HttpOperationResponse -> bool> option with get, set
    /// A function that returns the proper OperationResponse for the given OperationSpec and
    /// HttpOperationResponse combination. If this is undefined, then a simple status code lookup will
    /// be used.
    abstract operationResponseGetter: (OperationSpec -> HttpOperationResponse -> OperationResponse option) option with get, set
    abstract formData: obj option with get, set
    /// A query string represented as an object.
    abstract query: HttpOperationResponseParsedHeaders option with get, set
    /// Used to parse the response.
    abstract operationSpec: OperationSpec option with get, set
    /// If credentials (cookies) should be sent along during an XHR.
    abstract withCredentials: bool with get, set
    /// The number of milliseconds a request can take before automatically being terminated.
    /// If the request is terminated, an `AbortError` is thrown.
    abstract timeout: float with get, set
    /// Proxy configuration.
    abstract proxySettings: ProxySettings option with get, set
    /// If the connection should be reused.
    abstract keepAlive: bool option with get, set
    /// Whether or not to decompress response according to Accept-Encoding header (node-fetch only)
    abstract decompressResponse: bool option with get, set
    /// A unique identifier for the request. Used for logging and tracing.
    abstract requestId: string with get, set
    /// Used to abort the request later.
    abstract abortSignal: AbortSignalLike option with get, set
    /// Callback which fires upon upload progress.
    abstract onUploadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Callback which fires upon download progress.
    abstract onDownloadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Tracing: Options used to create a span when tracing is enabled.
    abstract spanOptions: SpanOptions option with get, set
    /// Tracing: Context used when creating Spans.
    abstract tracingContext: Context option with get, set
    /// Validates that the required properties such as method, url, headers["Content-Type"],
    /// headers["accept-language"] are defined. It will throw an error if one of the above
    /// mentioned properties are not defined.
    abstract validateRequestProperties: unit -> unit
    /// <summary>Prepares the request.</summary>
    /// <param name="options">- Options to provide for preparing the request.</param>
    abstract prepare: options: RequestPrepareOptions -> WebResource
    /// Clone this WebResource HTTP request object.
    abstract clone: unit -> WebResource

/// Creates a new WebResource object.
///
/// This class provides an abstraction over a REST call by being library / implementation agnostic and wrapping the necessary
/// properties to initiate a request.
type [<AllowNullLiteral>] WebResourceStatic =
    [<Emit "new $0($1...)">] abstract Create: ?url: string * ?``method``: HttpMethods * ?body: obj * ?query: WebResourceStaticQuery * ?headers: U2<HttpOperationResponseParsedHeaders, HttpHeadersLike> * ?streamResponseBody: bool * ?withCredentials: bool * ?abortSignal: AbortSignalLike * ?timeout: float * ?onUploadProgress: (TransferProgressEvent -> unit) * ?onDownloadProgress: (TransferProgressEvent -> unit) * ?proxySettings: ProxySettings * ?keepAlive: bool * ?decompressResponse: bool * ?streamResponseStatusCodes: Set<float> -> WebResource

type [<AllowNullLiteral>] WebResourceStaticQuery =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] WebResourceLike =
    /// The URL being accessed by the request.
    abstract url: string with get, set
    /// The HTTP method to use when making the request.
    abstract ``method``: HttpMethods with get, set
    /// The HTTP body contents of the request.
    abstract body: obj option with get, set
    /// The HTTP headers to use when making the request.
    abstract headers: HttpHeadersLike with get, set
    abstract streamResponseBody: bool option with get, set
    /// A list of response status codes whose corresponding HttpOperationResponse body should be treated as a stream.
    abstract streamResponseStatusCodes: Set<float> option with get, set
    /// Whether or not the HttpOperationResponse should be deserialized. If this is undefined, then the
    /// HttpOperationResponse should be deserialized.
    abstract shouldDeserialize: U2<bool, HttpOperationResponse -> bool> option with get, set
    /// A function that returns the proper OperationResponse for the given OperationSpec and
    /// HttpOperationResponse combination. If this is undefined, then a simple status code lookup will
    /// be used.
    abstract operationResponseGetter: (OperationSpec -> HttpOperationResponse -> OperationResponse option) option with get, set
    abstract formData: obj option with get, set
    /// A query string represented as an object.
    abstract query: HttpOperationResponseParsedHeaders option with get, set
    /// Used to parse the response.
    abstract operationSpec: OperationSpec option with get, set
    /// If credentials (cookies) should be sent along during an XHR.
    abstract withCredentials: bool with get, set
    /// The number of milliseconds a request can take before automatically being terminated.
    /// If the request is terminated, an `AbortError` is thrown.
    abstract timeout: float with get, set
    /// Proxy configuration.
    abstract proxySettings: ProxySettings option with get, set
    /// If the connection should be reused.
    abstract keepAlive: bool option with get, set
    /// Whether or not to decompress response according to Accept-Encoding header (node-fetch only)
    abstract decompressResponse: bool option with get, set
    /// A unique identifier for the request. Used for logging and tracing.
    abstract requestId: string with get, set
    /// Used to abort the request later.
    abstract abortSignal: AbortSignalLike option with get, set
    /// Callback which fires upon upload progress.
    abstract onUploadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Callback which fires upon download progress.
    abstract onDownloadProgress: (TransferProgressEvent -> unit) option with get, set
    /// Tracing: Options used to create a span when tracing is enabled.
    abstract spanOptions: SpanOptions option with get, set
    /// Tracing: Context used when creating spans.
    abstract tracingContext: Context option with get, set
    /// Validates that the required properties such as method, url, headers["Content-Type"],
    /// headers["accept-language"] are defined. It will throw an error if one of the above
    /// mentioned properties are not defined.
    abstract validateRequestProperties: unit -> unit
    /// Sets options on the request.
    abstract prepare: options: RequestPrepareOptions -> WebResourceLike
    /// Clone this request object.
    abstract clone: unit -> WebResourceLike

type [<AllowNullLiteral>] ConstantsHttpConstantsHttpVerbs =
    abstract PUT: string with get, set
    abstract GET: string with get, set
    abstract DELETE: string with get, set
    abstract POST: string with get, set
    abstract MERGE: string with get, set
    abstract HEAD: string with get, set
    abstract PATCH: string with get, set

type [<AllowNullLiteral>] ConstantsHttpConstantsStatusCodes =
    abstract TooManyRequests: float with get, set
    abstract ServiceUnavailable: float with get, set

type [<AllowNullLiteral>] ConstantsHttpConstants =
    /// Http Verbs
    abstract HttpVerbs: ConstantsHttpConstantsHttpVerbs with get, set
    abstract StatusCodes: ConstantsHttpConstantsStatusCodes with get, set

type [<AllowNullLiteral>] ConstantsHeaderConstants =
    /// The Authorization header.
    abstract AUTHORIZATION: string with get, set
    abstract AUTHORIZATION_SCHEME: string with get, set
    /// The Retry-After response-header field can be used with a 503 (Service
    /// Unavailable) or 349 (Too Many Requests) responses to indicate how long
    /// the service is expected to be unavailable to the requesting client.
    abstract RETRY_AFTER: string with get, set
    /// The UserAgent header.
    abstract USER_AGENT: string with get, set

type [<AllowNullLiteral>] Constants =
    /// The core-http version
    abstract coreHttpVersion: string with get, set
    /// Specifies HTTP.
    abstract HTTP: string with get, set
    /// Specifies HTTPS.
    abstract HTTPS: string with get, set
    /// Specifies HTTP Proxy.
    abstract HTTP_PROXY: string with get, set
    /// Specifies HTTPS Proxy.
    abstract HTTPS_PROXY: string with get, set
    /// Specifies NO Proxy.
    abstract NO_PROXY: string with get, set
    /// Specifies ALL Proxy.
    abstract ALL_PROXY: string with get, set
    abstract HttpConstants: ConstantsHttpConstants with get, set
    /// Defines constants for use with HTTP headers.
    abstract HeaderConstants: ConstantsHeaderConstants with get, set

type [<AllowNullLiteral>] MapperType =
    abstract Date: string with get, set
    abstract Base64Url: string with get, set
    abstract Boolean: string with get, set
    abstract ByteArray: string with get, set
    abstract DateTime: string with get, set
    abstract DateTimeRfc1123: string with get, set
    abstract Object: string with get, set
    abstract Stream: string with get, set
    abstract String: string with get, set
    abstract TimeSpan: string with get, set
    abstract UnixTime: string with get, set
    abstract Number: string with get, set
    abstract Composite: string with get, set
    abstract Sequence: string with get, set
    abstract Dictionary: string with get, set
    abstract Enum: string with get, set

type [<AllowNullLiteral>] IExportsCreateSpanFunction<'T> =
    abstract span: Span with get, set
    abstract updatedOptions: 'T with get, set

type [<AllowNullLiteral>] ApiKeyCredentialOptionsInHeader =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: x: string -> obj option with get, set

type [<AllowNullLiteral>] CompositeMapperTypeModelProperties =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: propertyName: string -> Mapper with get, set

type [<AllowNullLiteral>] HttpOperationResponseParsedHeaders =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] OperationRequestOptionsCustomHeaders =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set

type [<AllowNullLiteral>] OperationSpecResponses =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: responseCode: string -> OperationResponse with get, set

type [<AllowNullLiteral>] RequestPrepareOptionsQueryParameters =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<obj option, ParameterValue> with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] SimpleMapperTypeName =
    | [<CompiledName "Base64Url">] Base64Url
    | [<CompiledName "Boolean">] Boolean
    | [<CompiledName "ByteArray">] ByteArray
    | [<CompiledName "Date">] Date
    | [<CompiledName "DateTime">] DateTime
    | [<CompiledName "DateTimeRfc1123">] DateTimeRfc1123
    | [<CompiledName "Object">] Object
    | [<CompiledName "Stream">] Stream
    | [<CompiledName "String">] String
    | [<CompiledName "TimeSpan">] TimeSpan
    | [<CompiledName "UnixTime">] UnixTime
    | [<CompiledName "Uuid">] Uuid
    | [<CompiledName "Number">] Number
    | Any

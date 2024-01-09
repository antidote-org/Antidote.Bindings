// ts2fable 0.7.1
// ❯ ts2fable  temp/fable-azure-azauth.d.ts src/AzAuth.fs
// ts2fable 0.7.1
// export temp/fable-azure-azauth.d.ts
// unsupported NamedDeclaration kind: 162
// unsupported NamedDeclaration kind: 162
// unsupported NamedDeclaration kind: 162
// unsupported NamedDeclaration kind: 162
// unsupported TypeNode kind: 147
// unsupported TypeNode kind: 147
// unsupported TypeNode kind: 147
// unsupported TypeNode kind: 147
// unsupported TypeNode kind: 147
// createIExportsModule [temp], 
// unsupported printType ts2fable.Syntax.FsType.TODO: 
// unsupported printType ts2fable.Syntax.FsType.TODO: 
// unsupported printType ts2fable.Syntax.FsType.TODO: 
// unsupported printType ts2fable.Syntax.FsType.TODO: 
// unsupported printType ts2fable.Syntax.FsType.TODO: 
// unsupported printType ts2fable.Syntax.FsType.TODO: 
// unsupported printType ts2fable.Syntax.FsType.TODO: 
// unsupported printType ts2fable.Syntax.FsType.TODO: 
// unsupported printType ts2fable.Syntax.FsType.TODO: 
module rec AzAuth
open System
open Fable.Core
open Fable.Core.JS
open AzAbort

type Array<'T> = System.Collections.Generic.IList<'T>
type Symbol = obj

// type AbortSignalLike = @azure_abort_controller.AbortSignalLike

type [<AllowNullLiteral>] IExports =
    abstract AzureKeyCredential: AzureKeyCredentialStatic
    abstract AzureNamedKeyCredential: AzureNamedKeyCredentialStatic
    abstract AzureSASCredential: AzureSASCredentialStatic
    /// <summary>Tests an object to determine whether it implements NamedKeyCredential.</summary>
    /// <param name="credential">- The assumed NamedKeyCredential to be tested.</param>
    abstract isNamedKeyCredential: credential: obj -> bool
    /// <summary>Tests an object to determine whether it implements SASCredential.</summary>
    /// <param name="credential">- The assumed SASCredential to be tested.</param>
    abstract isSASCredential: credential: obj -> bool
    /// <summary>Tests an object to determine whether it implements TokenCredential.</summary>
    /// <param name="credential">- The assumed TokenCredential to be tested.</param>
    abstract isTokenCredential: credential: obj -> bool

/// Represents an access token with an expiration time.
type [<AllowNullLiteral>] AccessToken =
    /// The access token returned by the authentication service.
    abstract token: string with get, set
    /// The access token's expiration timestamp in milliseconds, UNIX epoch time.
    abstract expiresOnTimestamp: float with get, set

/// A static-key-based credential that supports updating
/// the underlying key value.
type [<AllowNullLiteral>] AzureKeyCredential =
    inherit KeyCredential
    // TODO: OBJ
    /// <summary>Change the value of the key.
    /// 
    /// Updates will take effect upon the next request after
    /// updating the key value.</summary>
    /// <param name="newKey">- The new key value to be used</param>
    abstract update: newKey: string -> unit

/// A static-key-based credential that supports updating
/// the underlying key value.
type [<AllowNullLiteral>] AzureKeyCredentialStatic =
    /// <summary>Create an instance of an AzureKeyCredential for use
    /// with a service client.</summary>
    /// <param name="key">- The initial value of the key to use in authentication</param>
    [<Emit "new $0($1...)">] abstract Create: key: string -> AzureKeyCredential

/// A static name/key-based credential that supports updating
/// the underlying name and key values.
type [<AllowNullLiteral>] AzureNamedKeyCredential =
    inherit NamedKeyCredential
    // TODO: 2x OBJ
    /// <summary>Change the value of the key.
    /// 
    /// Updates will take effect upon the next request after
    /// updating the key value.</summary>
    /// <param name="newName">- The new name value to be used.</param>
    /// <param name="newKey">- The new key value to be used.</param>
    abstract update: newName: string * newKey: string -> unit

/// A static name/key-based credential that supports updating
/// the underlying name and key values.
type [<AllowNullLiteral>] AzureNamedKeyCredentialStatic =
    /// <summary>Create an instance of an AzureNamedKeyCredential for use
    /// with a service client.</summary>
    /// <param name="name">- The initial value of the name to use in authentication.</param>
    /// <param name="key">- The initial value of the key to use in authentication.</param>
    [<Emit "new $0($1...)">] abstract Create: name: string * key: string -> AzureNamedKeyCredential

/// A static-signature-based credential that supports updating
/// the underlying signature value.
type [<AllowNullLiteral>] AzureSASCredential =
    inherit SASCredential
    // TODO: OBJ
    /// <summary>Change the value of the signature.
    /// 
    /// Updates will take effect upon the next request after
    /// updating the signature value.</summary>
    /// <param name="newSignature">- The new shared access signature value to be used</param>
    abstract update: newSignature: string -> unit

/// A static-signature-based credential that supports updating
/// the underlying signature value.
type [<AllowNullLiteral>] AzureSASCredentialStatic =
    /// <summary>Create an instance of an AzureSASCredential for use
    /// with a service client.</summary>
    /// <param name="signature">- The initial value of the shared access signature to use in authentication</param>
    [<Emit "new $0($1...)">] abstract Create: signature: string -> AzureSASCredential

/// An interface structurally compatible with OpenTelemetry.
type [<AllowNullLiteral>] Context =
    /// <summary>Get a value from the context.</summary>
    /// <param name="key">- key which identifies a context value</param>
    abstract getValue: key: Symbol -> obj
    /// <summary>Create a new context which inherits from this context and has
    /// the given key set to the given value.</summary>
    /// <param name="key">- context key for which to set the value</param>
    /// <param name="value">- value to set for the given key</param>
    abstract setValue: key: Symbol * value: obj -> Context
    /// <summary>Return a new context which inherits from this context but does
    /// not contain a value for the given key.</summary>
    /// <param name="key">- context key for which to clear a value</param>
    abstract deleteValue: key: Symbol -> Context

/// Defines options for TokenCredential.getToken.
type [<AllowNullLiteral>] GetTokenOptions =
    /// The signal which can be used to abort requests.
    abstract abortSignal: AbortSignalLike option with get, set
    /// Options used when creating and sending HTTP requests for this operation.
    abstract requestOptions: GetTokenOptionsRequestOptions option with get, set
    /// Options used when tracing is enabled.
    abstract tracingOptions: GetTokenOptionsTracingOptions option with get, set
    /// Allows specifying a tenantId. Useful to handle challenges that provide tenant Id hints.
    abstract tenantId: string option with get, set

/// Represents a credential defined by a static API key.
type [<AllowNullLiteral>] KeyCredential =
    /// The value of the API key represented as a string
    abstract key: string

/// Represents a credential defined by a static API name and key.
type [<AllowNullLiteral>] NamedKeyCredential =
    /// The value of the API key represented as a string
    abstract key: string
    /// The value of the API name represented as a string.
    abstract name: string

/// Represents a credential defined by a static shared access signature.
type [<AllowNullLiteral>] SASCredential =
    /// The value of the shared access signature represented as a string
    abstract signature: string

/// Attributes for a Span.
type [<AllowNullLiteral>] SpanAttributes =
    /// Span attributes.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: attributeKey: string -> SpanAttributeValue option with get, set

type SpanAttributeValue =
    U6<string, float, bool, Array<string option>, Array<float option>, Array<bool option>>

/// A light interface that tries to be structurally compatible with OpenTelemetry.
type [<AllowNullLiteral>] SpanContext =
    /// UUID of a trace.
    abstract traceId: string with get, set
    /// UUID of a Span.
    abstract spanId: string with get, set
    /// https://www.w3.org/TR/trace-context/#trace-flags
    abstract traceFlags: float with get, set

/// An interface that enables manual propagation of Spans.
type [<AllowNullLiteral>] SpanOptions =
    /// Attributes to set on the Span
    abstract attributes: SpanAttributes option with get, set

/// Represents a credential capable of providing an authentication token.
type [<AllowNullLiteral>] TokenCredential =
    /// <summary>Gets the token provided by this credential.
    /// 
    /// This method is called automatically by Azure SDK client libraries. You may call this method
    /// directly, but you must also handle token caching and token refreshing.</summary>
    /// <param name="scopes">- The list of scopes for which the token will have access.</param>
    /// <param name="options">- The options used to configure any requests this
    /// TokenCredential implementation might make.</param>
    abstract getToken: scopes: U2<string, ResizeArray<string>> * ?options: GetTokenOptions -> Promise<AccessToken option>

type [<AllowNullLiteral>] GetTokenOptionsRequestOptions =
    /// The number of milliseconds a request can take before automatically being terminated.
    abstract timeout: float option with get, set

type [<AllowNullLiteral>] GetTokenOptionsTracingOptions =
    /// OpenTelemetry SpanOptions used to create a span when tracing is enabled.
    abstract spanOptions: SpanOptions option with get, set
    /// OpenTelemetry context
    abstract tracingContext: Context option with get, set

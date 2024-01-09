// ts2fable 0.7.1
module rec AzCommon
open System
open Fable.Core
open Fable.Core.JS
open AzAuth
open AzHttp
open AzAbort

let [<Import("*","@azure/communication-common")>] exports: IExports = jsNative


// type AbortSignalLike = @azure_core_http.AbortSignalLike
// type AccessToken = @azure_core_http.AccessToken
// type KeyCredential = @azure_core_auth.KeyCredential
// type RequestPolicyFactory = @azure_core_http.RequestPolicyFactory
// type TokenCredential = @azure_core_auth.TokenCredential
let [<Import("createCommunicationAccessKeyCredentialPolicy","temp")>] createCommunicationAccessKeyCredentialPolicy: (KeyCredential -> RequestPolicyFactory) = jsNative
let [<Import("createCommunicationAuthPolicy","temp")>] createCommunicationAuthPolicy: (U2<KeyCredential, TokenCredential> -> RequestPolicyFactory) = jsNative
let [<Import("deserializeCommunicationIdentifier","temp")>] deserializeCommunicationIdentifier: (SerializedCommunicationIdentifier -> CommunicationIdentifierKind) = jsNative
let [<Import("getIdentifierKind","temp")>] getIdentifierKind: (CommunicationIdentifier -> CommunicationIdentifierKind) = jsNative
let [<Import("isCommunicationUserIdentifier","temp")>] isCommunicationUserIdentifier: (CommunicationIdentifier -> bool) = jsNative
let [<Import("isKeyCredential","temp")>] isKeyCredential: (obj -> bool) = jsNative
let [<Import("isMicrosoftTeamsUserIdentifier","temp")>] isMicrosoftTeamsUserIdentifier: (CommunicationIdentifier -> bool) = jsNative
let [<Import("isPhoneNumberIdentifier","temp")>] isPhoneNumberIdentifier: (CommunicationIdentifier -> bool) = jsNative
let [<Import("isUnknownIdentifier","temp")>] isUnknownIdentifier: (CommunicationIdentifier -> bool) = jsNative
let [<Import("parseClientArguments","temp")>] parseClientArguments: (string -> obj -> UrlWithCredential) = jsNative
let [<Import("parseConnectionString","temp")>] parseConnectionString: (string -> EndpointCredential) = jsNative
let [<Import("serializeCommunicationIdentifier","temp")>] serializeCommunicationIdentifier: (CommunicationIdentifier -> SerializedCommunicationIdentifier) = jsNative

type [<AllowNullLiteral>] IExports =
    abstract AzureCommunicationTokenCredential: AzureCommunicationTokenCredentialStatic

/// The CommunicationTokenCredential implementation with support for proactive token refresh.
type [<AllowNullLiteral>] AzureCommunicationTokenCredential =
    inherit CommunicationTokenCredential
    /// Gets an `AccessToken` for the user. Throws if already disposed.
    abstract getToken: options: CommunicationGetTokenOptions option -> Promise<AccessToken>
    /// Disposes the CommunicationTokenCredential and cancels any internal auto-refresh operation.
    abstract dispose: unit -> unit

/// The CommunicationTokenCredential implementation with support for proactive token refresh.
type [<AllowNullLiteral>] AzureCommunicationTokenCredentialStatic =
    /// <summary>Creates an instance of CommunicationTokenCredential with a static token and no proactive refreshing.</summary>
    /// <param name="token">- A user access token issued by Communication Services.</param>
    [<Emit "new $0($1...)">] abstract Create: token: string -> AzureCommunicationTokenCredential
    /// <summary>Creates an instance of CommunicationTokenCredential with a lambda to get a token and options
    /// to configure proactive refreshing.</summary>
    /// <param name="refreshOptions">- Options to configure refresh and opt-in to proactive refreshing.</param>
    [<Emit "new $0($1...)">] abstract Create: refreshOptions: CommunicationTokenRefreshOptions -> AzureCommunicationTokenCredential

/// Options for `CommunicationTokenCredential`'s `getToken` function.
type [<AllowNullLiteral>] CommunicationGetTokenOptions =
    /// An implementation of `AbortSignalLike` to cancel the operation.
    abstract abortSignal: AbortSignalLike option with get, set

type CommunicationIdentifier =
    U4<CommunicationUserIdentifier, PhoneNumberIdentifier, MicrosoftTeamsUserIdentifier, UnknownIdentifier>

type CommunicationIdentifierKind =
    U4<CommunicationUserKind, PhoneNumberKind, MicrosoftTeamsUserKind, UnknownIdentifierKind>

/// The Azure Communication Services token credential.
type [<AllowNullLiteral>] CommunicationTokenCredential =
    /// <summary>Gets an `AccessToken` for the user. Throws if already disposed.</summary>
    /// <param name="options">- Additional options.</param>
    abstract getToken: options: CommunicationGetTokenOptions option -> Promise<AccessToken>
    /// Disposes the CommunicationTokenCredential and cancels any internal auto-refresh operation.
    abstract dispose: unit -> unit

/// Options for auto-refreshing a Communication Token credential.
type [<AllowNullLiteral>] CommunicationTokenRefreshOptions =
    /// Function that returns a token acquired from the Communication configuration SDK.
    abstract tokenRefresher: (AbortSignalLike -> Promise<string>) with get, set
    /// Optional token to initialize.
    abstract token: string option with get, set
    /// Indicates whether the token should be proactively renewed prior to expiry or only renew on demand.
    /// By default false.
    abstract refreshProactively: bool option with get, set

/// An Azure Communication user.
type [<AllowNullLiteral>] CommunicationUserIdentifier =
    /// Id of the CommunicationUser as returned from the Communication Service.
    abstract communicationUserId: string with get, set

/// IdentifierKind for a CommunicationUserIdentifier.
type [<AllowNullLiteral>] CommunicationUserKind =
    inherit CommunicationUserIdentifier
    /// The identifier kind.
    abstract kind: string with get, set

/// Represents different properties of connection string
/// using format "/endpoint=(.*);accesskey=(.*)".
type [<AllowNullLiteral>] EndpointCredential =
    /// The endpoint as string
    abstract endpoint: string with get, set
    /// The access key represented as a KeyCredential object
    abstract credential: KeyCredential with get, set

/// A Microsoft Teams user.
type [<AllowNullLiteral>] MicrosoftTeamsUserIdentifier =
    /// Optional raw id of the Microsoft Teams user.
    abstract rawId: string option with get, set
    /// Id of the Microsoft Teams user. If the user isn't anonymous, the id is the AAD object id of the user.
    abstract microsoftTeamsUserId: string with get, set
    /// True if the user is anonymous, for example when joining a meeting with a share link. If missing, the user is not anonymous.
    abstract isAnonymous: bool option with get, set
    /// The cloud that the Microsoft Teams user belongs to. If missing, the cloud is "public".
    abstract cloud: MicrosoftTeamsUserIdentifierCloud option with get, set

/// IdentifierKind for a MicrosoftTeamsUserIdentifier.
type [<AllowNullLiteral>] MicrosoftTeamsUserKind =
    inherit MicrosoftTeamsUserIdentifier
    /// The identifier kind.
    abstract kind: string with get, set

/// A phone number.
type [<AllowNullLiteral>] PhoneNumberIdentifier =
    /// Optional raw id of the phone number.
    abstract rawId: string option with get, set
    /// The phone number in E.164 format.
    abstract phoneNumber: string with get, set

/// IdentifierKind for a PhoneNumberIdentifier.
type [<AllowNullLiteral>] PhoneNumberKind =
    inherit PhoneNumberIdentifier
    /// The identifier kind.
    abstract kind: string with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] SerializedCommunicationCloudEnvironment =
    | Public
    | Dod
    | Gcch

type [<AllowNullLiteral>] SerializedCommunicationIdentifier =
    /// Raw Id of the identifier. Optional in requests, required in responses.
    abstract rawId: string option with get, set
    /// The communication user.
    abstract communicationUser: SerializedCommunicationUserIdentifier option with get, set
    /// The phone number.
    abstract phoneNumber: SerializedPhoneNumberIdentifier option with get, set
    /// The Microsoft Teams user.
    abstract microsoftTeamsUser: SerializedMicrosoftTeamsUserIdentifier option with get, set

type [<AllowNullLiteral>] SerializedCommunicationUserIdentifier =
    /// The Id of the communication user.
    abstract id: string with get, set

type [<AllowNullLiteral>] SerializedMicrosoftTeamsUserIdentifier =
    /// The Id of the Microsoft Teams user. If not anonymous, this is the AAD object Id of the user.
    abstract userId: string with get, set
    /// True if the Microsoft Teams user is anonymous. By default false if missing.
    abstract isAnonymous: bool option with get, set
    /// The cloud that the Microsoft Teams user belongs to. By default 'public' if missing.
    abstract cloud: SerializedCommunicationCloudEnvironment option with get, set

type [<AllowNullLiteral>] SerializedPhoneNumberIdentifier =
    /// The phone number in E.164 format.
    abstract value: string with get, set

/// An unknown identifier that doesn't fit any of the other identifier types.
type [<AllowNullLiteral>] UnknownIdentifier =
    /// Id of the UnknownIdentifier.
    abstract id: string with get, set

/// IdentifierKind for UnkownIdentifer.
type [<AllowNullLiteral>] UnknownIdentifierKind =
    inherit UnknownIdentifier
    /// The identifier kind.
    abstract kind: string with get, set

type [<AllowNullLiteral>] UrlWithCredential =
    abstract url: string with get, set
    abstract credential: U2<TokenCredential, KeyCredential> with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] MicrosoftTeamsUserIdentifierCloud =
    | Public
    | Dod
    | Gcch

// ts2fable 0.7.1
module rec Connection
open System
open Fable.Core
open Fable.Core.JS

type Error = System.Exception


type [<AllowNullLiteral>] IExports =
    abstract HubConnectionBuilder: HubConnectionBuilderStatic

type [<RequireQualifiedAccess>] HttpTransportType =
    | None = 0
    | WebSockets = 1
    | ServerSentEvents = 2
    | LongPolling = 4

type [<AllowNullLiteral>] MessageHeaders =
    /// Gets or sets the header with the specified key.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set

type [<RequireQualifiedAccess>] TransferFormat =
    | Text = 1
    | Binary = 2

type [<AllowNullLiteral>] ITransport =
    abstract connect: url: string * transferFormat: TransferFormat -> Promise<unit>
    abstract send: data: obj option -> Promise<unit>
    abstract stop: unit -> Promise<unit>
    abstract onreceive: (U2<string, ArrayBuffer> -> unit) option with get, set
    abstract onclose: (Error -> unit) option with get, set

type [<AllowNullLiteral>] IHttpConnectionOptions =
    /// {@link @microsoft/signalr.MessageHeaders} containing custom headers to be sent with every HTTP request. Note, setting headers in the browser will not work for WebSockets or the ServerSentEvents stream.
    abstract headers: MessageHeaders option with get, set
    abstract transport: U2<HttpTransportType, ITransport> option with get, set

/// A builder for configuring {@link @microsoft/signalr.HubConnection} instances.
type [<AllowNullLiteral>] HubConnectionBuilder =
    abstract url: string option with get, set
    abstract httpConnectionOptions: IHttpConnectionOptions option with get, set
    abstract reconnectPolicy: obj option with get, set
    /// <summary>Configures the {@link @microsoft/signalr.HubConnection} to use HTTP-based transports to connect to the specified URL.
    ///
    /// The transport will be selected automatically based on what the server and client support.</summary>
    /// <param name="url">The URL the connection will use.</param>
    abstract withUrl: url: string -> HubConnectionBuilder
    abstract withUrl: url: string * options: IHttpConnectionOptions -> HubConnectionBuilder
    abstract withUrl: url: string * transportType: HttpTransportType -> HubConnectionBuilder
    abstract withUrl: url: string * ?transportTypeOrOptions: U2<IHttpConnectionOptions, HttpTransportType> -> HubConnectionBuilder
    abstract withAutomaticReconnect: unit -> HubConnectionBuilder
    /// <summary>Configures the {@link @microsoft/signalr.HubConnection} to automatically attempt to reconnect if the connection is lost.</summary>
    /// <param name="retryDelays">An array containing the delays in milliseconds before trying each reconnect attempt.
    /// The length of the array represents how many failed reconnect attempts it takes before the client will stop attempting to reconnect.</param>
    abstract withAutomaticReconnect: retryDelays: ResizeArray<float> -> HubConnectionBuilder
    /// <summary>Configures the {@link @microsoft/signalr.HubConnection} to automatically attempt to reconnect if the connection is lost.</summary>
    /// <param name="reconnectPolicy">An {@link</param>
    abstract withAutomaticReconnect: reconnectPolicy: obj option -> HubConnectionBuilder
    abstract withAutomaticReconnect: ?retryDelaysOrReconnectPolicy: U2<ResizeArray<float>, obj option> -> HubConnectionBuilder

/// A builder for configuring {@link @microsoft/signalr.HubConnection} instances.
type [<AllowNullLiteral>] HubConnectionBuilderStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> HubConnectionBuilder

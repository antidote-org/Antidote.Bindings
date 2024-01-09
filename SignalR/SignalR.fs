namespace Feliz.SignalR

open Fable.Core
open Elmish
open Fable.Core.JsInterop

module Connection =

    type IMessageHeaders =
        [<Emit "$0[$1]{{=$2}}">]
        abstract Item: key: string -> string

    type [<AllowNullLiteral>] IHttpConnectionOptions =
        abstract headers: IMessageHeaders option with get, set
        abstract withCredentials : bool option with get, set

    type IHubConnection =
        abstract options : obj -> obj
        abstract start : unit -> JS.Promise<unit>
        abstract stop : unit -> JS.Promise<unit>
        abstract on : methodName:string * newMethod:(obj -> unit) -> unit
        abstract invoke: string * string -> unit

    type IHubConnectionBuilder =
        abstract withUrl : string -> IHubConnectionBuilder
        abstract withUrl: url: string * options: IHttpConnectionOptions -> IHubConnectionBuilder
        abstract withAutomaticReconnect : unit -> IHubConnectionBuilder
        abstract build : unit -> IHubConnection
    type ISignalR =
        abstract HubConnectionBuilder : unit -> IHubConnectionBuilder

    [<ImportAll("@microsoft/signalr")>]
    [<Emit("new signalr.HubConnectionBuilder()")>]
    let HubConnectionBuilder() : IHubConnectionBuilder = jsNative

    let signalrOnMessageHandler (connection:IHubConnection) message f =
        let sub dispatch = connection.on (message, f)
        Cmd.ofEffect sub

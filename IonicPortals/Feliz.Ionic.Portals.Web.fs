// ts2fable 0.8.0-build.644
module rec Feliz.Ionic.Portals.Web
open System
open Fable.Core
open Fable.Core.JS
open Feliz.Ionic.Portals.Definitions

[<Import("*", "@ionic/portals")>]
let PortalsWeb: PortalsWeb = jsNative

[<AllowNullLiteral>]
type IExports =
    abstract PortalsWeb: PortalsWebStatic

[<AllowNullLiteral>]
type PortalsWeb =
    inherit PortalsPlugin
    abstract publish: _message: PortalMessage<'T> -> Promise<unit>
    abstract subscribe: _options: SubscribeOptions * _callback: ({| topic: string; data: 'T; |} -> unit) -> Promise<PortalSubscription>
    abstract unsubscribe: _options: PortalSubscription -> Promise<unit>
    abstract echo: options: {| value: string |} -> Promise<{| value: string |}>
    abstract getInitialContext: unit -> Promise<InitialContext<'T>>

type [<AllowNullLiteral>] PortalsWebStatic =
    [<EmitConstructor>] abstract Create: unit -> PortalsWeb

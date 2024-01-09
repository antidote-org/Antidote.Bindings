module rec Feliz.Ionic.Portals.Definitions

open System
open Fable.Core
open Fable.Core.JS


/// <summary>A type definining the <c>PortalsPlugin</c> API.</summary>
type [<AllowNullLiteral>] PortalsPlugin =
    abstract getInitialContext: unit -> Promise<InitialContext<'T>>
    abstract publish: message: PortalMessage<'T> -> Promise<unit>
    abstract subscribe: options: SubscribeOptions * _callback: ({| topic: string; data: 'T |} -> unit) -> Promise<PortalSubscription>
    // abstract subscribe: options: SubscribeOptions * callback: SubscriptionCallback<'T> -> Promise<PortalSubscription>
    abstract unsubscribe: options: PortalSubscription -> Promise<unit>

/// <summary>A type definining the <c>InitialContext</c> from the native application that you can pass into your web application.</summary>
type InitialContext =
    InitialContext<obj>

/// <summary>A type definining the <c>InitialContext</c> from the native application that you can pass into your web application.</summary>
type [<AllowNullLiteral>] InitialContext<'T> =
    abstract name: string with get, set
    abstract value: 'T with get, set

// A message that you can publish to a topic using Portals.publish()
// type PortalMessage =
//     PortalMessage<obj option>

/// A message that you can publish to a topic using Portals.publish()
// type [<AllowNullLiteral>] PortalMessage<'TData> =
//     abstract topic: string with get, set
//     abstract data: 'TData option with get, set
[<AllowNullLiteral>]
[<Global>]
type PortalMessage<'T>
    [<ParamObject; Emit("$0")>]
    (
        ?topic : string,
        ?data: 'T option
    ) =
    member val topic: string option = jsNative with get, set
    member val data: 'T option = jsNative with get, set

/// Subscription options that you pass into your function when running Portals.subscribe()
// type [<AllowNullLiteral>] SubscribeOptions =
//     abstract topic: string with get, set

[<AllowNullLiteral>]
[<Global>]
type SubscribeOptions [<ParamObject; Emit("$0")>] ( ?topic: string ) =
    member val topic: string option = jsNative with get, set

/// The subscription created when running Portals.subscribe()
//  [<AllowNullLiteral>]
// type PortalSubscription =
//     abstract subscriptionRef: float with get, set
//     abstract topic: string with get, set

[<AllowNullLiteral>]
[<Global>]
type PortalSubscription
    [<ParamObject; Emit("$0")>]
    (
        ?subscriptionRef: float,
        ?topic : string
    ) =
    member val subscriptionRef: float option = jsNative with get, set
    member val topic: string option = jsNative with get, set

// ts2fable 0.9.0
module rec SpeechSDK

#nowarn "3390" // disable warnings for invalid XML comments
#nowarn "0044" // disable warnings for `Obsolete` usage

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

module SpeechSDK =


    [<ImportAll("@microsoft/signalr")>]
    [<Emit("new signalr.HubConnectionBuilder()")>]
    let fromSubscription() : obj = jsNative

    //   const config = SpeechSDK.SpeechConfig.fromSubscription(
    //     subscriptionKey,
    //     serviceRegion
    //   );

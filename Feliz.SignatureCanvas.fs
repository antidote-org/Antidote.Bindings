module Feliz.SignatureCanvas

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser

type ISignatureCanvasProperty =
    interface end

module Interop =
    let inline mkSignatureCanvasAttr (key: string) (value: obj) : ISignatureCanvasProperty = unbox (key, value)


[<Erase>]
type Exports =
    static member inline signatureCanvas (props: ISignatureCanvasProperty list) =
        Interop.reactApi.createElement(import "default" "react-signature-canvas", createObj !!props)

[<Erase>]
type signatureCanvas =
    static member inline toDataURL (data: string, ?options: obj) : unit = jsNative

    static member inline velocityFilterWeight  (value : float) =
        Interop.mkSignatureCanvasAttr "velocityFilterWeight " value

    static member inline minWidth (value : float) =
        Interop.mkSignatureCanvasAttr "minWidth " value

    static member inline maxWidth (value : float) =
        Interop.mkSignatureCanvasAttr "maxWidth " value

    static member inline minDistance (value : float) =
        Interop.mkSignatureCanvasAttr "minDistance " value

    static member inline dotSize (value : float) =
        Interop.mkSignatureCanvasAttr "dotSize" value

    static member inline dotSize (func : unit -> float) =
        Interop.mkSignatureCanvasAttr "dotSize" func

    static member inline penColor (value : string) =
        Interop.mkSignatureCanvasAttr "penColor" value

    static member inline throttle (value : float) =
        Interop.mkSignatureCanvasAttr "throttle " value

    static member inline onEnd (func : obj -> unit) =
        Interop.mkSignatureCanvasAttr "onEnd" func

    static member inline onBegin (func : unit -> unit) =
        Interop.mkSignatureCanvasAttr "onBegin" func

    static member inline canvasProps (value : IReactProperty list) =
        Interop.mkSignatureCanvasAttr "canvasProps" (createObj !!value)

    static member inline backgroundColor (value : string) =
        Interop.mkSignatureCanvasAttr "backgroundColor" value

    static member inline clearOnResize (value : bool) =
        Interop.mkSignatureCanvasAttr "clearOnResize" value

    static member inline ref (ref: IRefValue<Types.HTMLCanvasElement>) =
        Interop.mkSignatureCanvasAttr "ref" ref

module Feliz.ReactRnd

open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type IRndProperty =
    interface end

[<Erase>]
type ReactRnd =
    static member inline rnd (props: IRndProperty list) =
        Interop.reactApi.createElement(import "*" "react-rnd", createObj !!props)

module Interop =
    let inline mkRndAttr (key: string) (value: obj) : IRndProperty = unbox (key, value)

[<Erase>]
type rnd =

    static member inline default' (x : int, y : int, width : int, height : int) =
        Interop.mkRndAttr
            "default"
            (createObj [
                "x" ==> x
                "y" ==> y
                "width" ==> width
                "height" ==> height
            ])

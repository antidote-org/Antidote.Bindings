module ReactSvg

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open Fable.React

// import { ReactSVG } from 'react-svg'

open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type IReactSvgProperty =
    interface end

[<Erase>]
type ReactSvg =

    static member inline svg (props: IReactProperty list) =
        Interop.reactApi.createElement(import "ReactSVG" "react-svg", createObj !!props)

module Interop =

    let inline mkReacSvgAttr (key: string) (value: obj) : IReactSvgProperty = unbox (key, value)


[<Erase>]
type ReactSvgProps =
    static member inline value (value : string) =
        Interop.mkReacSvgAttr "src" value


let svg (src: string) =
    ReactSvg.svg [
        prop.src src
    ]

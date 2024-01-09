// https://tpetricek.github.io/Fable/docs/interacting.html
// https://hashset.dev/article/18_let_s_write_fable_bindings_for_a_js_library

module Feliz.QRCode

open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type IImageSettingsProperty =
    interface end

[<Erase>]
type IQRCodeProperty =
    interface end

[<Erase>]
type qrcode =

    static member inline QRCode (props: IQRCodeProperty list) =
        Interop.reactApi.createElement(import "default" "qrcode.react", createObj !!props)

module Interop =

    let inline mkQRCodeAttr (key: string) (value: obj) : IQRCodeProperty = unbox (key, value)

    let inline mkImageSettingsAttr (key: string) (value: obj) : IImageSettingsProperty = unbox (key, value)

[<Erase>]
type QRCode =

    static member inline value (value : string) =
        Interop.mkQRCodeAttr "value" value

    static member inline size (size : int) =
        Interop.mkQRCodeAttr "size" size

    static member inline bgColor (bgColor : string) =
        Interop.mkQRCodeAttr "bgColor" bgColor

    static member inline fgColor (fgColor : string) =
        Interop.mkQRCodeAttr "fgColor" fgColor

    static member inline level (level : string) =
        Interop.mkQRCodeAttr "level" level

    static member inline includeMargin (includeMargin : bool) =
        Interop.mkQRCodeAttr "includeMargin" includeMargin

    static member inline renderAs (renderAs : string) =
        Interop.mkQRCodeAttr "renderAs" renderAs

    static member inline imageSettings (imageSettings : IImageSettingsProperty list) =
        Interop.mkQRCodeAttr "imageSettings" imageSettings

    static member inline imageSettingsObj (imageSettings : obj) =
        Interop.mkQRCodeAttr "imageSettings" imageSettings

[<Erase>]
type imageSettings =

    static member inline src (src : string) =
        Interop.mkImageSettingsAttr "src" src

    static member inline x (x : int) =
        Interop.mkImageSettingsAttr "x" x

    static member inline y (y : int) =
        Interop.mkImageSettingsAttr "y" y

    static member inline height (height : int) =
        Interop.mkImageSettingsAttr "height" height

    static member inline width (width : int) =
        Interop.mkImageSettingsAttr "width" width

    static member inline excavate (excavate : bool) =
        Interop.mkImageSettingsAttr "excavate" excavate

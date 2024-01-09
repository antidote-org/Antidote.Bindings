module rec Feliz.Toastify

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type IToastContainerAttr =
    interface end

module Interop =
    let inline mkToastContainerAttr (key: string) (value: obj) : IToastContainerAttr = unbox (key, value)

[<Erase>]
type Exports =
    static member inline ToastContainer  (props: IToastContainerAttr list) =
        Interop.reactApi.createElement(import "ToastContainer" "react-toastify", createObj !!props)

    [<Import("toast", "react-toastify")>]
    static member inline toast (content: ReactElement, ?options: ToastOptions) : Id =
        jsNative

    [<Import("toast", "react-toastify")>]
    static member inline toast (content: ToastContentProps -> ReactElement, ?options: ToastOptions) : Id =
        jsNative

type ToastContentProps =
    class end

type Id = U2<float, string>

type [<StringEnum>] [<RequireQualifiedAccess>] TypeOptions =
    | Info
    | Success
    | Warning
    | Error
    | Default

[<Global>]
type ToastOptions [<ParamObject; Emit "$0">]
    (
        ?className: string,
        ?onOpen: obj -> unit,
        ?onClose: obj -> unit,
        ?style: IStyleAttribute,
        ?``type``: TypeOptions,
        ?toastId: Id,
        ?updateId: Id,
        ?progress: U2<float, string>,
        ?delay: float,
        ?isLoading: bool,
        ?data: obj,
        ?autoClose: bool
    ) =
    /// An optional css class to set.
    member val className : string option = jsNative with get, set
    /// Called when toast is mounted.
    member val onOpen : (obj -> unit) option = jsNative with get, set
    /// Called when toast is unmounted.
    member val onClose : (obj -> unit) option = jsNative with get, set
    /// An optional inline style to apply.
    member val style : IStyleAttribute option = jsNative with get, set
    /// <summary>
    /// Set the toast type.
    /// <c>One of: 'info', 'success', 'warning', 'error', 'default'</c>
    /// </summary>
    member val `` type``: TypeOptions option = jsNative with get, set
    /// <summary>Set a custom <c>toastId</c></summary>
    member val toastId : Id option = jsNative with get, set
    /// Used during update
    member val updateId : Id option = jsNative with get, set
    /// <summary>Set the percentage for the controlled progress bar. <c>Value must be between 0 and 1.</c></summary>
    member val progress : U2<float, string> option = jsNative with get, set
    /// Add a delay in ms before the toast appear.
    member val delay : float option = jsNative with get, set
    member val isLoading : bool option = jsNative with get, set
    member val autoClose: bool = jsNative with get, set
    member val data : obj option = jsNative with get, set

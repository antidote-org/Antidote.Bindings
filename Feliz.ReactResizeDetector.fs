module rec Feliz.ReactResizeDetector

open Fable.Core
open Browser.Types
open System

[<Erase>]
type ReactResizeDetector =

    [<Hook; Import("useResizeDetector", "react-resize-detector")>]
    static member useResizeDetector (?props: Props) : UseResizeDetectorReturn<'T> =
        jsNative

[<Erase>]
type KeyOf<'T> = Key of string

type [<AllowNullLiteral>] ResizeObserverOptions =
    /// <summary>
    /// Sets which box model the observer will observe changes to. Possible values
    /// are <c>content-box</c> (the default), and <c>border-box</c>.
    /// </summary>
    /// <default>'content-box'</default>
    abstract box: ResizeObserverOptionsBox option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ResizeObserverOptionsBox =
    | [<CompiledName "content-box">] ContentBox
    | [<CompiledName "border-box">] BorderBox
    | [<CompiledName "device-pixel-content-box">] DevicePixelContentBox

type [<AllowNullLiteral>] IExports =
    abstract ResizeDetector: ResizeDetectorStatic
    abstract useResizeDetector : ?props: FunctionProps -> UseResizeDetectorReturn<'T>

type [<AllowNullLiteral>] ReactResizeDetectorDimensions =
    abstract height: float with get, set
    abstract width: float with get, set

type [<AllowNullLiteral>] ChildFunctionProps<'ElementT when 'ElementT :> HTMLElement> =
    inherit ReactResizeDetectorDimensions
    abstract targetRef: IRefValue<'ElementT> option with get, set

type [<AllowNullLiteral>] Props =
    /// Function that will be invoked with observable element's width and height.
    /// Default: undefined
    abstract onResize: ((float) option -> (float) option -> unit) option with get, set
    /// Trigger update on height change.
    /// Default: true
    abstract handleHeight: bool option with get, set
    /// Trigger onResize on width change.
    /// Default: true
    abstract handleWidth: bool option with get, set
    /// Do not trigger update when a component mounts.
    /// Default: false
    abstract skipOnMount: bool option with get, set
    /// <summary>
    /// Changes the update strategy. Possible values: "throttle" and "debounce".
    /// See <c>lodash</c> docs for more information <see href="https://lodash.com/docs/" />
    /// undefined - callback will be fired for every frame.
    /// Default: undefined
    /// </summary>
    abstract refreshMode: PropsRefreshMode option with get, set
    /// <summary>
    /// Set the timeout/interval for <c>refreshMode</c> strategy
    /// Default: undefined
    /// </summary>
    abstract refreshRate: float option with get, set
    /// <summary>
    /// Pass additional params to <c>refreshMode</c> according to lodash docs
    /// Default: undefined
    /// </summary>
    abstract refreshOptions: {| leading: bool option; trailing: bool option |} option with get, set
    /// <summary>These options will be used as a second parameter of <c>resizeObserver.observe</c> method</summary>
    /// <seealso href="https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver/observe">Default: undefined</seealso>
    abstract observerOptions: ResizeObserverOptions option with get, set

type [<AllowNullLiteral>] ComponentsProps<'ElementT when 'ElementT :> HTMLElement> =
    inherit Props
    abstract targetRef: IRefValue<'ElementT> option with get, set
    abstract render: (ReactResizeDetectorDimensions -> obj) option with get, set
    abstract children: U2<obj, (ChildFunctionProps<'ElementT> -> obj)> option with get, set

type ResizeDetector =
    ResizeDetector<HTMLElement>

type [<AllowNullLiteral>] ResizeDetector<'ElementT when 'ElementT :> HTMLElement> =
    // inherit PureComponent<ComponentsProps<'ElementT>, ReactResizeDetectorDimensions>
    abstract skipOnMount: bool option with get, set
    abstract targetRef: obj option with get, set
    abstract observableElement: obj option with get, set
    abstract resizeHandler: obj option with get, set
    abstract resizeObserver: obj option with get, set
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract cancelHandler: (unit -> unit) with get, set
    abstract attachObserver: (unit -> unit) with get, set
    abstract getElement: (unit -> U2<Element, Text> option) with get, set
    // abstract createResizeHandler: ResizeObserverCallback with get, set
    abstract getRenderType: (unit -> string) with get, set
    abstract render: unit -> obj option

type [<AllowNullLiteral>] ResizeDetectorStatic =
    [<EmitConstructor>] abstract Create: props: ComponentsProps<'ElementT> -> ResizeDetector<'ElementT>

type [<StringEnum>] [<RequireQualifiedAccess>] PropsRefreshMode =
    | Throttle
    | Debounce

type [<AllowNullLiteral>] FunctionProps =
    inherit Props
    // abstract targetRef: ReturnType<obj> option with get, set

type [<AllowNullLiteral>] UseResizeDetectorReturn<'T> =
    inherit ReactResizeDetectorDimensions
    abstract ref: IRefValue<'T option> with get, set

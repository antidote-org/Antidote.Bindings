module rec AzAbort
open System
open Fable.Core
open Fable.Core.JS

type Error = System.Exception


type [<AllowNullLiteral>] IExports =
    abstract AbortController_2: AbortController_2Static
    abstract AbortError: AbortErrorStatic
    abstract AbortSignal_2: AbortSignal_2Static

/// An AbortController provides an AbortSignal and the associated controls to signal
/// that an asynchronous operation should be aborted.
type [<AllowNullLiteral>] AbortController_2 =
    // TODO: OBJ
    /// Signal that any operations passed this controller's associated abort signal
    /// to cancel any remaining work and throw an `AbortError`.
    abstract abort: unit -> unit

/// An AbortController provides an AbortSignal and the associated controls to signal
/// that an asynchronous operation should be aborted.
type [<AllowNullLiteral>] AbortController_2Static =
    /// <param name="parentSignals">- The AbortSignals that will signal aborted on the AbortSignal associated with this controller.</param>
    [<Emit "new $0($1...)">] abstract Create: ?parentSignals: ResizeArray<AbortSignalLike> -> AbortController_2
    /// <param name="parentSignals">- The AbortSignals that will signal aborted on the AbortSignal associated with this controller.</param>
    [<Emit "new $0($1...)">] abstract Create: [<ParamArray>] parentSignals: ResizeArray<AbortSignalLike> -> AbortController_2
    /// <summary>Creates a new AbortSignal instance that will abort after the provided ms.</summary>
    /// <param name="ms">- Elapsed time in milliseconds to trigger an abort.</param>
    abstract timeout: ms: float -> AbortSignal_2

// This error is thrown when an asynchronous operation has been aborted.
// Check for this error by testing the `name` that the name property of the
// error matches `"AbortError"`.
// TODO: NEED TO IMPLEMENT ABORT ERROR
// type [<AllowNullLiteral>] AbortError =
//     inherit Error

/// This error is thrown when an asynchronous operation has been aborted.
/// Check for this error by testing the `name` that the name property of the
/// error matches `"AbortError"`.
type [<AllowNullLiteral>] AbortErrorStatic =
    // TODO: WAS THIS LINE // [<Emit "new $0($1...)">] abstract Create: ?message: string -> AbortError
    [<Emit "new $0($1...)">] abstract Create: ?message: string -> obj

/// An aborter instance implements AbortSignal interface, can abort HTTP requests.
///
/// - Call AbortSignal.none to create a new AbortSignal instance that cannot be cancelled.
/// Use `AbortSignal.none` when you are required to pass a cancellation token but the operation
/// cannot or will not ever be cancelled.
type [<AllowNullLiteral>] AbortSignal_2 =
    inherit AbortSignalLike
    // TODO: 2x OBJ
    /// onabort event listener.
    /// TODO: WAS THIS LINE // abstract onabort: (Event -> obj option) option with get, set
    abstract onabort: (obj -> obj option) option with get, set
    /// <summary>Added new "abort" event listener, only support "abort" event.</summary>
    /// <param name="listener">- The listener to be added</param>
    [<Emit "$0.addEventListener('abort',$1)">] abstract addEventListener_abort: listener: (AbortSignalLike -> obj option -> obj option) -> unit
    /// <summary>Remove "abort" event listener, only support "abort" event.</summary>
    /// <param name="listener">- The listener to be removed</param>
    [<Emit "$0.removeEventListener('abort',$1)">] abstract removeEventListener_abort: listener: (AbortSignalLike -> obj option -> obj option) -> unit
    /// Dispatches a synthetic event to the AbortSignal.
    /// TODO: WAS THIS LINE // abstract dispatchEvent: _event: Event -> bool
    abstract dispatchEvent: _event: obj -> bool

/// An aborter instance implements AbortSignal interface, can abort HTTP requests.
///
/// - Call AbortSignal.none to create a new AbortSignal instance that cannot be cancelled.
/// Use `AbortSignal.none` when you are required to pass a cancellation token but the operation
/// cannot or will not ever be cancelled.
type [<AllowNullLiteral>] AbortSignal_2Static =
    [<Emit "new $0($1...)">] abstract Create: unit -> AbortSignal_2

/// Allows the request to be aborted upon firing of the "abort" event.
/// Compatible with the browser built-in AbortSignal and common polyfills.
type [<AllowNullLiteral>] AbortSignalLike =
    /// Indicates if the signal has already been aborted.
    abstract aborted: bool
    /// Add new "abort" event listener, only support "abort" event.
    [<Emit "$0.addEventListener('abort',$1,$2)">] abstract addEventListener_abort: listener: (AbortSignalLike -> obj option -> obj option) * ?options: obj -> unit
    /// Remove "abort" event listener, only support "abort" event.
    [<Emit "$0.removeEventListener('abort',$1,$2)">] abstract removeEventListener_abort: listener: (AbortSignalLike -> obj option -> obj option) * ?options: obj -> unit

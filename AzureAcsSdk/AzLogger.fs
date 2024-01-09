// ts2fable 0.7.1
module rec AzLogger
open System
open Fable.Core
open Fable.Core.JS

let [<Import("AzureLogger","temp")>] AzureLogger: AzureClientLogger = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>Creates a logger for use by the Azure SDKs that inherits from `AzureLogger`.</summary>
    /// <param name="namespace">- The name of the SDK package.</param>
    abstract createClientLogger: ``namespace``: string -> AzureLogger
    /// Retrieves the currently specified log level.
    abstract getLogLevel: unit -> AzureLogLevel option
    /// <summary>Immediately enables logging at the specified log level.</summary>
    /// <param name="level">- The log level to enable for logging.
    /// Options from most verbose to least verbose are:
    /// - verbose
    /// - info
    /// - warning
    /// - error</param>
    abstract setLogLevel: ?level: AzureLogLevel -> unit

type AzureClientLogger =
    Debugger

/// The AzureLogger provides a mechanism for overriding where logs are output to.
/// By default, logs are sent to stderr.
/// Override the `log` method to redirect logs to another location.
/// Defines the methods available on the SDK-facing logger.
type [<AllowNullLiteral>] AzureLogger =
    /// Used for failures the program is unlikely to recover from,
    /// such as Out of Memory.
    abstract error: Debugger with get, set
    /// Used when a function fails to perform its intended task.
    /// Usually this means the function will throw an exception.
    /// Not used for self-healing events (e.g. automatic retry)
    abstract warning: Debugger with get, set
    /// Used when a function operates normally.
    abstract info: Debugger with get, set
    /// Used for detailed trbouleshooting scenarios. This is
    /// intended for use by developers / system administrators
    /// for diagnosing specific failures.
    abstract verbose: Debugger with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] AzureLogLevel =
    | Verbose
    | Info
    | Warning
    | Error

/// A log function that can be dynamically enabled and redirected.
type [<AllowNullLiteral>] Debugger =
    /// Logs the given arguments to the `log` method.
    [<Emit "$0($1...)">] abstract Invoke: [<ParamArray>] args: ResizeArray<obj option> -> unit
    /// True if this logger is active and logging.
    abstract enabled: bool with get, set
    /// Used to cleanup/remove this logger.
    abstract destroy: (unit -> bool) with get, set
    /// The current log method. Can be overridden to redirect output.
    abstract log: (ResizeArray<obj option> -> unit) with get, set
    /// The module of this logger.
    abstract ``namespace``: string with get, set
    /// Extends this logger with a child namespace.
    /// Namespaces are separated with a ':' character.
    abstract extend: (string -> Debugger) with get, set

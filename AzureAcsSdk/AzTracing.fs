// ts2fable 0.7.1
// ❯ ts2fable  temp/fable-azure-aztracing.d.ts src/AzTracing.fs
// ts2fable 0.7.1
// export temp/fable-azure-aztracing.d.ts
// unsupported TypeNode kind: 147
// unsupported TypeNode kind: 147
// createIExportsModule [temp],
// unsupported printType ts2fable.Syntax.FsType.TODO:
// unsupported printType ts2fable.Syntax.FsType.TODO:
module rec AzTracing
open System
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>
type Symbol = obj

let [<Import("context","temp")>] context: ContextAPI = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>Creates a function that can be used to create spans using the global tracer.
    ///
    /// Usage:
    ///
    /// ```typescript
    /// // once
    /// const createSpan = createSpanFunction({ packagePrefix: "Azure.Data.AppConfiguration", namespace: "Microsoft.AppConfiguration" });
    ///
    /// // in each operation
    /// const span = createSpan("deleteConfigurationSetting", operationOptions);
    ///     // code...
    /// span.end();
    /// ```</summary>
    /// <param name="args">- allows configuration of the prefix for each span as well as the az.module field.</param>
    abstract createSpanFunction: args: CreateSpanFunctionArgs -> (string -> 'T option -> IExportsCreateSpanFunction<'T>)
    /// Generates a `SpanContext` given a `traceparent` header value.
    abstract extractSpanContextFromTraceParentHeader: traceParentHeader: string -> SpanContext option
    /// <summary>Return the span if one exists</summary>
    /// <param name="context">- context to get span from</param>
    abstract getSpan: context: Context -> Span option
    /// <summary>Get the span context of the span if it exists.</summary>
    /// <param name="context">- context to get values from</param>
    abstract getSpanContext: context: Context -> SpanContext option
    /// <summary>Generates a `traceparent` value given a span context.</summary>
    /// <param name="spanContext">- Contains context for a specific span.</param>
    abstract getTraceParentHeader: spanContext: SpanContext -> string option
    /// Retrieves a tracer from the global tracer provider.
    abstract getTracer: unit -> Tracer
    /// Retrieves a tracer from the global tracer provider.
    abstract getTracer: name: string * ?version: string -> Tracer
    /// <summary>Returns true of the given {@link SpanContext} is valid.
    /// A valid {@link SpanContext} is one which has a valid trace ID and span ID as per the spec.</summary>
    /// <param name="context">- the {@link SpanContext} to validate.</param>
    abstract isSpanContextValid: context: SpanContext -> bool
    /// <summary>Set the span on a context</summary>
    /// <param name="context">- context to use as parent</param>
    /// <param name="span">- span to set active</param>
    abstract setSpan: context: Context * span: Span -> Context
    /// <summary>Wrap span context in a NoopSpan and set as span in a new
    /// context</summary>
    /// <param name="context">- context to set active span on</param>
    /// <param name="spanContext">- span context to be wrapped</param>
    abstract setSpanContext: context: Context * spanContext: SpanContext -> Context

/// OpenTelemetry compatible interface for Context
type [<AllowNullLiteral>] Context =
    /// <summary>Get a value from the context.</summary>
    /// <param name="key">- key which identifies a context value</param>
    abstract getValue: key: Symbol -> obj
    /// <summary>Create a new context which inherits from this context and has
    /// the given key set to the given value.</summary>
    /// <param name="key">- context key for which to set the value</param>
    /// <param name="value">- value to set for the given key</param>
    abstract setValue: key: Symbol * value: obj -> Context
    /// <summary>Return a new context which inherits from this context but does
    /// not contain a value for the given key.</summary>
    /// <param name="key">- context key for which to clear a value</param>
    abstract deleteValue: key: Symbol -> Context

/// Singleton object which represents the entry point to the OpenTelemetry Context API
type [<AllowNullLiteral>] ContextAPI =
    /// Get the currently active context
    abstract active: unit -> Context

/// Arguments for `createSpanFunction` that allow you to specify the
/// prefix for each created span as well as the `az.namespace` attribute.
type [<AllowNullLiteral>] CreateSpanFunctionArgs =
    /// Package name prefix.
    ///
    /// NOTE: if this is empty no prefix will be applied to created Span names.
    abstract packagePrefix: string with get, set
    /// Service namespace
    ///
    /// NOTE: if this is empty no `az.namespace` attribute will be added to created Spans.
    abstract ``namespace``: string with get, set

type Exception =
    U4<ExceptionWithCode, ExceptionWithMessage, ExceptionWithName, string>

/// An Exception with a code.
type [<AllowNullLiteral>] ExceptionWithCode =
    /// The code.
    abstract code: U2<string, float> with get, set
    /// The name.
    abstract name: string option with get, set
    /// The message.
    abstract message: string option with get, set
    /// The stack.
    abstract stack: string option with get, set

/// An Exception with a message.
type [<AllowNullLiteral>] ExceptionWithMessage =
    /// The code.
    abstract code: U2<string, float> option with get, set
    /// The message.
    abstract message: string with get, set
    /// The name.
    abstract name: string option with get, set
    /// The stack.
    abstract stack: string option with get, set

/// An Exception with a name.
type [<AllowNullLiteral>] ExceptionWithName =
    /// The code.
    abstract code: U2<string, float> option with get, set
    /// The message.
    abstract message: string option with get, set
    /// The name.
    abstract name: string with get, set
    /// The stack.
    abstract stack: string option with get, set

type HrTime =
    float * float

/// Used to specify a span that is linked to another.
type [<AllowNullLiteral>] Link =
    /// The {@link SpanContext} of a linked span.
    abstract context: SpanContext with get, set
    /// A set of {@link SpanAttributes} on the link.
    abstract attributes: SpanAttributes option with get, set

/// Tracing options to set on an operation.
type [<AllowNullLiteral>] OperationTracingOptions =
    /// OpenTelemetry SpanOptions used to create a span when tracing is enabled.
    abstract spanOptions: SpanOptions option with get, set
    /// OpenTelemetry context to use for created Spans.
    abstract tracingContext: Context option with get, set

/// An interface that represents a span. A span represents a single operation
/// within a trace. Examples of span might include remote procedure calls or a
/// in-process function calls to sub-components. A Trace has a single, top-level
/// "root" Span that in turn may have zero or more child Spans, which in turn
/// may have children.
///
/// Spans are created by the {@link Tracer.startSpan} method.
type [<AllowNullLiteral>] Span =
    /// Returns the {@link SpanContext} object associated with this Span.
    ///
    /// Get an immutable, serializable identifier for this span that can be used
    /// to create new child spans. Returned SpanContext is usable even after the
    /// span ends.
    abstract spanContext: unit -> SpanContext
    /// <summary>Sets an attribute to the span.
    ///
    /// Sets a single Attribute with the key and value passed as arguments.</summary>
    /// <param name="key">- the key for this attribute.</param>
    /// <param name="value">- the value for this attribute. Setting a value null or
    /// undefined is invalid and will result in undefined behavior.</param>
    abstract setAttribute: key: string * value: SpanAttributeValue -> Span
    /// <summary>Sets attributes to the span.</summary>
    /// <param name="attributes">- the attributes that will be added.
    /// null or undefined attribute values
    /// are invalid and will result in undefined behavior.</param>
    abstract setAttributes: attributes: SpanAttributes -> Span
    /// <summary>Adds an event to the Span.</summary>
    /// <param name="name">- the name of the event.</param>
    /// <param name="attributesOrStartTime">-  the attributes that will be added; these are
    /// associated with this event. Can be also a start time
    /// if type is TimeInput and 3rd param is undefined</param>
    /// <param name="startTime">- start time of the event.</param>
    abstract addEvent: name: string * ?attributesOrStartTime: U2<SpanAttributes, TimeInput> * ?startTime: TimeInput -> Span
    /// <summary>Sets a status to the span. If used, this will override the default Span
    /// status. Default is {@link SpanStatusCode.UNSET}. SetStatus overrides the value
    /// of previous calls to SetStatus on the Span.</summary>
    /// <param name="status">- the SpanStatus to set.</param>
    abstract setStatus: status: SpanStatus -> Span
    /// <summary>Marks the end of Span execution.
    ///
    /// Call to End of a Span MUST not have any effects on child spans. Those may
    /// still be running and can be ended later.
    ///
    /// Do not return `this`. The Span generally should not be used after it
    /// is ended so chaining is not desired in this context.</summary>
    /// <param name="endTime">- the time to set as Span's end time. If not provided,
    /// use the current time as the span's end time.</param>
    abstract ``end``: ?endTime: TimeInput -> unit
    /// Returns the flag whether this span will be recorded.
    abstract isRecording: unit -> bool
    /// <summary>Sets exception as a span event</summary>
    /// <param name="exception">- the exception the only accepted values are string or Error</param>
    /// <param name="time">- the time to set as Span's event time. If not provided,
    /// use the current time.</param>
    abstract recordException: ``exception``: Exception * ?time: TimeInput -> unit
    /// <summary>Updates the Span name.
    ///
    /// This will override the name provided via {@link Tracer.startSpan}.
    ///
    /// Upon this update, any sampling behavior based on Span name will depend on
    /// the implementation.</summary>
    /// <param name="name">- the Span name.</param>
    abstract updateName: name: string -> Span

/// Attributes for a Span.
type [<AllowNullLiteral>] SpanAttributes =
    /// Attributes for a Span.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: attributeKey: string -> SpanAttributeValue option with get, set

type SpanAttributeValue =
    U6<string, float, bool, Array<string option>, Array<float option>, Array<bool option>>

/// A light interface that tries to be structurally compatible with OpenTelemetry
type [<AllowNullLiteral>] SpanContext =
    /// UUID of a trace.
    abstract traceId: string with get, set
    /// UUID of a Span.
    abstract spanId: string with get, set
    /// https://www.w3.org/TR/trace-context/#trace-flags
    abstract traceFlags: float with get, set
    /// Tracing-system-specific info to propagate.
    ///
    /// The tracestate field value is a `list` as defined below. The `list` is a
    /// series of `list-members` separated by commas `,`, and a list-member is a
    /// key/value pair separated by an equals sign `=`. Spaces and horizontal tabs
    /// surrounding `list-members` are ignored. There can be a maximum of 32
    /// `list-members` in a `list`.
    /// More Info: https://www.w3.org/TR/trace-context/#tracestate-field
    ///
    /// Examples:
    ///      Single tracing system (generic format):
    ///          tracestate: rojo=00f067aa0ba902b7
    ///      Multiple tracing systems (with different formatting):
    ///          tracestate: rojo=00f067aa0ba902b7,congo=t61rcWkgMzE
    abstract traceState: TraceState option with get, set

type [<RequireQualifiedAccess>] SpanKind =
    | INTERNAL = 0
    | SERVER = 1
    | CLIENT = 2
    | PRODUCER = 3
    | CONSUMER = 4

/// An interface that enables manual propagation of Spans
type [<AllowNullLiteral>] SpanOptions =
    /// Attributes to set on the Span
    abstract attributes: SpanAttributes option with get, set
    /// {@link Link}s span to other spans
    abstract links: ResizeArray<Link> option with get, set
    /// The type of Span. Default to SpanKind.INTERNAL
    abstract kind: SpanKind option with get, set
    /// A manually specified start time for the created `Span` object.
    abstract startTime: TimeInput option with get, set

/// The status for a span.
type [<AllowNullLiteral>] SpanStatus =
    /// The status code of this message.
    abstract code: SpanStatusCode with get, set
    /// A developer-facing error message.
    abstract message: string option with get, set

type [<RequireQualifiedAccess>] SpanStatusCode =
    | UNSET = 0
    | OK = 1
    | ERROR = 2

type TimeInput =
    U3<HrTime, float, DateTime>

type [<RequireQualifiedAccess>] TraceFlags =
    | NONE = 0
    | SAMPLED = 1

/// A Tracer.
type [<AllowNullLiteral>] Tracer =
    /// <summary>Starts a new {@link Span}. Start the span without setting it on context.
    ///
    /// This method does NOT modify the current Context.</summary>
    /// <param name="name">- The name of the span</param>
    /// <param name="options">- SpanOptions used for span creation</param>
    /// <param name="context">- Context to use to extract parent</param>
    abstract startSpan: name: string * ?options: SpanOptions * ?context: Context -> Span

/// TraceState.
type [<AllowNullLiteral>] TraceState =
    /// <summary>Create a new TraceState which inherits from this TraceState and has the
    /// given key set.
    /// The new entry will always be added in the front of the list of states.</summary>
    /// <param name="key">- key of the TraceState entry.</param>
    /// <param name="value">- value of the TraceState entry.</param>
    abstract set: key: string * value: string -> TraceState
    /// <summary>Return a new TraceState which inherits from this TraceState but does not
    /// contain the given key.</summary>
    /// <param name="key">- the key for the TraceState entry to be removed.</param>
    abstract unset: key: string -> TraceState
    /// <summary>Returns the value to which the specified key is mapped, or `undefined` if
    /// this map contains no mapping for the key.</summary>
    /// <param name="key">- with which the specified value is to be associated.</param>
    abstract get: key: string -> string option
    /// Serializes the TraceState to a `list` as defined below. The `list` is a
    /// series of `list-members` separated by commas `,`, and a list-member is a
    /// key/value pair separated by an equals sign `=`. Spaces and horizontal tabs
    /// surrounding `list-members` are ignored. There can be a maximum of 32
    /// `list-members` in a `list`.
    abstract serialize: unit -> string

type [<AllowNullLiteral>] IExportsCreateSpanFunction<'T> =
    abstract span: Span with get, set
    abstract updatedOptions: 'T with get, set

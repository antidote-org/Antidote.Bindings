// ts2fable 0.9.0
module rec moduleName
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types
open Feliz


type [<AllowNullLiteral>] IExports =
    abstract Dropzone: props: obj -> ReactElement
    abstract useDropzone: ?options: DropzoneOptions -> DropzoneState

type [<AllowNullLiteral>] DropzoneProps =
    inherit DropzoneOptions
    abstract children: state: DropzoneState -> ReactElement

type [<StringEnum>] [<RequireQualifiedAccess>] ErrorCode =
    | [<CompiledName("file-invalid-type")>] FileInvalidType
    | [<CompiledName("file-too-large")>] FileTooLarge
    | [<CompiledName("file-too-small")>] FileTooSmall
    | [<CompiledName("too-many-files")>] TooManyFiles

type [<AllowNullLiteral>] FileError =
    abstract message: string with get, set
    abstract code: U2<ErrorCode, string> with get, set

type [<AllowNullLiteral>] FileRejection =
    abstract file: File with get, set
    abstract errors: ResizeArray<FileError> with get, set

type [<AllowNullLiteral>] DropzoneOptions =
    interface end

// type DropEvent =
//     U4<React.DragEvent<HTMLElement>, React.ChangeEvent<HTMLInputElement>, DragEvent, Event>

type [<AllowNullLiteral>] DropzoneState =
    interface end

type [<AllowNullLiteral>] DropzoneRef =
    abstract ``open``: (unit -> unit) with get, set

// type [<AllowNullLiteral>] DropzoneRootProps =
//     inherit React.HTMLAttributes<HTMLElement>
//     abstract refKey: string option with get, set
//     [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

// type [<AllowNullLiteral>] DropzoneInputProps =
//     inherit React.InputHTMLAttributes<HTMLInputElement>
//     abstract refKey: string option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] PropTypes =
    | Multiple
    | OnDragEnter
    | OnDragOver
    | OnDragLeave

type [<AllowNullLiteral>] Accept =
    [<EmitIndexer>] abstract Item: key: string -> ResizeArray<string> with get, set

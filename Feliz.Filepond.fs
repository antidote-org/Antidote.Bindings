module Feliz.Filepond

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type IFilepondProperty = interface end

module Interop =
    let inline mkFilepondAttr (key: string) (value: obj) : IFilepondProperty = unbox (key, value)


importSideEffects "filepond/dist/filepond.css"
importSideEffects "filepond-plugin-image-preview/dist/filepond-plugin-image-preview.css"

module Plugins =
    let FilePondPluginImagePreview: obj = import "FilePondPluginImagePreview" "filepond-plugin-image-preview"
    // let FilePondPluginImageResize = import "filepond-plugin-image-resize" "filepond-plugin-image-resize"
    // let FilePondPluginImageCrop = import "filepond-plugin-image-crop" "filepond-plugin-image-crop"
    // let FilePondPluginImageTransform = import "filepond-plugin-image-transform" "filepond-plugin-image-transform"
    // let FilePondPluginImageEdit = import "filepond-plugin-image-edit" "filepond-plugin-image-edit"
    // let FilePondPluginImageExifOrientation = import "filepond-plugin-image-exif-orientation" "filepond-plugin-image-exif-orientation"
    // let FilePondPluginImageFilter = import "filepond-plugin-image-filter" "filepond-plugin-image-filter"
    // let FilePondPluginImageValidateSize = import "filepond-plugin-image-validate-size" "filepond-plugin-image-validate-size"
    // let FilePondPluginImageValidateType = import "filepond-plugin-image-validate-type" "filepond-plugin-image-validate-type"
    // let FilePondPluginImageTransformOutput = import "filepond-plugin-image-transform-output" "filepond-plugin-image-transform-output"
    // let FilePondPluginImagePreviewCanvas = import "filepond-plugin-image-preview-canvas" "filepond-plugin-image-preview-canvas"
    // let FilePondPluginImageExifOrientation = import "filepond-plugin-image-exif-orientation" "filepond-plugin-image-exif-orientation"
    // let FilePondPluginImageCrop = import "filepond-plugin-image-crop" "filepond-plugin-image-crop"
    // let FilePondPluginImageEdit = import "filepond-plugin-image-edit" "filepond-plugin-image-edit"
    // let FilePondPluginImageFilter = import "filepond-plugin-image-filter" "filepond-plugin-image-filter"
    // let FilePondPluginImagePreview = import "filepond-plugin-image-preview" "filepond-plugin-image-preview"
    // let FilePondPluginImagePreviewCanvas = import "filepond-plugin-image-preview-canvas" "filepond-plugin-image-preview-canvas"
    // let FilePondPluginImageResize = import "filepond-plugin-image-resize" "filepond-plugin-image-resize"
    // static member FilePond

[<Erase>]
type filepond =
    static member inline registerPlugin (obj) : unit = import "registerPlugin" "react-filepond"
    static member inline Filepond (props: IFilepondProperty list) =
        Interop.reactApi.createElement(import "Filepond" "react-filepond", createObj !!props)

[<Erase>]
type Filepond =
    static member inline files (value : obj) = Interop.mkFilepondAttr "files" value
    static member inline allowMultiple (value : bool) = Interop.mkFilepondAttr "valueallowMultiple" value
    static member inline maxFiles (value : int) = Interop.mkFilepondAttr "maxFiles" value
    static member inline server (value : string) = Interop.mkFilepondAttr "server" value
    static member inline oninit (value : unit -> unit ) = Interop.mkFilepondAttr "oninit" value
    static member inline onupdatefiles (value : unit -> unit ) = Interop.mkFilepondAttr "onupdatefiles" value
    static member inline ``ref`` (value : obj) = Interop.mkFilepondAttr "ref" value

filepond.registerPlugin (Plugins.FilePondPluginImagePreview)

// let a =
//     filepond.Filepond [
//         Filepond.allowMultiple true
//         Filepond.maxFiles 3
//         Filepond.server "http://localhost:5000/api/upload"
//         Filepond.oninit (fun () -> printfn "oninit")
//     ]

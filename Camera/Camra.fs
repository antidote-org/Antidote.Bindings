module rec Feliz.Capacitor

open Fable.Core.JsInterop
open Fable.Core
open Fable.Core.JS

[<ImportAll("./Camera.js")>]
let filesystem: Filesystem = jsNative

type Filesystem =
    abstract writeFile : path:string * data: string -> Promise<unit>

let writeFile ((path:string), (data: string)) =
    filesystem.writeFile(path,data)

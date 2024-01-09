module rec Feliz.MobileDetect

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
// ts2fable 0.8.0
module rec moduleName
open System
open Fable.Core
open Fable.Core.JS

type RegExp = System.Text.RegularExpressions.Regex

// import { isMobile } from 'mobile-device-detect';

[<Import("isMobile", "mobile-device-detect")>]
let isMobile: MobileDetect.IExports = jsNative

// let [<ImportAll("module")>] mobileDetect: MobileDetect.IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract MobileDetect: MobileDetectStatic

type [<AllowNullLiteral>] MobileDetect =
    abstract mobile: unit -> string option
    abstract phone: unit -> string option
    abstract tablet: unit -> string option
    abstract userAgent: unit -> string
    abstract userAgents: unit -> ResizeArray<string>
    abstract os: unit -> string
    abstract version: value: string -> float
    abstract versionStr: value: string -> string
    abstract is: key: string -> bool
    abstract ``match``: pattern: U2<string, RegExp> -> bool
    abstract isPhoneSized: ?maxPhoneWidth: float -> bool
    abstract mobileGrade: unit -> string

type [<AllowNullLiteral>] MobileDetectStatic =
    abstract version: string with get, set
    abstract isPhoneSized: ?maxPhoneWidth: float -> bool
    abstract _impl: MobileDetect.MobileDetectImpl with get, set
    [<EmitConstructor>] abstract Create: userAgent: string * ?maxPhoneWidth: float -> MobileDetect

module MobileDetect =

    type [<AllowNullLiteral>] MobileDetectRules =
        [<EmitIndexer>] abstract Item: key: string -> U2<string, RegExp> with get, set

    type [<AllowNullLiteral>] MobileDetectComplexRules =
        [<EmitIndexer>] abstract Item: key: string -> U4<string, RegExp, ResizeArray<string>, ResizeArray<RegExp>> with get, set

    type [<AllowNullLiteral>] MobileDetectImpl =
        abstract mobileDetectRules: MobileDetectImplMobileDetectRules with get, set
        abstract detectMobileBrowsers: {| fullPattern: RegExp; shortPattern: RegExp; tabletPattern: RegExp |} with get, set
        abstract FALLBACK_PHONE: string with get, set
        abstract FALLBACK_TABLET: string with get, set
        abstract FALLBACK_MOBILE: string with get, set
        abstract findMatch: rules: MobileDetectRules * userAgent: string -> string
        abstract findMatches: rules: MobileDetectRules * userAgent: string -> ResizeArray<string>
        abstract getVersionStr: propertyName: string * userAgent: string -> string
        abstract getVersion: propertyName: string * userAgent: string -> float
        abstract prepareVersionNo: version: string -> float
        abstract isMobileFallback: userAgent: string -> bool
        abstract isTabletFallback: userAgent: string -> bool
        abstract prepareDetectionCache: cache: Object * userAgent: string * ?maxPhoneWidth: float -> unit
        abstract mobileGrade: md: MobileDetect -> string
        abstract detectOS: userAgent: string -> string
        abstract getDeviceSmallerSide: unit -> float

    type [<AllowNullLiteral>] MobileDetectImplMobileDetectRules =
        abstract phones: MobileDetectRules with get, set
        abstract tablets: MobileDetectRules with get, set
        abstract oss: MobileDetectRules with get, set
        abstract uas: MobileDetectRules with get, set
        abstract props: MobileDetectComplexRules with get, set
        abstract utils: MobileDetectRules with get, set

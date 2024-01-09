// ts2fable 0.8.0
module rec Feliz.MobileDeviceDetect
open System
open Fable.Core
open Fable.Core.JS

[<Import("*", "mobile-device-detect")>]
let Detect: IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract isBrowser: bool
    abstract isMobile: bool
    abstract isTablet: bool
    abstract isSmartTV: bool
    abstract isConsole: bool
    abstract isWearable: bool
    abstract isMobileSafari: bool
    abstract isChromium: bool
    abstract isMobileOnly: bool
    abstract isAndroid: bool
    abstract isWinPhone: bool
    abstract isIOS: bool
    abstract isChrome: bool
    abstract isFirefox: bool
    abstract isSafari: bool
    abstract isOpera: bool
    abstract isIE: bool
    abstract isEdge: bool
    abstract isYandex: bool
    abstract isIOS13: bool
    abstract isIPad13: bool
    abstract isIPhone13: bool
    abstract isIPod13: bool
    abstract isElectron: bool
    abstract isEdgeChromium: bool
    abstract isLegacyEdge: bool
    abstract isWindows: bool
    abstract isMacOs: bool
    abstract osVersion: string
    abstract osName: string
    abstract fullBrowserVersion: string
    abstract browserVersion: string
    abstract browserName: string
    abstract mobileVendor: string
    abstract mobileModel: string
    abstract engineName: string
    abstract engineVersion: string
    abstract getUA: string
    abstract deviceType: string
    abstract deviceDetect: unit -> obj option

module Feliz.FullCalendar


open System
open Browser
open Feliz
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

// let t : obj = importAll "@fullcalendar/react/dist/vdom"
let FCR : obj = importDefault "@fullcalendar/react"
let dgp : obj = importDefault "@fullcalendar/daygrid"
let tgd : obj = importDefault "@fullcalendar/timegrid"
let lg: obj =  importDefault "@fullcalendar/list"
let ip : obj = importDefault "@fullcalendar/interaction"
let res : obj = importDefault "@fullcalendar/resource"
// let FC : obj = import "Calendar" "@fullcalendar/core" //importDefault "@fullcalendar/core"

[<Erase>]
type IDateClickInfo = {|
    date: DateTime
    allDay: bool
    jsEvent: obj
    view: obj // The current View Object.
|}

// [<Erase>]
// type IDateClickInfo = {|
//     date: Date //a Date for the clicked day/time.
//     dateStr: string //An ISO8601 string representation of the date. Will have a time zone offset according to the calendar’s timeZone like 2018-09-01T12:30:00-05:00. If clicked on an all-day cell, won’t have a time part nor a time zone part, like 2018-09-01.
//     allDay: bool
//     jsEvent: obj
// |}



// allDay
// true or false whether the click happened on an all-day cell.

// dayEl
// An HTML element that represents the whole-day that was clicked on.

// jsEvent
// The native JavaScript event with low-level information such as click coordinates.

// view
// The current View Object.

// resource
// If the current view is a resource-view, the Resource Object that owns this date. Must be using one of the resource plugins.

[<Erase>]
type FullCalendarProps =
    | Plugins of obj list
    | InitialView of string

let timesAvailable = ["09:00:00"; "10:00:00"; "11:00:00"; "14:00:00"; "15:00:00"]

[<Erase>]
type IFullCalendarProperty = interface end

[<Erase>]
type reactFullcalendar =
    static member inline fullCalendar (properties: #IFullCalendarProperty list) =
        Interop.reactApi.createElement(importDefault "@fullcalendar/react", createObj !!properties)

module Interop =
    let inline mkFullCalendarAttr (key: string) (value: obj) : IFullCalendarProperty = unbox (key, value)

[<Erase>]
type IEvent = {|
    ``id``: string
    title: string
    start: DateTime
    ``end``: DateTime
    // extendedProps: {| details: string; individual: string; clinician :string |}
    allDay: bool
    resourceId: string
|}

[<Erase>]
type IEventClickInfo = {|
    event: IEvent
|}

[<Erase>]
type IToolBarOptions = {|
    left: string
    center: string
    right: string
|}

[<Erase>]
type fullCalendar =
    static member inline ref (ref: IRefValue<Types.HTMLCanvasElement>) = Interop.mkFullCalendarAttr "ref" ref
    static member inline initialView (value : string) = Interop.mkFullCalendarAttr "initialView" value
    static member inline initialDate (value : DateTime) = Interop.mkFullCalendarAttr "initialDate" value
    static member inline plugins (plugins : obj list) = Interop.mkFullCalendarAttr "plugins" (ResizeArray plugins)
    static member inline editable (value : bool) = Interop.mkFullCalendarAttr "editable" value
    static member inline selectable (value : bool) = Interop.mkFullCalendarAttr "selectable" value
    // static member inline select (value : obj -> unit) = Interop.mkFullCalendarAttr "select" value
    static member inline dateClick (value : IDateClickInfo -> unit) = Interop.mkFullCalendarAttr "dateClick" value
    static member inline height (value : string) = Interop.mkFullCalendarAttr "height" value
    static member inline showNonCurrentDates (value : bool) = Interop.mkFullCalendarAttr "showNonCurrentDates" value
    static member inline events (value : ResizeArray<IEvent>) = Interop.mkFullCalendarAttr "events" value
    static member inline eventClick (value : IEventClickInfo -> unit) = Interop.mkFullCalendarAttr "eventClick" value
    static member inline headerToolbar (value : IToolBarOptions) = Interop.mkFullCalendarAttr "headerToolbar" value
    static member inline footerToolbar (value : IToolBarOptions) = Interop.mkFullCalendarAttr "footerToolbar" value
    static member inline validRange (value : obj ) = Interop.mkFullCalendarAttr "validRange" value
    static member inline eventContent (value : obj ) = Interop.mkFullCalendarAttr "eventContent" value
    static member inline dayCellContent (value : obj ) = Interop.mkFullCalendarAttr "dayCellContent" value
    static member inline schedulerLicenseKey (value : string ) = Interop.mkFullCalendarAttr "schedulerLicenseKey" value
    static member inline resources (value : obj ) = Interop.mkFullCalendarAttr "resources" value
    static member inline eventDrop (value : obj -> unit) = Interop.mkFullCalendarAttr "eventDrop" value

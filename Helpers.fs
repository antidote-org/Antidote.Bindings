module Helpers

open Fable.Core
open Fable.Core.JS
open System

let inline notIsNull (value : obj) = not (isNull value)

[<AutoOpen>]
module CookieStore =


    type [<AllowNullLiteral>] ICookie =
        abstract name: string
        abstract value: string
        abstract domain: string
        abstract path: string
        abstract expires: DateTime
        abstract secure: bool

    type [<AllowNullLiteral>] ICookieStore =
        // The delete() method deletes a cookie with the given name or options object, it returns a Promise that resolves when the deletion completes.
        abstract delete: string -> unit

        // The get() method gets a single cookie with the given name or options object, it returns a Promise that resolves with details of a single cookie.
        abstract get: string -> Promise<ICookie>

        // The getAll() method gets all matching cookies, it returns a Promise that resolves with a list of cookies.
        abstract getAll : obj

        // The set() method sets a cookie with the given name and value or options object, it returns a Promise that resolves when the cookie is set.
        abstract set: string * string -> unit

    let [<Global>] cookieStore: ICookieStore = jsNative

module Cookies =

    [<RequireQualifiedAccess>]
    type Key =
        | Auth
        | AcsRestoreCallWithChat

    let keyToString (key:Key) =
        match key with
        | Key.Auth -> "auth"
        | Key.AcsRestoreCallWithChat -> "acs_restore_call_with_chat"

    let delete (key:Key) = cookieStore.delete (keyToString key)
    let set (key:Key) value = cookieStore.set (keyToString key, value)
    let tryGet (key:Key) = CookieStore.cookieStore.get(keyToString key)

module LocalStorage =
    open Browser.WebStorage

    let cleanState() =
        localStorage.removeItem "member_current_activity"
        localStorage.removeItem "member_selected_user_id"
        localStorage.removeItem "member_form_composer_json_spec"

    [<RequireQualifiedAccess>]
    type Key =
    | AppLanguage
    | AppThemeMode
    | AppVersion
    | ShowReleaseNotes
    | Auth
    | Calendar
    | MemberCurrentActivity
    | MemberSelectedUserId
    | MemberFormCompoaserJsonSpec

    // MEMBERS ACTIVITY FLOWS
    // | Members // no props
    // | MemberSignUpActivity // no props
    // | MembersAccountSelectedActivity // userAccount
    // | MembersScheduleEventActivity // currentUserAccount; patientUserAccount
    // | MembersFormComposeActivity // formSpecJson (?)
    // | MembersHandoutMode //




        member this.toString =
            match this with
            | Key.AppLanguage -> "app_language"
            | Key.AppThemeMode -> "app_theme_mode"
            | Key.AppVersion -> "app_version"
            | Key.ShowReleaseNotes -> "show_release_notes"
            | Key.Auth -> "auth"
            | Key.Calendar -> "calendar"
            | Key.MemberCurrentActivity -> "member_current_activity"
            | Key.MemberSelectedUserId -> "member_selected_user_id"
            | Key.MemberFormCompoaserJsonSpec -> "member_form_composer_json_spec"

    let getItem (key:Key) = localStorage.getItem key.toString
    let removeItem (key:Key) = localStorage.removeItem (key.toString)
    let setItem (key:Key) (data: string) =
        localStorage.setItem(key.toString, data)

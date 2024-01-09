module Feliz.ReactRouterUseLocationState

open Fable.Core
open Fable.Core.JsInterop
open Feliz.ReactRouterDom


// import { useSearchParams } from "react-router-dom";

// export function useSearchParamsState(searchParamName: string,defaultValue: string): readonly [searchParamsState: string, setSearchParamsState: (newState: string) => void] {
//     const [searchParams, setSearchParams] = useSearchParams();

//     const acquiredSearchParam = searchParams.get(searchParamName);
//     const searchParamsState = acquiredSearchParam ?? defaultValue;

//     const setSearchParamsState = (newState: string) => {
//         const next = Object.assign(
//             {},
//             [...searchParams.entries()].reduce(
//                 (o, [key, value]) => ({ ...o, [key]: value }),
//                 {}
//             ),
//             { [searchParamName]: newState }
//         );
//         setSearchParams(next);
//     };
//     return [searchParamsState, setSearchParamsState];
// }



// type useSearchParams = React_router_dom.useSearchParams
[<ReactComponent>]
let useSearchParamsState : (string * string) -> string * (string -> unit) = importDefault "./Feliz.ReactRouterUseLocationState.ts"

// [<Import("useLocationState", "react-router-use-location-state")>]
// let useLocationState: unit -> (string * string) = jsNative

// https://github.com/xiel/use-location-state
// [<Import("useQueryState", "react-router-use-location-state")>]
// let useQueryState: (string * string) -> string * (string -> unit) = jsNative

// let useSearchParamsState1 (searchParamName: string, defaultValue: string) =
//     let searchParamsState, setSearchParamsState = useQueryState (searchParamName, defaultValue)
//     searchParamsState, setSearchParamsState


// let l = Browser.Dom.window.location
// let s = l.search

// type URLSearchParams =
//     abstract size: int
//     abstract append: string * string -> unit
//     abstract delete: string * string option -> unit
//     abstract get: string -> string option
//     abstract getAll: string -> string array
//     abstract has: string * string option -> bool
//     abstract set: string * string -> unit
//     abstract sort: unit -> unit
//     abstract toString: unit -> string
//     abstract forEach: (string * string -> unit) -> unit
//     // forEach(callbackfn: (value: string, key: string, parent: URLSearchParams) => void, thisArg?: any): void;


// type SearchParamsState = string * (string -> unit)
// let useSearchParamsState (searchParamName: string) (defaultValue: string) : SearchParamsState =
//     let searchParams = new Dictionary<string, string>()
//     let acquiredSearchParam =
//         match searchParams.TryGetValue(searchParamName) with
//         | true, value -> value
//         | _ -> defaultValue

//     let setSearchParamsState (newState: string) =
//         let updatedParams = new Dictionary<string, string>(searchParams)
//         updatedParams.[searchParamName] <- newState
//         // Perform operation to update searchParams (it can be a mutation or update in the context)
//         // For example, updating a global context or performing another operation based on your needs
//         // This example shows how the searchParams dictionary could be updated, but actual usage might vary
//         // For instance, updating browser search params would require different handling
//         // For demonstration purposes, this code doesn't actually modify the searchParams dictionary
//         ()

//     (acquiredSearchParam, setSearchParamsState)

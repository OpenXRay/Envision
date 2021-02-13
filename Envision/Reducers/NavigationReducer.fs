namespace Envision.Reducers

open Envision.Common.State
open Envision.Constants
open Envision.Constants.MessageType

module NavigationReducer = 
    let update (message: Navigation) (state: GlobalState): GlobalState = 
        match message with
        | Main -> { state with CurrentPage = PageType.Main }
        | Versions -> { state with CurrentPage = PageType.Settings }
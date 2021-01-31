namespace Envision.Common

open Envision.Constants.MessageType

module Reducer = 
    let update (message: Navigation) (state: State.GlobalState): State.GlobalState = 
        match message with
        | Main -> { state with CurrentPage = "Home" }
        | Versions -> { state with CurrentPage = "Versions" }
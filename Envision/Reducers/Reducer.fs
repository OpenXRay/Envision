namespace Envision.Reducers

open Envision.Common
open Envision.Constants.MessageType

module Reducer = 
    let update (message: Actions) (state: State.GlobalState): State.GlobalState = 
        match message with
        | NavigationAction action -> NavigationReducer.update action state
        | Increment -> CommonReducer.update state
namespace Envision.Reducers

open Envision.Common.State

module CommonReducer = 
    let update (state: GlobalState): GlobalState = 
        { state with Counter = state.Counter + 1 }

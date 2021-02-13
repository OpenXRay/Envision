namespace Envision.Common

open Envision.Constants

module State =
    type GlobalState = {
        CurrentPage: PageType.Page
        Counter: int
    }

    let init() = {
        CurrentPage = PageType.Main
        Counter = 0
    }
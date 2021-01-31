namespace Envision.Common

module State =
    type GlobalState = {
        CurrentPage: string
    }

    let init() = {
        CurrentPage = "Home"
    }
namespace Envision.Controls

open Avalonia.Controls
open Avalonia.FuncUI.DSL
open Envision.Constants.MessageType

module MenuControl =
    let createMenuItem (text:string) onClick = 
        MenuItem.create [
            MenuItem.header text
            MenuItem.onClick onClick
        ]

    let view (dispatch: Actions -> unit) =
        Menu.create[
            Grid.row 0

            Menu.viewItems[
                createMenuItem "Main" (fun _ -> Navigation.Main |> NavigationAction |> dispatch)
                createMenuItem "Versions" (fun _ -> Navigation.Versions |> NavigationAction |> dispatch)
            ]
        ]
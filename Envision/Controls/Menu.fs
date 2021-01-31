namespace Envision.Controls

open Avalonia.Controls
open Avalonia.FuncUI.DSL
open Envision.Constants

module MenuControl =
    let createMenuItem (text:string) onClick = 
        MenuItem.create [
            MenuItem.header text
            MenuItem.onClick onClick
        ]

    let view dispatch =
        Menu.create[
            Grid.row 0

            Menu.viewItems[
                createMenuItem "Main" (fun _ -> dispatch MessageType.Main)
                createMenuItem "Versions" (fun _ -> dispatch MessageType.Versions)
            ]
        ]
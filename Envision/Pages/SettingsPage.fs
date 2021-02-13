namespace Envision.Pages

open Avalonia.Controls
open Avalonia.Layout
open Avalonia.FuncUI.DSL
open Envision.Constants.MessageType

module SettingsPage = 
    let view dispatch = 
        StackPanel.create[
            Grid.row 1

            StackPanel.children[
                TextBlock.create [
                    TextBlock.horizontalAlignment HorizontalAlignment.Center
                    TextBlock.verticalAlignment VerticalAlignment.Center
                    TextBlock.text "Settings page"
                ]
                Button.create[
                    Button.content "Increment"
                    Button.onClick (fun _ -> dispatch Increment)
                ]
            ]
        ]
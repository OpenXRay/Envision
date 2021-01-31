namespace Envision.Pages

open Avalonia.Controls
open Avalonia.Layout
open Avalonia.FuncUI.DSL

module MainPage =
    let view state =
        TextBlock.create[
            Grid.row 1
            TextBlock.horizontalAlignment HorizontalAlignment.Center
            TextBlock.verticalAlignment VerticalAlignment.Center
            TextBlock.text state
        ]
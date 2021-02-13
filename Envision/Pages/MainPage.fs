namespace Envision.Pages

open Avalonia.Controls
open Avalonia.Layout
open Avalonia.FuncUI.DSL

module MainPage =
    let view (state: int) =
        Grid.create[
            Grid.row 1
            Grid.showGridLines true
            Grid.columnDefinitions "0.5*,0.5*"

            Grid.children[
                TextBlock.create[
                    Grid.column 0
                    TextBlock.horizontalAlignment HorizontalAlignment.Center
                    TextBlock.verticalAlignment VerticalAlignment.Center
                    TextBlock.text (string state)
                ]
                TextBlock.create[
                    Grid.column 1
                    TextBlock.horizontalAlignment HorizontalAlignment.Center
                    TextBlock.verticalAlignment VerticalAlignment.Center
                    TextBlock.text "Main Page"
                ]
            ]
        ]
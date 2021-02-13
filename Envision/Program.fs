namespace Envision

open Elmish
open Avalonia
open Avalonia.Controls
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.FuncUI
open Avalonia.FuncUI.DSL
open Avalonia.FuncUI.Elmish
open Avalonia.FuncUI.Components.Hosts
open Envision.Constants
open Envision.Common
open Envision.Controls
open Envision.Pages
open Envision.Reducers

type MainWindow() as this =
    inherit HostWindow()
    do
        base.Title <- "Envision"
        base.Width <- 600.0
        base.Height <- 400.0

        let view (state: State.GlobalState) (dispatch: MessageType.Actions -> unit) =
            Grid.create[
                Grid.showGridLines true
                Grid.rowDefinitions "Auto,*"

                Grid.children[
                    MenuControl.view dispatch
                    match state.CurrentPage with
                        | PageType.Main -> MainPage.view state.Counter
                        | PageType.Settings -> SettingsPage.view dispatch
                ]
            ]

        Elmish.Program.mkSimple State.init Reducer.update view
        |> Program.withHost this
        |> Program.run

type App() =
    inherit Application()

    override this.Initialize() =
        this.Styles.Load "avares://Avalonia.Themes.Default/DefaultTheme.xaml"
        this.Styles.Load "avares://Avalonia.Themes.Default/Accents/BaseDark.xaml"

    override this.OnFrameworkInitializationCompleted() =
        match this.ApplicationLifetime with
            | :? IClassicDesktopStyleApplicationLifetime as desktopLifeTime -> 
                desktopLifeTime.MainWindow <- MainWindow()
            | _ -> ()


module Program = 
    [<EntryPoint>]
    let main argv =
        AppBuilder
            .Configure<App>()
            .UsePlatformDetect()
            .UseSkia()
            .StartWithClassicDesktopLifetime(argv)

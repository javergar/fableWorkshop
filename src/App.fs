module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser
open Types
open App.State
open Global

importAll "../sass/main.sass"


open Fable.Helpers.React
open Fable.Helpers.React.Props

let menuItem label page currentPage =
    li
      [ ]
      [ a
          [ classList [ "is-active", page = currentPage ]
            Href (toHash page) ]
          [ str label ] ]

let menu currentPage =
  aside
    [ ClassName "menu" ]
    [ p
        [ ClassName "menu-label" ]
        [ str "Excersises" ]
      ul
        [ ClassName "menu-list" ]
        [ menuItem "Hello Fable" Home currentPage
          menuItem "Managing State" Counter currentPage
          menuItem "State machine" Light currentPage 
          menuItem "Tree view" TreeView currentPage ] ]

let root model dispatch =

  let pageHtml =
    function
    | Page.TreeView -> TreeView.View.root model.tree (TreeViewMsg >> dispatch)
    | Counter -> Counter.View.root model.counter (CounterMsg >> dispatch)
    | Home -> Home.View.root model.home (HomeMsg >> dispatch)
    | Light -> Light.View.root model.light (LightMsg >> dispatch)

  div
    []
    [ div
        [ ClassName "navbar-bg" ]
        [ div
            [ ClassName "container" ]
            [ Navbar.View.root ] ]
      div
        [ ClassName "section" ]
        [ div
            [ ClassName "container" ]
            [ div
                [ ClassName "columns" ]
                [ div
                    [ ClassName "column is-3" ]
                    [ menu model.currentPage ]
                  div
                    [ ClassName "column" ]
                    [ pageHtml model.currentPage ] ] ] ] ]

open Elmish.React
open Elmish.Debug

// App
Program.mkProgram init update root
|> Program.toNavigable (parseHash pageParser) urlUpdate
|> Program.withReact "elmish-app"
// |> Program.withDebugger
|> Program.run

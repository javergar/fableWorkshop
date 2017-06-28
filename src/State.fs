module App.State

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Import.Browser
open Global
open Types

let pageParser: Parser<Page->Page,Page> =
  oneOf [
    map TreeView (s "treeView")
    map Counter (s "counter")
    map Home (s "home")
    map Light (s "light")
  ]

let urlUpdate (result: Option<Page>) model =
  match result with
  | None ->
    console.error("Error parsing url")
    model,Navigation.modifyUrl (toHash model.currentPage)
  | Some page ->
      { model with currentPage = page }, []

let init result =
  let (counter, counterCmd) = Counter.State.init()
  let (home, homeCmd) = Home.State.init()
  let (light, lightCmd) = Light.State.init()
  let (tree, treeCmd) = TreeView.State.init()
  let (model, cmd) =
    urlUpdate result
      { currentPage = Home
        counter = counter
        home = home
        tree = tree
        light = light}
  model, Cmd.batch [ cmd
                     Cmd.map CounterMsg counterCmd
                     Cmd.map HomeMsg homeCmd
                     Cmd.map LightMsg lightCmd
                     Cmd.map TreeViewMsg treeCmd]

let update msg model =
  match msg with
  | CounterMsg msg ->
      let (counter, counterCmd) = Counter.State.update msg model.counter
      { model with counter = counter }, Cmd.map CounterMsg counterCmd
  | HomeMsg msg ->
      let (home, homeCmd) = Home.State.update msg model.home
      { model with home = home }, Cmd.map HomeMsg homeCmd
  | LightMsg msg ->    
      let (light, lightCmd) = Light.State.update msg model.light
      { model with light = light }, Cmd.map LightMsg lightCmd
  | TreeViewMsg msg ->      
      let (tree, treeCmd) = TreeView.State.update msg model.tree
      { model with tree = tree }, Cmd.map TreeViewMsg treeCmd
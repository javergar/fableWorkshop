module App.Types

open Global

type Msg =
  | CounterMsg of Counter.Types.Msg
  | HomeMsg of Home.Types.Msg
  | LightMsg of Light.Types.Msg
  | TreeViewMsg of TreeView.Types.Msg

type Model = {
    currentPage: Page
    counter: Counter.Types.Model
    home: Home.Types.Model
    light: Light.Types.Model
    tree: TreeView.Types.Model
  }

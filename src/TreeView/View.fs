module TreeView.View

    open Fable.Helpers.React
    open Fable.Helpers.React.Props
    open Types

    let rec drawTree dispatch =
      function x ->
                  li [] [str "Some value"]       

    let root model dispatch =
        div [ ClassName "box" ]
          [
          div [ ClassName "panel" ]
              [
                ul [ ClassName "treeview"  ]
                 [
                   drawTree dispatch model
                 ]
              ]
          ]                
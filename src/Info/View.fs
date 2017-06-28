module Info.View

open Fable.Helpers.React
open Fable.Helpers.React.Props

let root =
    div [ ClassName "box" ]
      [
      div [ ClassName "panel" ]
          [
            ul [ ClassName "treeview"  ]
             [
              li [] [
                      i [ClassName "tree-indicator fa fa-folder-o"] []
                      str "Sales"
                    ]
              li [] [
                      i [ClassName "tree-indicator fa fa-folder-open-o"] []
                      str "Legal"
                      ul [] 
                       [
                         li [] [str "Bidders"]
                         li [] [str "Views"]
                         li [] [str "Logins"]
                       ]
                    ]
              li []
               [
                i [ClassName "tree-indicator fa fa-folder-open-o"] []
                str "Marketig"
               ] 
             ]
          ]
      ]
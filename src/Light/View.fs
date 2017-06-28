module Light.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types

let stateStyle =
    function
        | On  ->  "fa fa-toggle-on"
        | Off ->  "fa fa-toggle-off"

let screenStyle =
    function
        | On  ->  "neon-on box"
        | Off ->  "neon-off box"

let stateText =
    function
        | On  ->  "on"
        | Off ->  "off"           

let root model dispatch =
  div [ ClassName "box" ]
    [
        div 
          [ ClassName (screenStyle model) ]
          [
            str "Fable"
            
          ]
        label 
            [
              ClassName (stateStyle model)
              OnClick (fun _ -> FlipSwitch |> dispatch)
            ] 
            [
              str ("  Lights " + (stateText model))
            ]  
    ]  
    
module Counter.State

open Elmish
open Types

let init () : Model * Cmd<Msg> =
  0, []

// TODO: Update the model in the current update function
let update msg model =
  match msg with
  | Increment ->
      model, []
  | Decrement ->
      model, []

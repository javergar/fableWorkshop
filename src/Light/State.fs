module Light.State

    open Elmish
    open Types

//TODO: There is a bug in this code, find it and fix it
    let init () : Model * Cmd<Msg> =
      Off, []

    let transition = function
        | On  -> Off
        | Off -> Off

    let update msg model : Model * Cmd<Msg> =
      match FlipSwitch with
      | FlipSwitch -> transition model, []
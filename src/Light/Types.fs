module Light.Types

    type SwitchState = On | Off
    
    type Model = SwitchState

    type Msg =
      | FlipSwitch
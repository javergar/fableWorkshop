module Navbar.View

open Fable.Helpers.React
open Fable.Helpers.React.Props

let navButton classy href faClass txt =
  a
    [ ClassName (sprintf "button %s" classy)
      Href href ]
    [ span
        [ ClassName "icon" ]
        [ i
            [ ClassName (sprintf "fa %s" faClass) ]
            [ ] ]
      span
        [ ]
        [ str txt ] ]

let navButtons =
  span
    [ ClassName "nav-item" ]
    [ ]

let root =
  nav
    [ ClassName "nav" ]
    [ div
        [ ClassName "nav-left" ]
        [ h1
            [ ClassName "nav-item is-brand title is-4" ]
            [ str "Fable Workshop" ] ]
      navButtons ]

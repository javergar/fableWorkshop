module Global

type Page =
  | Home
  | Counter
  | TreeView
  | Light

let toHash page =
  match page with
  | TreeView -> "#treeView"
  | Counter -> "#counter"
  | Home -> "#home"
  | Light -> "#light"

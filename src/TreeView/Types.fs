module TreeView.Types

    type BranchState = Open | Close

    type Kind = File | Folder of BranchState

    type 'a Node = { kind: Kind; value: 'a } 
    type 'a Tree = { branch: 'a; tree: 'a Tree list  }

    let rec map f =
        function
             | { branch = branch ; tree = tree } as node -> 
                    { branch = f branch; tree = List.map (fun x -> map f x) tree }

    
    type Model = string Node Tree

    type Msg =
      | ChangeFolderState of string
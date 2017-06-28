module TreeView.State

    open Types
    open Elmish
    open System


    let treeView = { 
                    branch = { value = "root"; kind  = Folder Open }
                    tree  = [{ 
                                branch = { value = "bin"; kind  = Folder Open }    
                                tree  = [
                                            { 
                                                branch = { value = "bash"; kind  = File }
                                                tree  = []  
                                            };
                                            { 
                                                branch = { value = "cat"; kind = File }
                                                tree  = []  
                                            };
                                            { 
                                                branch = { value = "chmod"; kind = File }
                                                tree  = []  
                                            }
                                        ]  
                            };
                            {   
                                branch = { value = "var"; kind  = Folder Close }
                                tree  = [
                                          { 
                                            branch = { value = "msg"; kind  = Folder Close }
                                            tree  = []  
                                          };
                                          {
                                            branch = { value = "tmp"; kind  = Folder Close }
                                            tree  = []  
                                          };
                                          { 
                                            branch = { value = "lib"; kind = Folder Open}
                                            tree  = []  
                                          }
                                        ]  
                            }   
                           ] 
                }

    let init () : Model * Cmd<Msg> =
      treeView, []

    let transition nodeName = function
        | { kind = Folder Open; value = value } when value = nodeName  -> raise (NotImplementedException "Not ready")
        | { kind = Folder Close; value = value } when value = nodeName -> raise (NotImplementedException "Not ready")
        | node  -> node

    let update msg model : Model * Cmd<Msg> =
      match msg with
      | ChangeFolderState name -> Types.map (transition name) model, []

## prerequisites

- Install .net core: https://www.microsoft.com/net/core
- Install yarn: https://yarnpkg.com/lang/en/docs/install/
- Install fable .net core fable-elmish template: dotnet new -i "Fable.Template.Elmish.React::*"

## Build and running the app

1. Install npm dependencies: `yarn install`
2. Install dotnet dependencies: `dotnet restore`
3. Start Fable server and Webpack dev server: `dotnet fable npm-run start`
4. In your browser, open: [http://localhost:8080/](http://localhost:8080/)

Any modification you do to the F# code will be reflected in the web page after saving.


## Workshop

Under code there are different folders that represent a code challenge:

- In the "Counter" folder define a Reset button in the view, and modify the model and state
  accordingly

-  In the "Light" folder there is a bug in the modeling of the state, fix it please.

- In the "TreeView" folder implement the view to render the tree, and finish the state 
  transition function.

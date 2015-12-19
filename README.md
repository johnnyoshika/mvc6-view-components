### ASP.NET MVC6 and View Components in a separate assembly

Demonstrates how you can:
* Use MVC6 with View Components defined in a separate assembly.
* Use MVC6 with Controllers and Views defined in a separate assembly

To run this project:
* Clone this repo.
* Open `Demo.sln`.
* The `Web` project references `CompositeFileProvider` and `EmbeddedFileProvider`, which are both new.  To load these packages, add the `aspnetvnext` Nuget feed. Description on how to do this is here: http://stackoverflow.com/a/34360726/188740
* Run the `Web` project.
* The default home page will render a view component in the `Web` project and `BookStore.Components` assembly.
* The `/books` page will render the controller and view in the `BookStore.Portal` assembly.

Related StackOverflow answers:
* http://stackoverflow.com/a/34360726/188740
* http://stackoverflow.com/a/34366119/188740
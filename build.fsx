// include Fake lib
#r @"tools\FAKE\tools\FakeLib.dll"
open Fake
 
RestorePackages()

// Properties
let buildDir = @".\build\"
let testDir  = @".\test\"
let packagesDir = @".\packages"
let packagingRoot = "./packaging/"
let packagesVersion = "1.0.0.3"

// Targets
Target "Clean" (fun _ ->
    CleanDirs [buildDir; testDir; packagingRoot]
)

Target "Build" (fun _ ->
    !! @"FOAASClient\FOAASClient.csproj"
      |> MSBuildRelease buildDir "Build"
      |> Log "AppBuild-Output: "
)

Target "CreateNugetPackage" (fun _ ->    
    NuGet (fun p -> 
        {p with                  
            Project = "FOAASClient"          
            OutputPath = packagingRoot
            WorkingDir = buildDir
            Version = packagesVersion
            Dependencies =
                ["Newtonsoft.Json", GetPackageVersion "./packages/" "Newtonsoft.Json"
                 "Microsoft.Net.Http", GetPackageVersion "./packages/" "Microsoft.Net.Http"]
            Publish = true
            }) "FOAASClient.nuspec"
)

Target "Default" (fun _ ->
    trace "Build completed"
)

// Dependencies
"Clean"  
  ==> "Build"
  ==> "CreateNugetPackage"
  ==> "Default"
 
// start build
Run "Default"
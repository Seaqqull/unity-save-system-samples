# About Save-System Samples package (`com.seaqqull.save-system.samples`)

## Package contents

The following table describes the package folder structure:

| **Location**           | **Description**                                                         |
| ---------------------- | ----------------------------------------------------------------------- |
| _Documentation~_       | Contains the documentation for the Unity package.                       |
| _Runtime_              | Contains core C# APIs for integrating Save-System into your Unity scene.|

<a name="Installation"></a>

## Installation

### Local Installation
You can [add the local](https://docs.unity3d.com/Manual/upm-ui-local.html)
`com.seaqqull.save-system.samples` package (from the repository that you just cloned) to your
project by:

1. Navigating to the menu `Window` -> `Package Manager`.
2. In the package manager window click on the `+` button on the top left of the packages list.
3. Select `Add package from disk...`
4. Navigate into the `com.seaqqull.save-system.samples` folder.
5. Select the `package.json` file.

### Github via Package Manager
1. Navigate to the menu `Window` -> `Package Manager`.
2. In the package manager window click on the `+` button on the top left of the packages list.
3. Select `Add package from git URL...`
4. Enter "https://github.com/Seaqqull/unity-save-system-samples.git?path=/UnitySaveSystemSamples/Assets/com.seaqqull.save-system.samples".
5. Click `Add` button.

## Setup

Once the package has been successfully installed, it is required to perform certain steps in order to run it:
1. Navigate `File` -> `Build Settings...`.
2. Add into `Scenes In Build` scenes from the package in the given order (indexes):
    - 0: scn_base &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -> Located under path: `com.seaqqull.save-system.samples/Runtime/StaticAssets/Scenes/`
    - 1: scn_example_1 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -> Located under `com.seaqqull.save-system.samples/Runtime/StaticAssets/Scenes/Examples/01/`
    - 2: scn_example_2 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -> Located under `com.seaqqull.save-system.samples/Runtime/StaticAssets/Scenes/Examples/02/`
    - 3: scn_example_2_1 &nbsp; -> Located under `com.seaqqull.save-system.samples/Runtime/StaticAssets/Scenes/Examples/02/`
    - 4: scn_example_2_2 &nbsp; -> Located under `com.seaqqull.save-system.samples/Runtime/StaticAssets/Scenes/Examples/02/`
    - 5: scn_example_3 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -> Located under `com.seaqqull.save-system.samples/Runtime/StaticAssets/Scenes/Examples/03/`
3. Now you can run the samples.
    - Open the `scn_base` scene, and run it.
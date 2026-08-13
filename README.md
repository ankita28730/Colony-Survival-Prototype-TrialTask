# Colony Survival Prototype

Small Unity prototype created for a Unity Game Developer Intern trial task.

## Unity version

Unity 6000.4.8f1 (Unity 6)

## Implemented features

* Unity project initialized
* JSON configuration files stored in `Assets/Resources`
* Data-loading workflow implemented
* UI references configured in the Unity scene
* Git repository initialized with commit history
* Project script structure organized for future gameplay systems

## Configuration files

* `Assets/Resources/population.json`
* `Assets/Resources/consumption.json`

Example values are used for demonstration purposes.

## How to open the project

1. Open Unity Hub.
2. Add/open the `ColonySurvivalPrototype` folder.
3. Open the default scene in `Assets/Scenes`.

## How to run

Press **Play** in the Unity Editor.

## AI tools used

This prototype was developed with significant assistance from ChatGPT (OpenAI). AI support was used for discussing the overall project structure, designing the simulation workflow, generating and refining portions of the C# scripts, implementing JSON loading and UI update logic, troubleshooting Unity and Git/GitHub issues, and drafting supporting documentation.

I followed the guidance provided during development and integrated the suggested code and project structure within the Unity project. My role primarily involved setting up the project environment, creating and editing project assets and JSON data, configuring the Unity scene and UI, connecting references in the editor, testing the prototype, managing the repository, and preparing the final submission.

This note is included to provide clear and transparent disclosure regarding the extent of AI assistance used during the completion of the task.

## Decisions & trade-offs

* Used simple example values for population and consumption because the brief update allowed custom reasonable values.
* Focused on architecture and JSON configuration before adding gameplay systems.

## Demo video

Google Drive link: (https://drive.google.com/file/d/1EWbeqDXvguy_7h02YIbC8DlVCsDs_0U4/view?usp=drive_link)

## Unit test note

I implemented the colony simulation as a pure C# class (`ColonySimulation`) and attempted to configure an EditMode unit test in Unity 6.4. Due to a Unity Test Runner assembly configuration issue encountered near the submission deadline, I removed the incomplete test setup to keep the submitted project clean and fully runnable.

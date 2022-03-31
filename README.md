# shotmaker

The "QA Screenshot Maker" utility is intended for partial automation during software manual testing. It simplifies screenshots creating and their systematized saving according to a given scenario.

Parameters of each test case execution should be configured in the upper area of utility window. In order to configure them the user should press "Edit", and in order to start the execution with configured parameters - press "Apply".
- The parameter "Test Execution" sets a name of the current test case execution.
- The parameter "Test Case" sets a file containing a testing scenario.
- The parameter "Output folder" sets a directory in which the folders structure with screenshots will be placed.

A scenario is a xml-file containing:
- test case id and title;
- set of steps for preparation before testing and for testing itself.

During a test case execution the scenario is showed in the main area of the utility window. It has the form of tree, where screenshotable items are highlighted by the understriked font. That ones of them, that don't have a screenshot yet, are also highlighted by the red font. The text of the selected item and its parent is duplicated in two panels below the main area. The user can choose for the selected item one of the following actions:
- "Passed" (the screenshot is taken, both its name and text of the item are marked "Passed");
- "Failed" (the screenshot is taken, both its name and text of the item are marked "Failed");
- "Skipped" (text of the item is marked "Skipped").

The utility window automatically becomes invisible for a moment of the screenshot taking. According to the setting configured in the bottom left part of the window, the utility makes:
- the screenshot of the whole screen,
- or the screenshot of a specific window, selected by a mouse click.

The button "Show" is reserved for unimplemented functionality - displaying the current item screenshot.

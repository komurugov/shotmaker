# shotmaker
An internship assignment - a screenshot making tool for QA.

The "QA Screenshot Maker" utility is intended for partial automatization during software manual testing. It simplifies screenshots making and their systematic saving by a given scenario.

Parameters of each test case execution should be adjusted in the upper area of utility window. In order to adjust them the user should press "Edit", and in order to start the execution with adjusted parameters - press "Apply".
- The parameter "Test Execution" sets a name of the current test case execution.
- The parameter "Test Case" sets a file containing a testing scenario.
- The parameter "Output folder" sets a directory in which the folders structure with screenshots will be placed.

A scenario is a xml-file containing:
- test case id and title;
- set of steps for preparation before testing and for testing itself.

During a test case execution the scenario is showed in the main area of the utility window. It has the form of tree, where screenshotable items are highlighted by the understriked font. That ones of them, that don't have a screenshot yet, are highlighted by the red font. The text of the selected item and its parent is duplicated in two panels below the main area. The user can choose for the selected item one of the actions:
- "Passed" (the screenshot is taken, and both its name and text of the item gets the mark "Passed");
- "Failed" (the screenshot is taken, and both its name and text of the item gets the mark "Failed");
- "Skipped" (text of the item gets the mark "Skipped").

The utility window automatically becomes invisible for a moment of the screenshot taking. According to the setting adjusted in the bottom left part of utility window, the utility takes:
- the screenshot of the whole screen,
- or the screenshot of a specific window, selected by the mouse clicking.

The button "Show" is reserved for unimplemented functionality - displaying of the current item screenhot.

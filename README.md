PRTSC_TO_FILE
=============

LOOK AT THE "RAW" - I have no idea why GitHub is not using the new lines I have in the file.

Use
---
Press 'PRTSC' on your keyboard to save the screen to the directory specified!

How to Use
----------
On starting the application, you will see a window with:
1. A text field to put the field where the screen shot will be saved.
      Note: You must click the "Apply" button to make the directory this.
2. A drop down list of the possible image formats. Any format change takes place immediately.
3. A text field with an output file location - this is where the picture will be saved and in what format.
4. A drop down of possible output forms that screen shots will be saved in. Currently there are three options:
      a. Number - the image will be output as '<directory>\<num>.<image_format>' and you can specify at which
                  number to start at in the "Start count at" text field.
      b. Date/Time - the image will be output as 'M<month>D<day>Y<year>H<hour>Mi<minute>S<second>.<image_format>
      c. Custom - the image will be output as what is currently entered into the text field above
5. On the right are some options:
      a. Close on Exit - This closes the application when you press the "X" button if the checkbox is marked.
      					 Otherwise, the application will simply hide itself from view. See below for details.
      b. Start Hidden - This allows the program to start up hidden in the taskbar. The icon will still be
      					displayed so you can always right-click the icon and press "Show".
      c. Start count at - This is the value at which to start the count at for the "Number" format.
      
How to Close
------------
The application will continue to run in the background even if you close the window.
It can be completely exited by either right-clicking the system tray icon and clicking the "Exit" option or by
checking the "Close on Exit" option on the main window and then closing the application.
If you close the window and wish to bring it back up, simply right-click the system tray icon and then click "Show".

Binary
------
Inside the bin/Debug folder

TODO
----
0. Actually make it able to start hidden!!!!
1. Tray menu does not dissapear - make it!
2. More options on what to take a screen shot of:
      a. Current window
      b. Portion of window
      c. Full screen page (if scrolling needed)
3. Double click tray icon to show!
4. Start with Windows option
5. Other?

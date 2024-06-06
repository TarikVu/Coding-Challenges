# Threaded Timer Application 
### Author: [`Tarik Vu`](https://www.linkedin.com/in/tarik-vu-020043210/)

Submission Date: **2:30 pm (MST) 6/6/2024**<br>


```
Development Enviroment
- QT Creator
- QT 6.8.0
```

### Table of Contents
| Task                              | Estimated Time |Est. Actual Time |
|-----------------------------------|----------------|-----------------|
| 1. [Setup & Install](#setup)      | 10 mins        | **~60 mins***   |
| 2. [Making the UI](#UI)           | 15 mins        | 10 mins         |
| 3. [Implementing the Backend](#UI)| 30 mins        | 45 mins         |
| **Total**                         | 55 mins        | 1 hr 15 mins    |

- [What I learned](#summary)<br>
- [Resources 📚](#resources)

---
### <a name="setup"></a> 1. Setup & Install 

#### _Time Spent : ~30 Mins_

Installing QT & QT Creator
- **QT took alot longer than expected to download & install.** Version 6.8.0 was installed. The [open sourced version](https://www.qt.io/download-open-source) is utilized as it seems a regular install requires a company email address. 

Research
- This [documentation](https://doc.qt.io/qtvstools/qtvstools-tutorial-qt-widgets-application.html) was studied as QT was installing.

README.md
- Readme was setup for time tracking and will serve as s DevLog.  

---
### <a name="UI"></a> 2. Designing the UI
#### _Time Spent : ~10 Mins_
Following along with the [QT Widgets Tutorial](https://doc.qt.io/qtvstools/qtvstools-tutorial-qt-widgets-application.html) and using QT creator, a TextLabel and Start/Stop button has been added.  These items should be spaced and resize with the window accordingly.

---
### <a name="UI"></a> 3. Implementing the backend
#### _Time Spent : ~40 Mins_
- Reviewed c++ coding practices and syntax.
- Added a __handleClick()__ function to record the button presses.<br>
- Added an __updateTimerLabel()__ function to Update the front UI with a formatted time.

---
### <a name="summary"></a> What I learned

As this was the first time using the QT framework I learned that it is a useful tool for cross-platform developement with a very large library as seen on the [official documentation](https://doc.qt.io/qt-6/classes.html).

Using QT Creator I realized that there is also a very robust front end development toolkit for developers that aid in component organization, spacing, and more.  

Lastly, I found this to be a welcomed refresher on using c++ as c#, javascript, and python may be my primary languages but it is always good to practice other important languages. 

Thank you for taking your time to look at my submission for the **Application Software Intern position at IMSAR** I hope to hear from you soon Thomas!

---
### <a name="resources"></a> Resources 📚
- [QT All C++ Classes Documentation](https://doc.qt.io/qt-6/classes.html)
    - [QThread Class](https://doc.qt.io/qt-6/qthread.html)
    - [QTimer Class](https://doc.qt.io/qt-6/qtimer.html)

- [QT Widgets Tutorial](https://doc.qt.io/qtvstools/qtvstools-tutorial-qt-widgets-application.html)

- [QT Slots & Signals](https://doc.qt.io/qt-6/signalsandslots.html)
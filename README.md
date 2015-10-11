#Unity Editor for Mac menu bug

tested @ Unity 5.1.3p2 ~ Unity5.2.0p1

##Problem
Unexpected events will be emitted.


##How to reproduce
1. open some window.
2. click it once.(set focus to that window.)
3. Open Mac OS X's menu from menu bar item "Edit"
4. Close by click same item.
5. All events will be raised. It is maybe bug.

![SS](/Doc/scr1.png)

![SS](/Doc/scr2.png)

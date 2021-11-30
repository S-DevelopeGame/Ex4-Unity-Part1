# בניית עולם ואלגוריתמים בשני מימדים      

בחרנו בשלושת הסעיפים הבאים:

## א- מימוש אלגוריתם dijkstra
באלגוריתם זה השתמשנו בגרף ממושקל על מנת למצוא את המסלול הקל(המהיר) ביותר.
* [IWGraph](https://github.com/S-DevelopeGame/Ex4-Unity-Part1/blob/master/Assets/Scripts/New/Dijkstra/IWGraph.cs),
* [dijkstra algorithm](https://github.com/S-DevelopeGame/Ex4-Unity-Part1/blob/master/Assets/Scripts/New/Dijkstra/Dijkstra.cs).

## ג-שימוש באלגוריתם dijkstra על מנת לשנות את מהירות השחקן באריחים מסויימים
השתמשנו באלגוריתם מהסעיף הקודם על מנת לתת משקל שונה לכל tileBase וכאשר השחקן ילך על אריח מסויים הוא יהיה יותר מהיר או יותר איטי בהתאם למשקל,
כלומר אם המשקל באותו אריח גבוה כך השחקן ילך לאט יותר ולהיפך.
* [הגדרת המשקל](https://github.com/S-DevelopeGame/Ex4-Unity-Part1/blob/master/Assets/Scripts/New/Tile/WeightedTile.cs),
* [tileMapWGraph](https://github.com/S-DevelopeGame/Ex4-Unity-Part1/blob/master/Assets/Scripts/New/Tile/TilemapWGraph.cs),
* [allowedTiles](https://github.com/S-DevelopeGame/Ex4-Unity-Part1/blob/master/Assets/Scripts/New/Tile/AllowedTilesW.cs).

## ה- השחקן יכול לחצוב בהר ולהפוך אותו לדשא
נשתמש בעכבר על מנת להזיז את השחקן וכאשר נרצה לחצוב את ההר נלחץ על החצים לאיזה כיוון ולאח מכן על X.
* [תזוזת השחקן-keyboardMover](https://github.com/S-DevelopeGame/Ex4-Unity-Part1/blob/master/Assets/Scripts/New2/Player/KeyboardMover1.cs),
* [חציבת ההר-cut](https://github.com/S-DevelopeGame/Ex4-Unity-Part1/blob/master/Assets/Scripts/New2/Player/KeyboardMoverCut.cs).

לפני חציבת ההר:

![alt text](https://github.com/S-DevelopeGame/Ex4-Unity-Part1/blob/master/Assets/before.jpeg)

אחרי חציבת ההר:

![alt text](https://github.com/S-DevelopeGame/Ex4-Unity-Part1/blob/master/Assets/after.jpeg)

קישור למשחק : https://snir1551.itch.io/brea-the-mountain :)

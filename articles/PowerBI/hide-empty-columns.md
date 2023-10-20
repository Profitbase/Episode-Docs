You can now hide empty columns, while keep all custom columns visible.
_(available from v7.1)_



## Example where you want to hide a measure if not relevant:

1. One measure showing the selected period, and another showing the same value two years earlier. 
Based on the slicer, _Actuals_ show 2021, and _Actuals (-2y)_ shows 2019:
![image](https://user-images.githubusercontent.com/82056309/226608078-5c409d4b-0e99-4da2-979d-cb7760badfda.png)

2. If we chance the slicer to 2020, then _Actuals (-2Y)_ is set to 2018, for which we have no data, leaving it empty:
![image](https://user-images.githubusercontent.com/82056309/226608957-8d7872d7-36bb-4153-825f-4decd552fc16.png)

3. Turning on the option to Hide Empty Columns will hide these:
![image](https://user-images.githubusercontent.com/82056309/226609138-a8a38533-007e-4a44-95d0-4992b40f7002.png)


## Example where you want to always show custom columns:

1. Add a custom column after Company 1. The custom column is now _anchored_ to that the Company 1 column: 
![image](https://user-images.githubusercontent.com/82056309/226599053-7bca70ab-5291-4389-9ac4-9556269c7f95.png)

2. Set the slicer to 2019. Company 1 does not have any data for 2019, so both Company 1 and After Co1 disappears:
![image](https://user-images.githubusercontent.com/82056309/226604770-2939b666-8b26-4c68-8277-e973e08aa994.png)

3. Turn on "Show Items with no data" for the Column headers, and we see the empty columns:
![image](https://user-images.githubusercontent.com/82056309/226605320-db35bdc2-cbdf-4fe4-8b1b-3823aacba7c1.png)

4. Turn on the option Hide Empty Columns to hide them again.
![image](https://user-images.githubusercontent.com/82056309/226605617-05016386-a784-4529-809b-4763cd8a2f63.png)

5. Now you also have the option to always show Custom Columns, meaning After Co1 is visible, even when Company1 is gone:
![image](https://user-images.githubusercontent.com/82056309/226605683-b0bbc8b3-ad98-4710-b784-bbbecb8033bb.png)



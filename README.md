# Sorting Visualiser

A project I've always wanted to create is a visualisation of sorting algorithms ever since I saw it elsewhere on the internet.

With the release of .NET 6, I wanted to see how far the Blazor web framework has come along. And so I used this as an opportunity to create this sorting visualiser using the Blazor framework.

This project not only allows me to learn the basics of Blazor but also explore the various known/popular sorting algorithms.
```
$ dotnet run --project SortingVisualiser
```

![image]("./../quicksort.gif)
_Quick sort_


![image]("./../bubblesort.gif)
_Bubble sort_

---
##### Deploy to Heroku (note to self)

```
$ dotnet publish SortingVisualiser -c Release -o release
```

---
##### Prerequisites

- .NET 6

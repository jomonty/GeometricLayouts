# GeometricLayouts

## Summary
This project was created as part of a technical challenge, the counterpart frontend is available [here](https://github.com/jomonty/GeometricLayouts-Frontend) and the website is also [hosted](https://geometric-layouts-frontend.vercel.app). I decided to attempt to make the calculator agnostic of grid size, which had a few challenges but I enjoyed working through them and getting familiar with C#. 
<br>
<br>

## Built with
* .NET Core 6.0
  * Language: C#
  * Web Framework: ASP.NET Web API
  * Testing: xunit
<br>

## Getting started
### Prerequisites
* Visual Studio installed.

### Running the dev server
* Clone the repo
* Open solution 'GeometricLayouts'
* Run 'API' in debug mode

### To use
Available endpoints are 
   * localhost:5209/api/geometry/verticesbygridref
     * Request:
     
       ```json
       {
         "gridRef": "E7",
         "gridHeight": 60,
         "gridWidth": 60,
         "gridSquareSideLength": 10
       }
       ```
      * Response:
        ```json
        {
          "vertex1": {
            "x": 30,
            "y": 40
          },
          "vertex2": {
            "x": 40,
            "y": 50
          },
          "vertex3": {
            "x": 30,
            "y": 50
          },
         }
        ```
   * localhost:5209/api/geometry/gridrefbyvertices
     * Request:
     
       ```json
       {
         "vertex1": {
            "x": 30,
            "y": 40
          },
          "vertex2": {
            "x": 40,
            "y": 50
          },
          "vertex3": {
            "x": 30,
            "y": 50
          },
          "gridHeight": 60,
          "gridWidth": 60,
          "gridSquareSideLength": 10
       }
       ```
      * Response:
        ```json
        {
          "strRef": "E7",
          "row": "E",
          "col": 7
         }
        ```
Error messages will be produced by the endpoint if:
 * The gridSqareSideLength does not evenly divide into the supplied gridHeight and gridWidth
 * The gridRef supplied does not fit on the grid
 * The vertices supplied are not contained on the grid supplied
 * The vertices supplied are not evenly divisible by the gridSqareSideLength
 * The triangle formed by the vertices is not the correct size
 * The triangle formed by the vertices is not in the correct orientation
   
 
 
<br>

## Brief
- Calculate the triangle coordinates for an image with right triangles such that for a given row (A-F) and column (1-12) you can produce any of the triangles in the layout below.
<br>

![image](https://user-images.githubusercontent.com/100322748/233035467-5ba67792-da7d-4cfb-97a1-a471068f1801.png)

<br>
<br>
Each non-hypotenuse side of the triangle is as follows:
<br>
<br>

![image](https://user-images.githubusercontent.com/100322748/233035598-28858436-b6b3-4063-8420-0324e78599ad.png)

<br>
<br>
- Given the vertex coordinates, calculate the row and column for the triangle.
<br>
<br>

![image](https://user-images.githubusercontent.com/100322748/233035660-c544a303-4db2-4caf-b0d7-950aa0d6f665.png)

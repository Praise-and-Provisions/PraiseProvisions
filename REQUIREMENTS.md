# PROJECT SCOPE

### [PRAISE + PROVISIONS, A CURATED RESTAURANT APP](https://praiseprovisions.azurewebsites.net/) </br>
This project is a full stack web application using MVC and API with full CRUD (**C**reate, **R**ead, **U**pdate, **D**elete) operations. The projecT incudes a custum API and use of a third party API.</br>

## Dev Tools
.NET Core, Visual Studio Team Services now known as Azure DevOps
</br>

## Vision
_What is the vision of this product?_ </br>
The vision of this product is that as a user I want to search for top restaurant listings based on a city that I specify so that I can be informed on the best restaurants that that city has to offer. I want a curated experience that most applications haven't been able to deliver. As a user I want to be able to create a logn in, view results of my search and save restaurant recommendations to a list.  

_What painpoints does this product solve?_ </br>
As a user I want the curated experience to include celebrity chef and/or noteworthy culinary expert restaurant recommendations. I don't want to have to search multiple sites to compare and compile this information for my culinary adventures. 

### Scope
+ The web app will provide a place for the user to login
+ After the required login the user will be able to perform a search by city name
+ Results for the city will be display with curated results that include chef recommended restaurants will appear first followed by a list of other high rated restaurants that don't include curated chef recommendations
+ The user will have the ability to save restaurants of interest 

#### MVP
+ User search for restaurants by city name
+ User search results displayed
+ User saved results functionality
+ About Us
+ Login 

#### Next Steps
+ Login persistence 
+ Increased amount of curated chef recommended results by city
+ As a fully functioning application; combining with social media accounts such as Instagram/Facebook/Twitter for sharing interactions and lists with your circle
+ As a further developed appliction, PRAISE + PROVISIONS would have it's own Instagram, Facebook and Twitter page
+ As a further developed appliction, the ability for authentication for user profiles, allow users to update and delete their account
+ An admin page for ease of creating, editing, and deleting chef recommendations

### Data Flow
_Startup File_
* Explicit routing of MVC
* MVC dependency in ConfigureServices
* DBContext registered in ConfigureServices
* Use of static files accepted

### PLANNING PROCESS AND VISUALS
### PRAISE + PROVISIONS, A CURATED RESTAURANT APP - THE PLANNING PROCESS
#### The following visuals demonstrate the planning process of the web application page organization 
_Landing Page_ 
+ The original concept had the landing page as the search page

![landing_page](https://user-images.githubusercontent.com/39015829/48317163-0b7d6f80-e5a3-11e8-97b8-b9d066b5da11.PNG)

_Dashboard/Saved Results Page_ 

![mydash](https://user-images.githubusercontent.com/39015829/48317206-7d55b900-e5a3-11e8-8203-f8c06d0bb77a.PNG)

_Results Page First Draft_

+ The initial concept was to have the curated chef recommendations from a custom API separate from the third party results

![chefs page](https://user-images.githubusercontent.com/39015829/48317236-d0c80700-e5a3-11e8-968f-55f7a9a345cb.PNG)

_Revised Results Draft_

+ The revised concept would lead us to the final results which was a combined results page of our custum and third party API


![top_chefs](https://user-images.githubusercontent.com/39015829/48317252-1a185680-e5a4-11e8-9a37-61d0bf8e39da.PNG)

_About Us First Draft_

+ Initially our about us page was stacked with each of us having a descriptive summary. This was later revised to a group summary inclusive of a photo of our favorite dish.

![about us](https://user-images.githubusercontent.com/39015829/48317280-6b284a80-e5a4-11e8-8d34-0ba6289df48f.PNG) 

### VISUALS
### PRAISE + PROVISIONS, A CURATED RESTAURANT APP
#### The visuals below will walk you through the intentional design flow of the webb application
**PRAISE + PROVISIONS _Welcome Landing Page_**

+ To curate the experience the app is intentionally desinged to bring the user directly to the login page</br>

![welcome - web app landing page](https://user-images.githubusercontent.com/39015829/48316137-73788980-e594-11e8-9c7d-5ed8dc3bf250.jpg)

**PRAISE + PROVISIONS _Search Page_**

+ The user is persisted behind the scene and the user is now directed to the search page</br>

![search page](https://user-images.githubusercontent.com/39015829/48316552-2d262900-e59a-11e8-86fe-410fd4486dd7.jpg)

